using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados
{
    public partial class Form1 : Form
    {
        Dado d1,d2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d1 = new Dado();
            int[] registro;
            registro = new int[6];
            int lanza,count=1;
            for (int i=0; i<100;i++)
            {
                lanza = d1.lanzarDado();
                registro[lanza - 1]++;  
            }
            foreach (int element in registro)
            {
                textBox1.Text += "Cara "+count+": "+Convert.ToString(element) + Environment.NewLine;
                count++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d1 = new Dado();
            d2 = new Dado();
            int[] registro;
            registro = new int[11];
            int lanza,count=2;
            for (int i = 0; i < 100; i++)
            {
                lanza = d1.lanzarDado()+d2.lanzarDado();
                registro[lanza - 2]++;
            }
            foreach (int element in registro)
            {
                textBox1.Text +="Suma "+count+": "+ Convert.ToString(element) + Environment.NewLine;
                count++;
            }
        }
    }
}
