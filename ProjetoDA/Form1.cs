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

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBoxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxfuncionarios.SelectedItem == null)
            {
                return;
            }
            funcionario Funcionario = (funcionario)listBoxfuncionarios.SelectedItem;

            labelfuncionarioNome.Text = Funcionario.Nome;
            labelfuncionarioNif.Text = Funcionario.NIF;
            labelIdfuncionario.Text = Funcionario.Id;
            labelUsernamefuncionario.Text = Funcionario.Username;
            listBoxfuncionarios.DataSource = null;
        }

        private void buttonAdicionarClientes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNome.Text) || string.IsNullOrEmpty(textBoxNif.Text) || string.IsNullOrEmpty(textBoxId.Text) || string.IsNullOrEmpty(textBoxUsername.Text))
            {
                return;
            }

            funcionario Funcionario = new funcionario(textBoxNome.Text, textBoxNif.Text, textBoxId.Text, textBoxUsername.Text);
            listBoxfuncionarios.Items.Add(Funcionario);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void labelClienteNome_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelClienteNif_Click(object sender, EventArgs e)
        {

        }

        private void Usernamefuncionario_Click(object sender, EventArgs e)
        {

        }

        private void Idfuncionario_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            new Form4().Show();
            this.Hide();
        }

        private void textBoxNome_TextChanged(object sender, EventArgs e)
        {

        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            new Form5().Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Form6().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form7().Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new Form8().Show();
            this.Hide();
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }
    }
}
