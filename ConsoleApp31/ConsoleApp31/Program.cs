using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            // primitivos
            int variable = 20;
            double dec = 50.0;  // no estan optimiza
            float dec2 = 50.0f; // optimizado por la FPU
            //  flotantes.    100000000000000000.0   0.0000000000000001
            //           no son precisos. 10000000000000000.00000000001 = 1000000000000000.0
            //                          100000000000000000 = 9999999999999.9

            string texto = "hola";
            texto = "hola\nmundo"; // \n = salto de linea \t = tab
            Debug.WriteLine(texto);

            texto = @"hola\nmundo"; // (ESCAPE) \n = salto de linea \t = tab
            Debug.WriteLine(texto);

            texto = "hola" +" "+ "mundo";

            Debug.WriteLine(texto);

            int numero = 20;

            texto = "el valor es :" +numero;
            Debug.WriteLine(texto);

            texto = $"el valor es :{numero} ";
            Debug.WriteLine(texto);

            char caracteres = 'a'; // "a"

            bool boleano = true; // false

            int num1 = 2;
            int num2 = 3;

            boleano = num1 == num2; // == es igual.
            boleano = num1 < num2; // <, >, <=, >=
            boleano = num1 != num2; // <, >, <=, >=
            boleano = num1 == num2 && num1==num2; // && = Y logico  (ambas empresiones tienen verdaderas)
            boleano = (num1 == num2) || (num1==num2); // || = o logico  (solamente una expresion tiene verdadero)
            //           false     ||   false = false


            int num3 = (40 * 3) + 2 / 2 - 30;

            // + / * - operaciones binarias (involucra dos valores).
            // 1 + 2 + 3 
            // 1 + 2 
            //   3   + 3
            //  num1 == num2 == num3 
            //  num1 == num2
            //     resultado == num3

            Debug.WriteLine("ejemplos con nulos--------------");
            // ejemplo nulos
            string texto20 = "";
            Debug.WriteLine(texto20);
            string texto21=null; 
            Debug.WriteLine(texto21);





        }
    }
}
