using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_gestao
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxemail.Text.Equals("omega3@cristina.com") && textBoxsenha.Text.Equals("omega3")) 
            {
                //Ir para o sistema
                var principal = new principal();
                principal.Show();
                this.Visible = false;
            } 
            else 
            {
                MessageBox.Show("Email ou Senha incorreto", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxsenha.Text = "";
                textBoxemail.Focus();

            }
        }
    }
}
