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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            dataGridView1.DataSource = estudante.Estudante;

            dataGridView2.DataSource = professor.Professor;

           

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text; // Get the text from the TextBox
            string nome = textBox2.Text;
            string nif = textBox3.Text;
            string saldoText = textBox4.Text;
            string nestudante = textBox5.Text;

            int saldo;


            if (int.TryParse(saldoText, out saldo) &&
                !string.IsNullOrWhiteSpace(id) &&
                !string.IsNullOrWhiteSpace(nome) &&
                !string.IsNullOrWhiteSpace(nif) &&
                !string.IsNullOrWhiteSpace(nestudante)) // Check if the text is not empty
            {
                estudante newEstudante = new estudante(id, nome, nif, saldo, nestudante); // Create a new Prato object, automatically adding it to the list
                MessageBox.Show($"Estudante '{nome}' numero de identificação '{id}' com nif '{nif}' com saldo '{saldo}' e com numero de estudante '{nestudante}' added to the list."); // Optional: Show a confirmation message
            }
            else
            {
                MessageBox.Show("Please enter a valid text."); // Optional: Show a warning message
            }

            textBox1.Clear(); // Clear the TextBox after adding the item
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = textBox6.Text; // Get the text from the TextBox
            string nome = textBox7.Text;
            string nif = textBox8.Text;
            string saldoText = textBox9.Text;
            string email = textBox10.Text;

            int saldo;


            if (int.TryParse(saldoText, out saldo) &&
                !string.IsNullOrWhiteSpace(id) &&
                !string.IsNullOrWhiteSpace(nome) &&
                !string.IsNullOrWhiteSpace(nif) &&
                !string.IsNullOrWhiteSpace(email)) // Check if the text is not empty
            {
                professor newProfessor = new professor(id, nome, nif, saldo, email); // Create a new Prato object, automatically adding it to the list
                MessageBox.Show($"Professor '{nome}' numero de identificação '{id}', com nif '{nif}', com saldo '{saldo}' e com o email '{email}' added to the list."); // Optional: Show a confirmation message
            }
            else
            {
                MessageBox.Show("Please enter a valid text."); // Optional: Show a warning message
            }

            textBox6.Clear(); // Clear the TextBox after adding the item
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(textBox11.Text, out int rowIndex))
                {
                    if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
                    {
                        var estudanteARemover = dataGridView1.Rows[rowIndex].DataBoundItem as estudante;

                        if (estudanteARemover != null)
                        {
                            estudante.Estudante.Remove(estudanteARemover);
                            MessageBox.Show($"Estudante '{estudanteARemover.Nome}' removido.");
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

                textBox11.Clear();
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(textBox12.Text, out int rowIndex))
                {
                    if (rowIndex >= 0 && rowIndex < dataGridView2.Rows.Count)
                    {
                        var professorARemover = dataGridView2.Rows[rowIndex].DataBoundItem as professor;

                        if (professorARemover != null)
                        {
                            professor.Professor.Remove(professorARemover);
                            MessageBox.Show($"Professor '{professorARemover.Nome}' removido.");
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

                textBox12.Clear();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
