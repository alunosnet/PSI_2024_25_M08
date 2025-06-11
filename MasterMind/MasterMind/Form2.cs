using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = comboBox1.SelectedIndex;
        }

        string gerar()
        {
            string senha = "";
            string letras = "abcdefg";
            string numeros = "1234567890";

            Random sortear = new Random();
            string letra = letras[sortear.Next(0, letras.Length)].ToString();

            senha += letra;

            return senha;
        }
    }
}
