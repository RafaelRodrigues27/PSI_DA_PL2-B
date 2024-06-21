using ProjetoDA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoDA.dbcontext;

namespace ProjetoDA
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();

            dataGridView1.DataSource = funcionario.Funcionario;

           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string nome = textBox2.Text;
            string nif = textBox3.Text;
            string username = textBox4.Text;

            if (!string.IsNullOrWhiteSpace(id) && !string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(nif) && !string.IsNullOrWhiteSpace(username))
            {
                funcionario newFuncionario = new funcionario(id, nome, nif, username);
                MessageBox.Show($"O funcionario/a com o id:'{id}', nome: '{nome}', nif '{nif}' e username:{username}.");
            }
            else
            {
                MessageBox.Show("Please enter a valid text."); 
            }

            textBox1.Clear(); 
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
