using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using APIRISKMANAGER.Entity;
using Newtonsoft.Json;
namespace APIRISKMANAGER
{
    public partial class Form1 : Form
    {
        private Token tokenGerado{ get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Carregamento barra status
                progressBar1.Value = 50;
                progressBar1.Update();
                ConfToken token = new ConfToken(url.Text, clienteid.Text, secretykey.Text);
                this.tokenGerado = token.GerarTokenPOST(token);
                // Carregamento barra status
                progressBar1.Value = 100;
                progressBar1.Update();

                MessageBox.Show("Token Gerado Com Sucesso!");

                progressBar1.Value = 0;
                progressBar1.Update();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ConfToken ct = new ConfToken();
                ct.GerarPerimetrosGET(tokenGerado);
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

      
    }
}
