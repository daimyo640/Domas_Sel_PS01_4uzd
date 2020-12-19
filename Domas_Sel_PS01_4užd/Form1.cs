using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domas_Sel_PS01_4užd
{
    public partial class Form1 : Form
    {
        public double[] sarasas = new double[10];
        public int sk = 0;
        public double suma=0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sk <= 9)
            {
                String ivestis = textBox1.Text;
                double.TryParse(ivestis, out double a);
                sarasas[sk] = a;             
                label2.Text = "Įveskite dar " + (10-sk).ToString() + " skaičius.";
                sk++;
            }
            
            else
            {
                for(int i=0; i<=9; i++)
                {
                    suma += sarasas[i];
                    label2.Text = suma.ToString();
                }
                button1.Enabled = false;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            String ivestis = textBox2.Text;
            int.TryParse(ivestis, out int a);
            int tarpu_sk = a;

            for(int i=0; i<a; i++)
            {               
                richTextBox1.AppendText(String.Concat(Enumerable.Repeat(" ", tarpu_sk)));
                tarpu_sk--;
                richTextBox1.AppendText(String.Concat(Enumerable.Repeat("* ", i+1)));
                richTextBox1.AppendText("\r\n");
            }
        }
    }
}
