/*Condicionales
Console.WriteLine("Ingresa un numero");
int num =int.Parse(Console.ReadLine());
if (num>0) Console.WriteLine("El número es positivo!");
else if (num<0) Console.WriteLine("El número es negativo");
else Console.WriteLine("El número es cero");
Fin del condicional*/

//Operadores
Console.WriteLine("Ingresa un numero");
double num =double.Parse(Console.ReadLine());
Console.WriteLine("\nIngresa otro numero");
double num2 =double.Parse(Console.ReadLine());
const string Indeterminado ="Indeterminado";
Console.WriteLine($"La suma de los números es: {num+num2}, \nLa resta es: {num-num2}, \nLa Multiplicacion es: {num*num2}, \n La división es: {(num2!=0 ? num/num2 : Indeterminado)}");