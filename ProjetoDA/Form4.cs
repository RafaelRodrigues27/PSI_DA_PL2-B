using ProjetoDA.dbcontext;
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

namespace ProjetoDA
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();

            dataGridView1.DataSource = extras.Extras;

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string descricao = textBox1.Text; // Get the text from the TextBox
            string precotext = textBox2.Text;
            string ativotext = textBox3.Text;

            decimal preco;
            bool ativo;

            if (!string.IsNullOrWhiteSpace(descricao) && (decimal.TryParse(precotext, out preco) && (bool.TryParse(ativotext, out ativo)))) // Check if the text is not empty
            {
                extras newExtras = new extras(descricao, preco, ativo); // Create a new Prato object, automatically adding it to the list
                MessageBox.Show($"Extra '{descricao}' com o preço '{preco}' e com o estado '{ativo}' added to the list."); // Optional: Show a confirmation message
            }
            else
            {
                MessageBox.Show("Please enter a valid text."); // Optional: Show a warning message
            }

            textBox1.Clear(); // Clear the TextBox after adding the item
            textBox2.Clear();
            textBox3.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(textBox4.Text, out int rowIndex))
                {
                    if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
                    {
                        var extrasARemover = dataGridView1.Rows[rowIndex].DataBoundItem as extras;

                        if (extrasARemover != null)
                        {
                            extras.Extras.Remove(extrasARemover);
                            MessageBox.Show($"Extra '{extrasARemover.Descricao}' removido.");
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
