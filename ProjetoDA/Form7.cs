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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ProjetoDA.dbcontext;

namespace ProjetoDA
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();

            dataGridView1.DataSource = menu.Menu;

           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string datahoraText = textBox1.Text; 
            string qtddisponivelText = textBox2.Text;
            string precoestudantText = textBox3.Text;
            string precoprofessorText = textBox4.Text;

            DateTime datahora;
            int qtddisponivel;
            double precoestudante;
            double precoprofessor;


            if (DateTime.TryParse(datahoraText, out datahora) &&
                (int.TryParse(qtddisponivelText, out qtddisponivel) &&
                (double.TryParse(precoestudantText, out precoestudante) &&
                (double.TryParse(precoprofessorText, out precoprofessor)))))
            {
               menu newMenu = new menu(datahora, qtddisponivel, precoestudante, precoprofessor); 
                MessageBox.Show($"Estudante '{datahora}' numero de identificação '{qtddisponivel}' com nif '{precoestudante}' com saldo '{precoprofessor}' ."); 
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                if (int.TryParse(textBox4.Text, out int rowIndex))
                {
                    if (rowIndex >= 0 && rowIndex < dataGridView1.Rows.Count)
                    {
                        var menuARemover = dataGridView1.Rows[rowIndex].DataBoundItem as menu;

                        if (menuARemover != null)
                        {
                            menu.Menu.Remove(menuARemover);
                            MessageBox.Show($"Menu '{menuARemover.DataHora}' removido.");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
