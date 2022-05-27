namespace WindowsFormsApp1
{
    partial class FCadastro
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.dateTimeNasc = new System.Windows.Forms.DateTimePicker();
            this.dgCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textTelefone = new System.Windows.Forms.MaskedTextBox();
            this.textProcurar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAlterar1 = new System.Windows.Forms.PictureBox();
            this.pictureProcurar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureIncluir = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textCPF = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProcurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIncluir)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF/CNPJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(36, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(467, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(359, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(228, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Email";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(90, 47);
            this.textNome.MaxLength = 100;
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(263, 20);
            this.textNome.TabIndex = 4;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(277, 13);
            this.textEmail.MaxLength = 100;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(184, 20);
            this.textEmail.TabIndex = 2;
            // 
            // dateTimeNasc
            // 
            this.dateTimeNasc.CustomFormat = "DD/MM/YYYY";
            this.dateTimeNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNasc.Location = new System.Drawing.Point(599, 14);
            this.dateTimeNasc.Name = "dateTimeNasc";
            this.dateTimeNasc.Size = new System.Drawing.Size(103, 20);
            this.dateTimeNasc.TabIndex = 3;
            this.dateTimeNasc.Value = new System.DateTime(2022, 5, 22, 0, 0, 0, 0);
            // 
            // dgCliente
            // 
            this.dgCliente.AllowUserToAddRows = false;
            this.dgCliente.AllowUserToDeleteRows = false;
            this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCliente.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgCliente.Location = new System.Drawing.Point(12, 197);
            this.dgCliente.Name = "dgCliente";
            this.dgCliente.ReadOnly = true;
            this.dgCliente.Size = new System.Drawing.Size(701, 314);
            this.dgCliente.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(550, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Salvar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(62, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Atualizar Lista";
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(434, 47);
            this.textTelefone.Mask = "(00) 00000-0000";
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(98, 20);
            this.textTelefone.TabIndex = 5;

            // 
            // textProcurar
            // 
            this.textProcurar.Location = new System.Drawing.Point(388, 173);
            this.textProcurar.MaxLength = 100;
            this.textProcurar.Name = "textProcurar";
            this.textProcurar.Size = new System.Drawing.Size(263, 20);
            this.textProcurar.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(400, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 16);
            this.label8.TabIndex = 37;
            this.label8.Text = "Procurar Cliente CPF ou Nome.";
            // 
            // btnAlterar1
            // 
            this.btnAlterar1.Image = global::TesteBRdata.Properties.Resources.tango_edit_find_replace;
            this.btnAlterar1.Location = new System.Drawing.Point(229, 141);
            this.btnAlterar1.Name = "btnAlterar1";
            this.btnAlterar1.Size = new System.Drawing.Size(41, 38);
            this.btnAlterar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAlterar1.TabIndex = 38;
            this.btnAlterar1.TabStop = false;
            this.btnAlterar1.Click += new System.EventHandler(this.btnAlterar1_Click_1);
            // 
            // pictureProcurar
            // 
            this.pictureProcurar.Image = global::TesteBRdata.Properties.Resources.search_for_fingerprints;
            this.pictureProcurar.Location = new System.Drawing.Point(654, 169);
            this.pictureProcurar.Name = "pictureProcurar";
            this.pictureProcurar.Size = new System.Drawing.Size(27, 29);
            this.pictureProcurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureProcurar.TabIndex = 36;
            this.pictureProcurar.TabStop = false;
            this.pictureProcurar.Click += new System.EventHandler(this.pictureProcurar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TesteBRdata.Properties.Resources.refresh;
            this.pictureBox1.Location = new System.Drawing.Point(90, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureIncluir
            // 
            this.pictureIncluir.Image = global::TesteBRdata.Properties.Resources.Save;
            this.pictureIncluir.Location = new System.Drawing.Point(558, 72);
            this.pictureIncluir.Name = "pictureIncluir";
            this.pictureIncluir.Size = new System.Drawing.Size(35, 34);
            this.pictureIncluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureIncluir.TabIndex = 28;
            this.pictureIncluir.TabStop = false;
            this.pictureIncluir.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(207, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Alterar Cliente";
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(90, 13);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(132, 20);
            this.textCPF.TabIndex = 40;

            // 
            // FCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(725, 533);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAlterar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureProcurar);
            this.Controls.Add(this.textProcurar);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureIncluir);
            this.Controls.Add(this.dgCliente);
            this.Controls.Add(this.dateTimeNasc);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FCadastro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlterar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProcurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIncluir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.DateTimePicker dateTimeNasc;
        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.PictureBox pictureIncluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox textTelefone;
        private System.Windows.Forms.TextBox textProcurar;
        private System.Windows.Forms.PictureBox pictureProcurar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnAlterar1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox textCPF;
    }
}

