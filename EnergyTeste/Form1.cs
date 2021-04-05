using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnergyTeste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void CalcularEnergy_Click(object sender, EventArgs e)
        {
            
        }

        private void CalcularEnergy_Click_1(object sender, EventArgs e)
        {
            ValorConta2.Text =Convert.ToString(Convert.ToDouble(ConsumoKWH2.Text) * Convert.ToDouble(ValorTarifa2.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
