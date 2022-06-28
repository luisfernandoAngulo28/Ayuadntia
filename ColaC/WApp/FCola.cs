using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CApp;

namespace WApp
{
    public partial class FCola : Form
    {
        public FCola()
        {
            InitializeComponent();
        }
        clsColaC C = new clsColaC();
        clsColaC P = new clsColaC();
        clsColaC Q = new clsColaC();
        private void button1_Click(object sender, EventArgs e)
        {
            if (P.llena() == true)
            {
                MessageBox.Show("cola llena");

            }
            else
            {
                int ele = int.Parse(textBox1.Text);
                P.Add(ele);
                label2.Text = P.Mostrar();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            C.Delete();
            label2.Text = C.Mostrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = C.From().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Q.llena() == true)
            {
                MessageBox.Show("cola llena");

            }
            else
            {
                int ele = int.Parse(textBox2.Text);
                Q.Add(ele);
                label10.Text = Q.Mostrar();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            C = C.Mezcla(P, Q);
            label5.Text = C.Mostrar();
        }
    }
}
