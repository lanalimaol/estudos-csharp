using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto
{
    internal class Triangulo
    {

        //atributos de uma instancia TRIANGULO 
        public double ladoA { get; set; }
        public double ladoB { get; set; }
        public double ladoC { get; set; }
   



        //metodos de uma instancia TRIANGULO (semiperimetro e area)
        public double SemiPerimetro()
        {
           return (ladoA + ladoB + ladoC) / 2.0;

        }

        public double AreaTriangulo()
        {
           double p = SemiPerimetro(); 
           return Math.Sqrt(p * (p - ladoA) * (p - ladoB) * (p - ladoC ));
        }

    }

}

