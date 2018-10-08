﻿using System;
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


        {
            //Crea una aplicación que nos calcule el área de un circulo, cuadrado o triangulo.
            //Pediremos que figura queremos calcular su área y según lo introducido pedirá los valores necesarios para calcular el área.
            //Crea un método por cada figura para calcular cada área, este devolverá un número real.
            //Muestra el resultado por pantalla
            //Aquí te mostramos que necesita cada figura:
            //Circulo: (radio ^ 2) * PI
            //Triangulo: (base * altura) / 2
            //Cuadrado: lado* lado
            int figura,contador=0;
            double radCirc,baseTri,altTri,ladoCua;

            do
            {
                if (contador > 0)
                {
                    Console.WriteLine("Elección no válida, pruebe de nuevo\n\n");
                }
                Console.WriteLine("Elija el tipo de figura:\n1.Círculo\n2.Triángulo\n3.Cuadrado\n0.Salir\n");
                figura = Int32.Parse(Console.ReadLine());
                contador = contador + 1;
            } while (figura<0||figura>3);
            switch (figura)
            {
                case 1:
                    Console.WriteLine("Introduzca el radio del círculo\n");
                    radCirc = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El área del círculo es "+areaCirc(radCirc));
                    break;
                case 2:
                    Console.WriteLine("Introduzca la base del triángulo\n");
                    baseTri = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Introduzca la altura del triángulo\n");
                    altTri= Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El área del triángulo es " +areaTri(altTri,baseTri));
                    break;
                case 3:
                    Console.WriteLine("Introduzca el lado del cuadrado\n");
                    ladoCua = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("El área del cuadrado es " + areaCua(ladoCua));
                    break;
                case 0:
                    Console.WriteLine("Ha elegido salir");
                    break;
            }




            Console.ReadLine();
        }
        const double PI= 3.14159;
        public static double areaCirc(double radCir)
        {
            return Math.Pow(radCir,2)*PI;
        }
        public static double areaTri(double alturaTri,double baseTri)
        {
            return (alturaTri*baseTri)/2;
        }
        public static double areaCua(double ladoCua)
        {
            return Math.Pow(ladoCua, 2);
        }
    }
}
