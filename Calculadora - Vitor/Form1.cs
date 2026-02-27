using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora___Vitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);

            int num2 = int.Parse(textBox2.Text);
            int result = num1 + num2;

            label2.Text = string.Format("{0} + {1} = {2}", num1, num2, num1 + num2);

            //OUTRAS CONVERSÕES
            //double V = double.parse(text.box1.Text); //Conversão de string para string
            //ou double V = Convert.ToDouble(text.box1.Text); 
            // bool R = bool.parse(text.box1.Texe); //Conversão de boolean para string
            // OU bool R = Convert.ToBoolean(text.box1.Text)
            // char L = char.parse(text.box1.Text); // conversão de char para string
            // OU char L = Convert.ToChar(text.box1.Text)

            //OPERADORES ARITMÉTICOS
            // + Adição;
            // - subtração;
            // * multiplicação;
            // % resto da divisão;
            // / divisão;

            //OPERADORES RELACIONAIS
            // > maior que
            // < menor que
            // >= maior ou igual
            // <= menor ou igual
            // == igual a
            // != diferente de 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
