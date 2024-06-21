namespace ProjetoDA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxfuncionarios = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxNif = new System.Windows.Forms.TextBox();
            this.buttonAdicionarClientes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelUsernamefuncionario = new System.Windows.Forms.Label();
            this.labelIdfuncionario = new System.Windows.Forms.Label();
            this.labelfuncionarioNif = new System.Windows.Forms.Label();
            this.labelfuncionarioNome = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu de Opções";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pratos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(247, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(34, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Reservas";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(247, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(168, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "Multas";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(647, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.CloseUp += new System.EventHandler(this.dateTimePicker1_CloseUp);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxfuncionarios);
            this.groupBox3.Location = new System.Drawing.Point(615, 314);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(344, 188);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Funcionarios";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // listBoxfuncionarios
            // 
            this.listBoxfuncionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxfuncionarios.FormattingEnabled = true;
            this.listBoxfuncionarios.ItemHeight = 16;
            this.listBoxfuncionarios.Location = new System.Drawing.Point(4, 19);
            this.listBoxfuncionarios.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxfuncionarios.Name = "listBoxfuncionarios";
            this.listBoxfuncionarios.Size = new System.Drawing.Size(336, 165);
            this.listBoxfuncionarios.TabIndex = 8;
            this.listBoxfuncionarios.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxNome);
            this.groupBox1.Controls.Add(this.textBoxNif);
            this.groupBox1.Controls.Add(this.buttonAdicionarClientes);
            this.groupBox1.Location = new System.Drawing.Point(233, 318);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(363, 188);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Username";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(116, 115);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(237, 22);
            this.textBoxUsername.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Id";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(116, 85);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(237, 22);
            this.textBoxId.TabIndex = 7;
            this.textBoxId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "NIF";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(116, 23);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(237, 22);
            this.textBoxNome.TabIndex = 1;
            this.textBoxNome.TextChanged += new System.EventHandler(this.textBoxNome_TextChanged);
            // 
            // textBoxNif
            // 
            this.textBoxNif.Location = new System.Drawing.Point(116, 55);
            this.textBoxNif.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNif.Name = "textBoxNif";
            this.textBoxNif.Size = new System.Drawing.Size(237, 22);
            this.textBoxNif.TabIndex = 0;
            // 
            // buttonAdicionarClientes
            // 
            this.buttonAdicionarClientes.Location = new System.Drawing.Point(255, 145);
            this.buttonAdicionarClientes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdicionarClientes.Name = "buttonAdicionarClientes";
            this.buttonAdicionarClientes.Size = new System.Drawing.Size(100, 28);
            this.buttonAdicionarClientes.TabIndex = 4;
            this.buttonAdicionarClientes.Text = "Adicionar";
            this.buttonAdicionarClientes.UseVisualStyleBackColor = true;
            this.buttonAdicionarClientes.Click += new System.EventHandler(this.buttonAdicionarClientes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.labelUsernamefuncionario);
            this.groupBox2.Controls.Add(this.labelIdfuncionario);
            this.groupBox2.Controls.Add(this.labelfuncionarioNif);
            this.groupBox2.Controls.Add(this.labelfuncionarioNome);
            this.groupBox2.Location = new System.Drawing.Point(981, 318);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(200, 184);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Funcionario atual";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labelUsernamefuncionario
            // 
            this.labelUsernamefuncionario.AutoSize = true;
            this.labelUsernamefuncionario.Location = new System.Drawing.Point(27, 123);
            this.labelUsernamefuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsernamefuncionario.Name = "labelUsernamefuncionario";
            this.labelUsernamefuncionario.Size = new System.Drawing.Size(143, 16);
            this.labelUsernamefuncionario.TabIndex = 4;
            this.labelUsernamefuncionario.Text = "Username Funcionario";
            this.labelUsernamefuncionario.Click += new System.EventHandler(this.Usernamefuncionario_Click);
            // 
            // labelIdfuncionario
            // 
            this.labelIdfuncionario.AutoSize = true;
            this.labelIdfuncionario.Location = new System.Drawing.Point(27, 95);
            this.labelIdfuncionario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIdfuncionario.Name = "labelIdfuncionario";
            this.labelIdfuncionario.Size = new System.Drawing.Size(110, 16);
            this.labelIdfuncionario.TabIndex = 3;
            this.labelIdfuncionario.Text = "Id do Funcionario";
            this.labelIdfuncionario.Click += new System.EventHandler(this.Idfuncionario_Click);
            // 
            // labelfuncionarioNif
            // 
            this.labelfuncionarioNif.AutoSize = true;
            this.labelfuncionarioNif.Location = new System.Drawing.Point(27, 66);
            this.labelfuncionarioNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfuncionarioNif.Name = "labelfuncionarioNif";
            this.labelfuncionarioNif.Size = new System.Drawing.Size(120, 16);
            this.labelfuncionarioNif.TabIndex = 2;
            this.labelfuncionarioNif.Text = "NIF do Funcionario";
            this.labelfuncionarioNif.Click += new System.EventHandler(this.labelClienteNif_Click);
            // 
            // labelfuncionarioNome
            // 
            this.labelfuncionarioNome.AutoSize = true;
            this.labelfuncionarioNome.Location = new System.Drawing.Point(27, 40);
            this.labelfuncionarioNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelfuncionarioNome.Name = "labelfuncionarioNome";
            this.labelfuncionarioNome.Size = new System.Drawing.Size(136, 16);
            this.labelfuncionarioNome.TabIndex = 0;
            this.labelfuncionarioNome.Text = "Nome do Funcionario";
            this.labelfuncionarioNome.Click += new System.EventHandler(this.labelClienteNome_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(34, 198);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(168, 40);
            this.button6.TabIndex = 18;
            this.button6.Text = "Extras";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(247, 143);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(168, 40);
            this.button7.TabIndex = 19;
            this.button7.Text = "Clientes";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(24, 374);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(190, 69);
            this.button8.TabIndex = 20;
            this.button8.Text = "Funcionarios:";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Datas e Refeições";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1217, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxfuncionarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxNif;
        private System.Windows.Forms.Button buttonAdicionarClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelfuncionarioNif;
        private System.Windows.Forms.Label labelfuncionarioNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsernamefuncionario;
        private System.Windows.Forms.Label labelIdfuncionario;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
    }
}

