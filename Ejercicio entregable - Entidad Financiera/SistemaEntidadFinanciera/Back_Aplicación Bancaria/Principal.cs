using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Back_Aplicación_Bancaria
{
    public class Principal
    {
        BaseDatos Bdatos = new BaseDatos();
        public void AltaCliente(Cliente cliente)
        {
            using (var context = new BaseDatos())
            {
                var NuevoCliente = new Cliente
                {
                    DNI = cliente.DNI,
                    Nombre_cliente = cliente.Nombre_cliente,
                    Apellido_cliente = cliente.Apellido_cliente,

                };
                context.SaveChanges();
            }
        }
        public void CrearCuenta(Cuenta_Bancaria cuenta)
        {
            using (var context = new BaseDatos())
            {
                var CuentaNueva = new Cuenta_Bancaria
                {
                    Numero_Cuenta = cuenta.Numero_Cuenta,
                    saldo = cuenta.saldo,
                    tipo_cuenta = cuenta.tipo_cuenta,
                    Dueño = cuenta.Dueño,

                };
                context.Cuentas.Add(CuentaNueva);
                context.SaveChanges();
            }
        }
        public void EmitirTarjeta(Tarjeta_de_Crédito tarjeta)
        {
            using (var context = new BaseDatos())
            {
                var TarjetaNueva = new Tarjeta_de_Crédito
                {
                    numeroTarjeta = tarjeta.numeroTarjeta,
                    limiteCredito = tarjeta.limiteCredito,
                    saldoDisponible = tarjeta.saldoDisponible,
                    estado = tarjeta.estado,
                    DueñoTarjeta = tarjeta.DueñoTarjeta,

                };
                context.Tarjetas.Add(TarjetaNueva);
                context.SaveChanges();
            }
        }
        public void PausarTarjeta(int Id)
        {
            using (var context = new BaseDatos())
            {
                var tarjetas = context.Tarjetas.Find(Id);
                if (tarjetas != null)
                {
                    tarjetas.estado = "Pausada";
                    context.SaveChanges();
                }

            }
        }
        public void RealizarDeposito(Cuenta_Bancaria cuenta, double monto, int Id)
        {
            using (var context = new BaseDatos())
            {
                var cuentas = context.Cuentas.FirstOrDefault(t => t.Id == Id);

                if (cuenta == null)
                {
                    cuentas.saldo = +monto;

                    context.SaveChanges();
                }
            }
        }
        public void RealizarExtracción(Cuenta_Bancaria cuenta, double monto, int Id)
        {
            using (var context = new BaseDatos())
            {
                var cuentas = context.Cuentas.FirstOrDefault(t => t.Id == Id);

                if (cuenta == null)
                {
                    cuenta.saldo = -monto;

                    context.SaveChanges();
                }
            }
        }
        public void Realizartranferencia(Cuenta_Bancaria cuentaDestino,
            double montotranferido, Cuenta_Bancaria cuentaOrigen)
        {
            using (var context = new BaseDatos())
            {
                if (cuentaOrigen == null)
                {
                    if (montotranferido > cuentaOrigen.saldo)
                    {
                        cuentaDestino.saldo = +montotranferido;

                        context.SaveChanges();
                    }
                }
            }
        }
        public void PagarTarjeta(double monto, int  Id) 
        {
            using (var context = new BaseDatos())
            {
                var tarjeta = context.Tarjetas.FirstOrDefault(t => t.Id == Id);

                if (tarjeta != null)
                {
                    if (tarjeta.saldoDisponible >= monto)
                    {
                        tarjeta.saldoDisponible -= monto;
                        context.SaveChanges();
                    }
                }

            }
        }

        public string ResumenTarjeta()
        {
            using (var context = new BaseDatos())
            {
                List<Tarjeta_de_Crédito> ListaTarjeta = context.Tarjetas.ToList();
                if (ListaTarjeta.Count > 0)
                {
                    StringBuilder resultado = new StringBuilder();
                    foreach (var unatarjeta in ListaTarjeta)
                    {
                        resultado.AppendLine($" numerocunta: {unatarjeta.numeroTarjeta}" +
                            $"saldo: {unatarjeta.saldoDisponible} limite: {unatarjeta.limiteCredito} estado: {unatarjeta.estado}" +
                            $"dueño: {unatarjeta.DueñoTarjeta}");
                    }
                    return resultado.ToString();
                }
                else
                {
                    return "No hay datos encontrado"; 
                }
            }
   
            
        }
    }
}
