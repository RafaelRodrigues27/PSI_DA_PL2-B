using ProjetoDA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProjetoDA.dbcontext;

namespace ProjetoDA
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            dataGridView1.DataSource = prato.Prato;

           
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string descricao = textBox1.Text; // Get the text from the TextBox
            string tipo = textBox2.Text;
            string ativo = textBox3.Text;

            if (!string.IsNullOrWhiteSpace(descricao) && !string.IsNullOrWhiteSpace(tipo) && !string.IsNullOrWhiteSpace(ativo)) 
            {
                prato newPrato = new prato(descricao, tipo, ativo); // Create a new Prato object, automatically adding it to the list
                MessageBox.Show($"Prato '{descricao}' com o tipo '{tipo}' e com o estado '{ativo}' added to the list."); // Optional: Show a confirmation message
            }
            else
            {
                MessageBox.Show("Por favor, introduza informaçoes validas."); 
            }

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(textBox4.Text, out int rowIndex))
                {
                    if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
                    {
                        var pratoARemover = dataGridView1.Rows[rowIndex].DataBoundItem as prato;

                        if (pratoARemover != null)
                        {
                            prato.Prato.Remove(pratoARemover);
                            MessageBox.Show($"Prato '{pratoARemover.Descricao}' removido.");
                             // Atualiza o DataGridView com os novos dados
                        }
                    }
                    else
                    {
                        MessageBox.Show("Número da linha inválido.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira um número válido.");
                }

                textBox4.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
