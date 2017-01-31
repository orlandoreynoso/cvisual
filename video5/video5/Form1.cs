using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace video5
{
    public partial class Form1 : Form
    {
        private string dinero, categoria;            
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl4.Text = "izquierda";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbl4.Text = "derecha";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbl4.Text = "arriba";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lbl4.Text = "Abajo";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dinero = "$100 dolares";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dinero = "$200 dolares";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            dinero = "$300 dolares";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lbldinero.Text = dinero;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
