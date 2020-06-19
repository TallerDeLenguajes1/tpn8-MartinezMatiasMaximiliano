using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraLista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            TB.Clear();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            TB.Text += 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TB.Text += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TB.Text += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TB.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TB.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TB.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TB.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TB.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TB.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TB.Text += 9;
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            TB.Text += '.';
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            TB.Text += '+';
        }


        private void buttonMin_Click(object sender, EventArgs e)
        {
            TB.Text += '-';
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            TB.Text += '*';
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            TB.Text += '/';
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            string Texto = TB.Text;

            Nodo nuevo = new Nodo();

            nuevo.Fecha = DateTime.Now;

            if (Texto.Contains('+'))
            {
                string[] arreglo = Texto.Split('+');
                nuevo.Numero1 = Convert.ToSingle(arreglo[0]);
                nuevo.Numero2 = Convert.ToSingle(arreglo[1]);
                nuevo.Operador = '+';

                nuevo.Resultado = nuevo.Operacion();
                TB.Text = Convert.ToString(nuevo.Resultado);

                Historial.Items.Add(nuevo.Numero1 + nuevo.Operador.ToString() + nuevo.Numero2 + '=' + nuevo.Resultado + "----->" + nuevo.Fecha);
                Historial.Refresh();

            } else if(Texto.Contains('-'))
            { 
                string[] arreglo = Texto.Split('-');
                nuevo.Numero1 = Convert.ToSingle(arreglo[0]);
                nuevo.Numero2 = Convert.ToSingle(arreglo[1]);
                nuevo.Operador = '-';

                nuevo.Resultado = nuevo.Operacion();
                TB.Text = Convert.ToString(nuevo.Resultado);

                Historial.Items.Add(nuevo.Numero1 + nuevo.Operador.ToString() + nuevo.Numero2 + '=' + nuevo.Resultado + "----->" + nuevo.Fecha);
                Historial.Refresh();
            

            }else if(Texto.Contains('*'))
            {
                string[] arreglo = Texto.Split('*');
                nuevo.Numero1 = Convert.ToSingle(arreglo[0]);
                nuevo.Numero2 = Convert.ToSingle(arreglo[1]);
                nuevo.Operador = '*';

                nuevo.Resultado = nuevo.Operacion();
                TB.Text = Convert.ToString(nuevo.Resultado);

                Historial.Items.Add(nuevo.Numero1 + nuevo.Operador.ToString() + nuevo.Numero2 + '=' + nuevo.Resultado + "----->" + nuevo.Fecha);
                Historial.Refresh();

            }
            else if(Texto.Contains('/'))
            {

                string[] arreglo = Texto.Split('/');
                nuevo.Numero1 = Convert.ToSingle(arreglo[0]);
                nuevo.Numero2 = Convert.ToSingle(arreglo[1]);
                nuevo.Operador = '/';

                if(nuevo.Numero2 != 0)
                {
                    nuevo.Resultado = nuevo.Operacion();
                    TB.Text = Convert.ToString(nuevo.Resultado);

                    Historial.Items.Add(nuevo.Numero1 + nuevo.Operador.ToString() + nuevo.Numero2 + '=' + nuevo.Resultado + "----->" + nuevo.Fecha);
                    Historial.Refresh();
                }
                else
                {
                    nuevo.Resultado = -987654321;
                    TB.Text = "MATH ERROR";

                    Historial.Items.Add(nuevo.Numero1 + nuevo.Operador.ToString() + nuevo.Numero2 + '=' + "MATH ERROR" + "----->" + nuevo.Fecha);
                    Historial.Refresh();
                }

            }

        }

        private void Historial_SelectedIndexChanged(object sender, EventArgs e)
        {
            Historial.Items.Remove(Historial.SelectedItem);
        }
    }
}
