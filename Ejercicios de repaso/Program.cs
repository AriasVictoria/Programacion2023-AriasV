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


//EJERCICIO 1 WHILE: El usuario ingresará valores positivos, cuando no tenga más valores ingresará 0 (cero) El sistema deberá informar la suma de los ingresados.
// Siguiendo el ejercicio anterior, calcular el promedio de los valores ingresados

Console.WriteLine("Ingresame un valor y cuando no tengas mas ingresa un 0");
Console.WriteLine("Ingresa un valor: ");
int valores = 1;
int sumita = 0;
int promedio = 0;
List<int> valor = new List<int>();

while (valores > 0)
{
    sumita = valor.Sum();
    promedio = sumita / valor.Count();
    Console.WriteLine("El resultado de la suma es :" + sumita);
    Console.WriteLine("El resultado del promedio es " + promedio);
}

