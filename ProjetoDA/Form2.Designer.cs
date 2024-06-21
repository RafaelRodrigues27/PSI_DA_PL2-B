namespace ProjetoDA
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxClientes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxNif = new System.Windows.Forms.TextBox();
            this.buttonAdicionarClientes = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAdicionarLinha = new System.Windows.Forms.Button();
            this.textBoxLinhaDescricao = new System.Windows.Forms.TextBox();
            this.textBoxLinhaValor = new System.Windows.Forms.TextBox();
            this.labelLinhaTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxCompras = new System.Windows.Forms.ListBox();
            this.listBoxLinhas = new System.Windows.Forms.ListBox();
            this.buttonApagarLinha = new System.Windows.Forms.Button();
            this.buttonApagarCompra = new System.Windows.Forms.Button();
            this.buttonCriarCompra = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Efetuar Reserva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(705, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reserva Efetuada";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxClientes);
            this.groupBox3.Location = new System.Drawing.Point(35, 143);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(324, 222);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Clientes";
            // 
            // listBoxClientes
            // 
            this.listBoxClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxClientes.FormattingEnabled = true;
            this.listBoxClientes.ItemHeight = 16;
            this.listBoxClientes.Location = new System.Drawing.Point(4, 19);
            this.listBoxClientes.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxClientes.Name = "listBoxClientes";
            this.listBoxClientes.Size = new System.Drawing.Size(316, 199);
            this.listBoxClientes.TabIndex = 8;
            this.listBoxClientes.SelectedIndexChanged += new System.EventHandler(this.listBoxClientes_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxNome);
            this.groupBox1.Controls.Add(this.textBoxNif);
            this.groupBox1.Controls.Add(this.buttonAdicionarClientes);
            this.groupBox1.Location = new System.Drawing.Point(11, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(359, 373);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "NIF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nome";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(116, 23);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(237, 22);
            this.textBoxNome.TabIndex = 1;
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
            this.buttonAdicionarClientes.Location = new System.Drawing.Point(255, 87);
            this.buttonAdicionarClientes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdicionarClientes.Name = "buttonAdicionarClientes";
            this.buttonAdicionarClientes.Size = new System.Drawing.Size(100, 28);
            this.buttonAdicionarClientes.TabIndex = 4;
            this.buttonAdicionarClientes.Text = "Adicionar";
            this.buttonAdicionarClientes.UseVisualStyleBackColor = true;
            this.buttonAdicionarClientes.Click += new System.EventHandler(this.buttonAdicionarClientes_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.labelLinhaTotal);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.listBoxCompras);
            this.groupBox4.Controls.Add(this.listBoxLinhas);
            this.groupBox4.Controls.Add(this.buttonApagarLinha);
            this.groupBox4.Controls.Add(this.buttonApagarCompra);
            this.groupBox4.Controls.Add(this.buttonCriarCompra);
            this.groupBox4.Location = new System.Drawing.Point(530, 116);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(664, 322);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Compras";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.buttonAdicionarLinha);
            this.groupBox5.Controls.Add(this.textBoxLinhaDescricao);
            this.groupBox5.Controls.Add(this.textBoxLinhaValor);
            this.groupBox5.Location = new System.Drawing.Point(440, 49);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(216, 229);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Adicionar linha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 119);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Valor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Descrição";
            // 
            // buttonAdicionarLinha
            // 
            this.buttonAdicionarLinha.Enabled = false;
            this.buttonAdicionarLinha.Location = new System.Drawing.Point(53, 171);
            this.buttonAdicionarLinha.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdicionarLinha.Name = "buttonAdicionarLinha";
            this.buttonAdicionarLinha.Size = new System.Drawing.Size(100, 28);
            this.buttonAdicionarLinha.TabIndex = 4;
            this.buttonAdicionarLinha.Text = "Adicionar";
            this.buttonAdicionarLinha.UseVisualStyleBackColor = true;
            // 
            // textBoxLinhaDescricao
            // 
            this.textBoxLinhaDescricao.Location = new System.Drawing.Point(31, 68);
            this.textBoxLinhaDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLinhaDescricao.Name = "textBoxLinhaDescricao";
            this.textBoxLinhaDescricao.Size = new System.Drawing.Size(153, 22);
            this.textBoxLinhaDescricao.TabIndex = 2;
            // 
            // textBoxLinhaValor
            // 
            this.textBoxLinhaValor.Location = new System.Drawing.Point(31, 139);
            this.textBoxLinhaValor.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLinhaValor.Name = "textBoxLinhaValor";
            this.textBoxLinhaValor.Size = new System.Drawing.Size(153, 22);
            this.textBoxLinhaValor.TabIndex = 3;
            // 
            // labelLinhaTotal
            // 
            this.labelLinhaTotal.AutoSize = true;
            this.labelLinhaTotal.Location = new System.Drawing.Point(224, 282);
            this.labelLinhaTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLinhaTotal.Name = "labelLinhaTotal";
            this.labelLinhaTotal.Size = new System.Drawing.Size(68, 16);
            this.labelLinhaTotal.TabIndex = 13;
            this.labelLinhaTotal.Text = "Total: 0,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(224, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Linhas de compras";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Compras";
            // 
            // listBoxCompras
            // 
            this.listBoxCompras.FormattingEnabled = true;
            this.listBoxCompras.ItemHeight = 16;
            this.listBoxCompras.Location = new System.Drawing.Point(8, 49);
            this.listBoxCompras.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCompras.Name = "listBoxCompras";
            this.listBoxCompras.Size = new System.Drawing.Size(207, 228);
            this.listBoxCompras.TabIndex = 9;
            // 
            // listBoxLinhas
            // 
            this.listBoxLinhas.FormattingEnabled = true;
            this.listBoxLinhas.ItemHeight = 16;
            this.listBoxLinhas.Location = new System.Drawing.Point(224, 49);
            this.listBoxLinhas.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxLinhas.Name = "listBoxLinhas";
            this.listBoxLinhas.Size = new System.Drawing.Size(207, 228);
            this.listBoxLinhas.TabIndex = 10;
            // 
            // buttonApagarLinha
            // 
            this.buttonApagarLinha.Enabled = false;
            this.buttonApagarLinha.Location = new System.Drawing.Point(332, 282);
            this.buttonApagarLinha.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApagarLinha.Name = "buttonApagarLinha";
            this.buttonApagarLinha.Size = new System.Drawing.Size(100, 28);
            this.buttonApagarLinha.TabIndex = 7;
            this.buttonApagarLinha.Text = "Apagar";
            this.buttonApagarLinha.UseVisualStyleBackColor = true;
            // 
            // buttonApagarCompra
            // 
            this.buttonApagarCompra.Enabled = false;
            this.buttonApagarCompra.Location = new System.Drawing.Point(116, 282);
            this.buttonApagarCompra.Margin = new System.Windows.Forms.Padding(4);
            this.buttonApagarCompra.Name = "buttonApagarCompra";
            this.buttonApagarCompra.Size = new System.Drawing.Size(100, 28);
            this.buttonApagarCompra.TabIndex = 6;
            this.buttonApagarCompra.Text = "Apagar";
            this.buttonApagarCompra.UseVisualStyleBackColor = true;
            // 
            // buttonCriarCompra
            // 
            this.buttonCriarCompra.Enabled = false;
            this.buttonCriarCompra.Location = new System.Drawing.Point(8, 282);
            this.buttonCriarCompra.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCriarCompra.Name = "buttonCriarCompra";
            this.buttonCriarCompra.Size = new System.Drawing.Size(100, 28);
            this.buttonCriarCompra.TabIndex = 5;
            this.buttonCriarCompra.Text = "Criar";
            this.buttonCriarCompra.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1076, 470);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1207, 522);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBoxClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxNif;
        private System.Windows.Forms.Button buttonAdicionarClientes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAdicionarLinha;
        private System.Windows.Forms.TextBox textBoxLinhaDescricao;
        private System.Windows.Forms.TextBox textBoxLinhaValor;
        private System.Windows.Forms.Label labelLinhaTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxCompras;
        private System.Windows.Forms.ListBox listBoxLinhas;
        private System.Windows.Forms.Button buttonApagarLinha;
        private System.Windows.Forms.Button buttonApagarCompra;
        private System.Windows.Forms.Button buttonCriarCompra;
        private System.Windows.Forms.Button button1;
    }
}