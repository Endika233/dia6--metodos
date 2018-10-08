using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dia6__metodos
{
    class Program
    {
        static void Main(string[] args)
        //{
        //    //Diseña método esPar()
        //    int num;
        //    Console.WriteLine("Escribe un número");
        //    num = Int32.Parse(Console.ReadLine());
        //    esPar(num);
        //}

        ////El metodo se inserta fuera de la llave principal(main)
        ////como aqui solo va a escribir es par o no, no se recibe valor, poner void
        //public static void esPar(int numRecibido)
        //{
        //    if (numRecibido % 2 == 0)
        //    {
        //        Console.WriteLine("Es par");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Es impar");
        //    }
        //    Console.ReadKey();
        //}


        //{
        //    //Crea una aplicación que nos calcule el área de un circulo, cuadrado o triangulo.
        //    //Pediremos que figura queremos calcular su área y según lo introducido pedirá los valores necesarios para calcular el área.
        //    //Crea un método por cada figura para calcular cada área, este devolverá un número real.
        //    //Muestra el resultado por pantalla
        //    //Aquí te mostramos que necesita cada figura:
        //    //Circulo: (radio ^ 2) * PI
        //    //Triangulo: (base * altura) / 2
        //    //Cuadrado: lado* lado
        //    int figura,contador=0;
        //    double radCirc,baseTri,altTri,ladoCua;

        //    do
        //    {
        //        if (contador > 0)
        //        {
        //            Console.WriteLine("Elección no válida, pruebe de nuevo\n\n");
        //        }
        //        Console.WriteLine("Elija el tipo de figura:\n1.Círculo\n2.Triángulo\n3.Cuadrado\n0.Salir\n");
        //        figura = Int32.Parse(Console.ReadLine());
        //        contador = contador + 1;
        //    } while (figura<0||figura>3);
        //    switch (figura)
        //    {
        //        case 1:
        //            Console.WriteLine("Introduzca el radio del círculo\n");
        //            radCirc = Convert.ToDouble(Console.ReadLine());
        //            Console.WriteLine("El área del círculo es "+areaCirc(radCirc));
        //            break;
        //        case 2:
        //            Console.WriteLine("Introduzca la base del triángulo\n");
        //            baseTri = Convert.ToDouble(Console.ReadLine());
        //            Console.WriteLine("Introduzca la altura del triángulo\n");
        //            altTri= Convert.ToDouble(Console.ReadLine());
        //            Console.WriteLine("El área del triángulo es " +areaTri(altTri,baseTri));
        //            break;
        //        case 3:
        //            Console.WriteLine("Introduzca el lado del cuadrado\n");
        //            ladoCua = Convert.ToDouble(Console.ReadLine());
        //            Console.WriteLine("El área del cuadrado es " + areaCua(ladoCua));
        //            break;
        //        case 0:
        //            Console.WriteLine("Ha elegido salir");
        //            break;
        //    }




        //    Console.ReadLine();
        //}
        //const double PI= 3.14159;
        //public static double areaCirc(double radCir)//Por ahora poner static siempre
        //{
        //    return Math.Pow(radCir,2)*PI;
        //}
        //public static double areaTri(double alturaTri,double baseTri)
        //{
        //    return (alturaTri*baseTri)/2;
        //}
        //public static double areaCua(double ladoCua)
        //{
        //    return Math.Pow(ladoCua, 2);
        //}
        //{
        //    //Escribe una función que devuelva el resultado de sumar los dos parámetros que le pasamos. 
        //    //Asigna el valor de llamar a la función en una variable en el programa principal y muestra el resultado en la pantalla
        //    ////PARTE 2:Usa esos 2 números como parámetros de la función
        //    ////y después asigna el valor que devuelve la función a una tercera variable en el programa. Finalmente, muestra el valor de la variable en la pantalla.

        //    int num1, num2,sumaNum;

        //    Console.WriteLine("Introduzca los dos números a sumar");
        //    num1 = Convert.ToInt32(Console.ReadLine());
        //    num2 = Convert.ToInt32(Console.ReadLine());
        //    sumaNum = Suma(num1, num2);
        //    Console.WriteLine("La suma de ambos números es " + sumaNum);
        //    Console.ReadKey();

        //}
        //public static int Suma(int num1, int num2)
        //{
        //    return num1 + num2;
        //}

        //{
        //    //Escribe un programa que pida al usuario dos números. 
        //    //Usa esos 2 números en una función que divide el primero por el segundo y devuelve el resultado. 
        //    //Muestra el resultado que devuelve la función en pantalla. 
        //    //Después vuelve a pedir los números y hacer todo otra vez hasta que el usuario introduzca un 0 como segundo número.
        //    double num1, num2;
        //    do
        //    {
        //        Console.WriteLine("Introduzca los números a dividir, si desea salir del programa introduza 0 en el segundo número");
        //        num1 = Convert.ToDouble(Console.ReadLine());
        //        num2 = Convert.ToDouble(Console.ReadLine());
        //        if (num2 != 0)
        //        {
        //            Console.WriteLine("La división de ambos números es " + div(num1, num2));
        //        }
        //    } while (num2 != 0);
        //    Console.WriteLine("Ha salido del programa");
        //    Console.ReadKey();

        //}
        //public static double div(double num1,double num2)
        //{
        //    return num1 / num2;
        //}

        //{
        //    //Escribe una función a la que le damos dos números y que devuelva true si el primer núm es + grande que el seg
        //    //y false en el caso contrario. En el programa principal, pide dos números al usuario, y pasalos a la función. 
        //    //Muestra en pantalla “El primer número es más grande” o “El primer número no es más grande”.
        //    int num1, num2;
        //    Console.WriteLine("Introduzca dos números");
        //    num1 = Int32.Parse(Console.ReadLine());
        //    num2 = Int32.Parse(Console.ReadLine());
        //    if (Max1(num1, num2))//Si es verdadero escribe esto
        //    {
        //        Console.WriteLine("El primer número es más grande");
        //    }
        //    else
        //    {
        //        Console.WriteLine("El primer número no es más grande");
        //    }
        //    Console.ReadLine();


        //}
        //public static bool Max1(int num1,int num2)
        //{
        //    if(num1>num2)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //{
        //    //Escribe una función a la que le pasamos un año y devuelve true si es bisiesto. 
        //    //En el programa principal, pídele al usuario un número y muestra en pantalla “El año … es bisiesto” o 
        //    //“El año … no es bisiesto” y sigue pidiendo números y diciendo si es o no bisiesto hasta que introduzca un 0.
        //    int año;
        //    do
        //    {
        //        Console.WriteLine("Introduzca un número de año (0 para salir)");
        //        año = Int32.Parse(Console.ReadLine());
        //        if (Bisies(año))
        //        {
        //            Console.WriteLine("El año " + año + " es bisiesto");
        //        }
        //        else
        //        {
        //            Console.WriteLine("El año " + año + " no es bisiesto");
        //        }


        //    } while (año != 0);

        //}
        //public static bool Bisies(int año)
        //{
        //    if ((año % 4 == 0 && año % 100 != 0) || año % 400 == 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        //{
        //    //Escribe una función que reciba un array y lo muestre en pantalla de modo ascendente. 
        //    //Después escribe otra función que reciba un array y lo muestre en pantalla de modo descendencte.  
        //    //Crea un array en el programa principal y pásalo a cada una de las funciones.

        //    int[] array = { 0, 1, 2, 3, 4, 5 };

        //    Ascen(array);
        //    Descen(array);
        //    Console.ReadLine();
        //}
        //public static void Ascen(int[]array)
        //{
        //    for(int i = 0; i< array.Length; i++)
        //    {
        //        Console.WriteLine(array[i]);
        //    }
        //}
        //public static void Descen(int[]array)
        //{
        //    for (int j = (array.Length-1); j >= 0; j--)
        //    {
        //        Console.WriteLine(array[j]);
        //    }
        //}



        //{
        //    //Escriba una función que reciba un array y un valor booleano. 
        //    //Si el booleano es true, mostrar el array de modo ascendente, si es false, mostrarlo de modo descendente. 
        //    //En el programa principal, crear un array y hacer que la función lo muestre primero en modo ascendente y después en modo descendente.
        //    int [] array = {0,1,2,3,4,5};
        //    bool kuato;
        //    Console.WriteLine("v bool verdadero, demás falso");
        //    if (Console.ReadLine() == "v")
        //    {
        //        kuato = true;
        //    }
        //    else
        //    {
        //        kuato = false;
        //    }
        //    ArrayBool(array, kuato);
        //    Console.ReadLine();
        //}
        //public static void ArrayBool(int[]array,bool kuato)
        //{
        //    if (kuato)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            Console.WriteLine(array[i]);
        //        }
        //    }
        //    else
        //    {
        //        for (int j = (array.Length - 1); j >= 0; j--)
        //        {
        //            Console.WriteLine(array[j]);
        //        }
        //    }
        //}


        {
            //Modifica el proyecto Contadores para que utilice funciones. Sobre todo, que no haya ningún código repetido, 
            //pero también para agrupar código en distintas funcionalidades.
            int option;
            do
            {
                Console.WriteLine("\nPulsa 1 para contar normalmente.");
                Console.WriteLine("Pulsa 2 para contar como un ingeniero de la NASA.");
                Console.WriteLine("Pulsa 3 para contar como un estudiante universitario.");
                Console.WriteLine("Pulsa 4 para contar como en barrio sesamo.");
                Console.WriteLine("Pulsa 5 para contar como un cartero.");
                Console.WriteLine("Pulsa 6 para salir.");
                option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        CountNormally(GetPositiveNumber());
                        break;
                    case 2:
                        CountNasa(GetPositiveNumber());
                        break;
                    case 3:
                        CountUni(GetPositiveNumber());
                        break;
                    case 4:
                        CountSesame(GetPositiveNumber()); 
                        break;
                    case 5:
                        CountMail(GetPositiveNumber());
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("Esa opción no existe, elija otra");
                        Console.WriteLine();
                        break;
                }
             } while (option != 6);
            Console.WriteLine("ADIOS");
            Console.ReadLine();
        }
    

        public static int GetPositiveNumber()
        {
            int countLimit;
            do
            {
                Console.WriteLine("¿Hasta qué número quieres contar (número mayor que 0)?");
                countLimit = Convert.ToInt32(Console.ReadLine());
            } while (countLimit <= 0);
            Console.WriteLine();

            return countLimit;
        }
        public static void CountNormally(int countLimit)
        {
            for (int i = 1; i <= countLimit; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void CountNasa(int countLimit)
        {
            for (int i = countLimit; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("¡¡¡Ignición!!!");
        }
        public static void CountUni(int countLimit)
        {
            int cardValue;
            for (int i = 1; i <= countLimit; i++)
            {
                cardValue = i % 10;
                if (cardValue == 1)
                {
                    Console.WriteLine("Ás");
                }
                else if (cardValue == 8)
                {
                    Console.WriteLine("Sota");
                }
                else if (cardValue == 9)
                {
                    Console.WriteLine("Caballo");
                }
                else if (cardValue == 0)
                {
                    Console.WriteLine("Rey");
                }
                else
                {
                    Console.WriteLine(cardValue);
                }
            }
        }
        public static void CountSesame(int countLimit)
        {
            for (int i = 1; i <= countLimit; i++)
            {
                Console.WriteLine("¡¡¡¡¡¡¡ " + i + " !!!!!!!");
            }
        }
        public static void CountMail(int countLimit)
        {
            for (int i = 1; i <= countLimit; i += 2)
            {
                Console.WriteLine(i);
            }
            for (int i = 2; i <= countLimit; i += 2)
            {
                Console.WriteLine(i);
            }
        }

    }
}
