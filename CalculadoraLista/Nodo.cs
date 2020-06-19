using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraLista
{
    class Nodo
    {
        private float numero1;
        private float numero2;
        private float resultado;
        private char operador;
        private DateTime fecha;

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }
        public float Resultado { get => resultado; set => resultado = value; }
        public char Operador { get => operador; set => operador = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }


        public float Operacion()
        {
            switch (operador)
            {
                case '+':
                    return numero1 + numero2;
                case '-':
                    return numero1 - numero2;
                case '*':
                    return numero1 * numero2;
                case '/':
                    return numero1 / numero2;
                default:
                    return 0;

            }
        }
    }
}
