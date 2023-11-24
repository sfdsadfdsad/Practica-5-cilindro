using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_5_cilindro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Radius, Height;
            double BaseArea, LateralArea, TotalArea;
            double volumen;
            double Pi = 3.141592;

            Radius = double.Parse(textBox1.Text);
            Height = double.Parse(textBox2.Text);

            BaseArea = Radius * Radius * Pi;
            LateralArea = 2 * Pi * Radius * Height;
            TotalArea = 2 * Pi * Radius * (Radius + Height);
            volumen = Pi * Radius * Height;

            textBox3.Text = BaseArea.ToString("0.##");
            textBox4.Text = LateralArea.ToString("0.##");
            textBox5.Text = TotalArea.ToString("0.##");
            textBox6.Text = volumen.ToString("0.##");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
