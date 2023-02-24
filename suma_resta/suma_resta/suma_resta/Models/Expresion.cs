using System;
using System.Collections.Generic;
using System.Text;

namespace suma_resta.Models
{
    public class Expresion
    {
        public int num1 { get; set; }
        public int num2 { get; set; }





        public int sumar() {
            int suma = num1 + num2;
            return suma;
           
               
            

        }

        public int restar()
        {
            int resta = num1 - num2;
            return resta;
        }
        public int multiplicar()
        {
            int multiplicacion = num1 * num2;
            return multiplicacion;
        }
        public int division()
        {
            int dividir = num1 / num2;
            return dividir;
        }

        
        
        public override string ToString()
        {

            return $"El tresultado de la suma es: {sumar()} \n" +
                    $"El tresultado de la resta es: {restar()}\n" +
                    $" El tresultado de la Multiplicacion es: {multiplicar()} \n" +
                    $"El tresultado de la Division: {division()} ";




        }



    }
}
