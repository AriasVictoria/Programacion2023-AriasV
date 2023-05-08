// See https://aka.ms/new-console-template for more information
/*
// EJERCICIO 1 DO WHILE: Para el ingreso a un sistema se necesita solicitar nombre de usuario y clave, repetir este ingreso hasta que el usuario ingrese la clave correcta: 667788.
Console.WriteLine("Ingrese la clave");
string? clave = Console.ReadLine();
do
{
    clave = Console.ReadLine();
} while (clave != "667788");
Console.WriteLine("correcto");
*/
/*
//EJERCICIO 2 y 3 DO WHILE: Se le solicitará ingresar un número al usuario, se repetirá el pedido hasta que ingrese un positivo.
//Siguiendo con el ejercicio anterior, al ingresar el positivo se mostrará el promedio de los números negativos ingresados 

Console.WriteLine("Ingrese un numero");
double numero = -1;
double suma;
double promedio;
List<double> negativos = new List<double>();
do
{
    numero = Convert.ToDouble((Console.ReadLine()));
    if (numero < 0)
    {
        negativos.Add(numero);
    }
    else {
        suma = negativos.Sum();
        promedio = suma / negativos.Count();
        Console.WriteLine("El resultado del promedio es " + promedio);
    }
} while (numero < 0);
*/
/*
//EJERCICIO 4 Y 5 DO WHILE: Se le solicitará ingresar números al usuario, se repetirá el pedido hasta que ingrese un número mayor a 3 cifras.
//Siguiendo con el ejercicio anterior, al ingresar uno mayor o menor a 3 cifras se mostrará el promedio de los ingresados. 
Console.WriteLine("ingresde un numero más de 3 cifras");
int num = 100;
double sumita;
double prom;

List<double> cifras = new List<double>();
do
{
    num = Convert.ToInt32((Console.ReadLine()));
    if (num > 100)
    {
        cifras.Add(num);
    }
    else
    {
        sumita = cifras.Sum();
        prom = sumita / cifras.Count();
        Console.WriteLine("El resultado del promedio es " + prom);
    }
     
} while (num > 100);
*/


//EJERCICIO 1  y 2 WHILE: El usuario ingresará valores positivos, cuando no tenga más valores ingresará 0 (cero) El sistema deberá informar la suma de los ingresados.
// Siguiendo el ejercicio anterior, calcular el promedio de los valores ingresados
/*

Console.WriteLine("Ingresame un valor y cuando no tengas mas ingresa un 0");
Console.WriteLine("Ingresa un valor: ");
int valores = 1;
int sumita = 0;
int promedio = 0;
List<int> valor = new List<int>();

while (valores > 0)
{
    valores = Convert.ToInt32((Console.ReadLine()));
    if (valores > 0)
    {
        valor.Add(valores);
    }
    else
    {
        sumita = valor.Sum();
        promedio = sumita / valor.Count();
        Console.WriteLine("El resultado de la suma es :" + sumita);
        Console.WriteLine("El resultado del promedio es " + promedio);
    }
}
*/

//EJERCICIO 3 WHILE: El usuario ingresará una lista de nombre de persona, cuando se ingresé un nombre vacío, sin datos;
//el sistema informará cuántos nombres se han ingresado.
/*
Console.WriteLine("Ingrese un nombre: ");
string nombre = Console.ReadLine();

int contador = 0;

while (nombre != "")
{
    contador = contador + 1;
    Console.WriteLine("Ingrese un nombre: ");
    nombre = Console.ReadLine();
}
Console.WriteLine("La cantidad de nombres fueron: " + contador)
*/

//EJERCICIO 4 WHILE: Para calcular el total de una factura , el usuario ingresará pares de datos Costo y Total ;
//cuando se ingrese costo 0 finaliza el ingreso de datos; informar el total adeudado
/*
Console.WriteLine("ingreseme el costo: ");
string costo = Console.ReadLine();
int costoNum = int.Parse(costo);
int sumita = 0;

while (costoNum > 0)
{

    Console.WriteLine("Ahora poneme el total: ");
    string total = Console.ReadLine();
    int totalNum = int.Parse(total);

    // En estancia yo ya tengo ingresado al menos 1 par de costo y total
    // así ´que acá sería un buen momento de hacer mi proceso
    sumita = sumita + (costoNum * totalNum);

    Console.WriteLine("ingreseme el costo: ");
    costo = Console.ReadLine();
    costoNum = int.Parse(costo);
}

Console.WriteLine("el total es: " + sumita);
*/

