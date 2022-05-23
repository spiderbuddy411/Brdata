namespace WindowsFormsApp1
{
    partial class Alterar
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
            this.textAID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textATelefone = new System.Windows.Forms.MaskedTextBox();
            this.textACPF = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeANasc = new System.Windows.Forms.DateTimePicker();
            this.textAEmail = new System.Windows.Forms.TextBox();
            this.textANome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureExcluir = new System.Windows.Forms.PictureBox();
            this.pictureIncluir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExcluir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIncluir)).BeginInit();
            this.SuspendLayout();
            // 
            // textAID
            // 
            this.textAID.Location = new System.Drawing.Point(138, 31);
            this.textAID.Name = "textAID";
            this.textAID.Size = new System.Drawing.Size(62, 20);
            this.textAID.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "DIGITE O ID DO USUARIO QUE QUER ALTERAR OU EXCLUIR";
            // 
            // textATelefone
            // 
            this.textATelefone.Location = new System.Drawing.Point(407, 107);
            this.textATelefone.Mask = "(00) 00000-0000";
            this.textATelefone.Name = "textATelefone";
            this.textATelefone.Size = new System.Drawing.Size(98, 20);
            this.textATelefone.TabIndex = 45;
            // 
            // textACPF
            // 
            this.textACPF.Location = new System.Drawing.Point(67, 73);
            this.textACPF.Mask = "999.999.999-99";
            this.textACPF.Name = "textACPF";
            this.textACPF.Size = new System.Drawing.Size(102, 20);
            this.textACPF.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(399, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Incluir";
            // 
            // dateTimeANasc
            // 
            this.dateTimeANasc.CustomFormat = "DD/MM/YYYY";
            this.dateTimeANasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeANasc.Location = new System.Drawing.Point(138, 140);
            this.dateTimeANasc.Name = "dateTimeANasc";
            this.dateTimeANasc.Size = new System.Drawing.Size(103, 20);
            this.dateTimeANasc.TabIndex = 41;
            this.dateTimeANasc.Value = new System.DateTime(2022, 5, 22, 0, 0, 0, 0);
            // 
            // textAEmail
            // 
            this.textAEmail.Location = new System.Drawing.Point(228, 72);
            this.textAEmail.MaxLength = 100;
            this.textAEmail.Name = "textAEmail";
            this.textAEmail.Size = new System.Drawing.Size(184, 20);
            this.textAEmail.TabIndex = 40;
            // 
            // textANome
            // 
            this.textANome.Location = new System.Drawing.Point(67, 107);
            this.textANome.MaxLength = 100;
            this.textANome.Name = "textANome";
            this.textANome.Size = new System.Drawing.Size(263, 20);
            this.textANome.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(179, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(332, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(9, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Data Nascimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(14, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(25, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "CPF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(113, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(473, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "Excluir";
            // 
            // pictureExcluir
            // 
            this.pictureExcluir.Image = global::TesteBRdata.Properties.Resources.primary_delete_user;
            this.pictureExcluir.Location = new System.Drawing.Point(480, 153);
            this.pictureExcluir.Name = "pictureExcluir";
            this.pictureExcluir.Size = new System.Drawing.Size(39, 34);
            this.pictureExcluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureExcluir.TabIndex = 47;
            this.pictureExcluir.TabStop = false;
            this.pictureExcluir.Click += new System.EventHandler(this.pictureExcluir_Click);
            // 
            // pictureIncluir
            // 
            this.pictureIncluir.Image = global::TesteBRdata.Properties.Resources.Save;
            this.pictureIncluir.Location = new System.Drawing.Point(408, 153);
            this.pictureIncluir.Name = "pictureIncluir";
            this.pictureIncluir.Size = new System.Drawing.Size(35, 34);
            this.pictureIncluir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIncluir.TabIndex = 42;
            this.pictureIncluir.TabStop = false;
            this.pictureIncluir.Click += new System.EventHandler(this.pictureIncluir_Click);
            // 
            // Alterar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(529, 209);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureExcluir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textATelefone);
            this.Controls.Add(this.textACPF);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureIncluir);
            this.Controls.Add(this.dateTimeANasc);
            this.Controls.Add(this.textAEmail);
            this.Controls.Add(this.textANome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textAID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Alterar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureExcluir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIncluir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textAID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textATelefone;
        private System.Windows.Forms.MaskedTextBox textACPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureIncluir;
        private System.Windows.Forms.DateTimePicker dateTimeANasc;
        private System.Windows.Forms.TextBox textAEmail;
        private System.Windows.Forms.TextBox textANome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureExcluir;
        private System.Windows.Forms.Label label9;
    }
}