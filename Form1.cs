using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // comboBox1.Items.AddRange(new string[] { "Suma", "Resta", "Multiplicación", "División" });
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola", "titulo\n");
            MessageBox.Show("mario cañola\n");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
          
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!int.TryParse(textBox7.Text, out a) || !int.TryParse(textBox8.Text, out b))
            {
                MessageBox.Show("Por favor, ingresa números válidos.");
                return;
            }

            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona una operación.");
                return;
            }

            string operacion = comboBox1.SelectedItem.ToString();
            int resultado = 0;
            string mensaje = "";

            switch (operacion)
            {
                case "Suma":
                    resultado = a + b;
                    mensaje = "El resultado de la suma es: " + resultado;
                    break;
                case "Resta":
                    resultado = a - b;
                    mensaje = "El resultado de la resta es: " + resultado;
                    break;
                case "Multiplicación":
                    resultado = a * b;
                    mensaje = "El resultado de la multiplicación es: " + resultado;
                    break;
                case "División":
                    if (b == 0)
                    {
                        MessageBox.Show("No se puede dividir por cero.");
                        return;
                    }
                    resultado = a / b;
                    mensaje = "El resultado de la división es: " + resultado;
                    break;
                default:
                    MessageBox.Show("Operación no reconocida.");
                    return;
            }

            MessageBox.Show(mensaje, "Resultado");
        }

    }

}