//EJERCICIO 5 WHILE O FOR: Para calcular el consumo total de un cliente, el usuario primero ingresará cuántos productos compró;
//luego el sistema solicitará que ingrese el total y costo de cada uno de esos productos consumidos;
//al terminar informará el total adeudado por el cliente. 
/*
Console.WriteLine("Ingresame cuantos productos compro: ");
string cant = Console.ReadLine();

int cantNum = int.Parse(cant);
int suma = 0; 

for (int i = 0; i <= cantNum; i++) 
{
    Console.WriteLine("poneme el total :");
    string total = Console.ReadLine();

    Console.WriteLine("poneme el costo :");
    string costo = Console.ReadLine();

    suma = suma + (int.Parse(costo)) + int.Parse(total);
}
Console.WriteLine("El total por el cliente es :", suma);
*/

//EJERICICIO 1 FOR: El usuario necesita ingresar 5 valores enteros, el sistema deberá informar la suma de los 5
/*
Console.WriteLine("te voy a pedir que ingreses los 5 valores enteros");
int n = 5;
double sum = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write("Ingrese el número: ");
    double num = Convert.ToDouble(Console.ReadLine());
    sum = sum + num;
}
Console.WriteLine("La suma de los números ingresados es: " + sum);
*/


//EJERCICIO 2 FOR: Se necesita calcular el promedio de 8 números ingresados por el usuario
/*
int n = 8;
double sum = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write("Ingrese el número: ");
    double num = Convert.ToDouble(Console.ReadLine());
    sum = sum + num;
}
Console.WriteLine("La suma de los números ingresados es: " + sum);
double prom = sum / n;
Console.WriteLine("El promedio de los números ingresados es: " + prom);
*/

//EJERCICIO 3 FOR: Para calcular el total de una factura , el usuario ingresará pares de datos Costo y Total ; de unas 5 compras;
//informar el total adeudado.
/*
int n = 5;
double totalAdeudado = 0;

for (int i = 1; i <= n; i++)
{
    Console.Write("Ingrese el costo de la compra: ");
    double costo = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingrese el total pagado de la compra: ");
    double totalPagado = Convert.ToDouble(Console.ReadLine());

    double adeudado = costo - totalPagado;
    totalAdeudado = totalAdeudado +  adeudado;
}
Console.WriteLine("El total adeudado es: " + totalAdeudado);
*/

/*
//EJERCICIO 4 FOR: De una lista de 8 números indicar cual es el mayor
int n = 8;
int mayor = int.MinValue; //numero minimo para comprar con el que se ingresa

for (int i = 1; i <= n; i++)
{
    Console.Write("Ingrese el número: ");
    int numero = Convert.ToInt32(Console.ReadLine()); //Numero ingresado almacenado en numero

    if (numero > mayor)
    {
        mayor = numero;
    }
}
Console.WriteLine("El número mayor es: " + mayor);
*/

//EJERCICIO 5 FOR: El usuario ingresa 5 pares de valores con el nombre del cliente y el total gastado, indicar el cliente que gastó más. 
int mayor = 0;
string nombre_quemasgasto = "";

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Ingresame el nombre del cliente: ");
    string nombre = Console.ReadLine();

    Console.WriteLine("Ingresame cuanto gasto el cliente: ");
    int gasto = int.Parse(Console.ReadLine());

    if (gasto > mayor)
    {
        mayor = gasto;
        nombre_quemasgasto = nombre;
    }
}
Console.WriteLine("El que mas gasto fue: " + nombre_quemasgasto);
Console.WriteLine("Y el total que gasto fue: " + mayor);
