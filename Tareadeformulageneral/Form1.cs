using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tareadeformulageneral
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double a, b, c, d;
            if (this.txta.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el valor de A.");
                this.txta.Focus();//ubica el cursor en el cuadro de texto
                return;
            }
            if (this.txtb.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el valor de B.");
                this.txtb.Focus();//ubica el cursor en el cuadro de texto
                return;
            }
            if (this.txtc.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el valor de C.");
                this.txtc.Focus();//ubica el cursor en el cuadro de texto
                return;
            }
            a = Double.Parse(this.txta.Text);
            b = Double.Parse(this.txtb.Text);
            c = Double.Parse(this.txtc.Text);
            if (a == 0)
            {
                MessageBox.Show("Error al dividir para cero...");
                return;
            }
            d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                MessageBox.Show("Error, la ecuacion tiene soluciones imaginarias");
                return;
            }
            double x1 = apptareaclase.tareaformula.x1(a, b, c);
            double x2 = apptareaclase.tareaformula.x2(a, b, c);
            this.txt1.Text = x1.ToString();
            this.txt2.Text = x2.ToString();
        }
    }
}
