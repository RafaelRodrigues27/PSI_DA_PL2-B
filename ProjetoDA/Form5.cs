using ProjetoDA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProjetoDA.dbcontext;

namespace ProjetoDA
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            dataGridView1.DataSource = multa.Multa;

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string valorText = textBox1.Text; // Get the text from the TextBox
            string numhorasText = textBox2.Text;

            int valor;
            double numhoras;


            if (int.TryParse(valorText, out valor) &&
                (double.TryParse(numhorasText, out numhoras))) // Check if the text is not empty
            {
                multa newMulta = new multa(valor, numhoras ); // Create a new Prato object, automatically adding it to the list
                MessageBox.Show($"Estudante '{valor}' numero de identificação '{numhoras}' ."); // Optional: Show a confirmation message
            }
            else
            {
                MessageBox.Show("Please enter a valid text."); // Optional: Show a warning message
            }

            textBox1.Clear(); // Clear the TextBox after adding the item
            textBox2.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(textBox4.Text, out int rowIndex))
                {
                    if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
                    {
                        var multaARemover = dataGridView1.Rows[rowIndex].DataBoundItem as multa;

                        if (multaARemover != null)
                        {
                            multa.Multa.Remove(multaARemover);
                            MessageBox.Show($"Multa '{multaARemover.Valor}' removido.");
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

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
