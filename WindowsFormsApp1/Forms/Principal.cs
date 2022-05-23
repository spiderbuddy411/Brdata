using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FCadastro : Form
    {
        public FCadastro()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            using (var db = new Contexto())
            {
                db.ObjetoCliente.Add(new Cliente { Nome = textNome.Text, CPF = textCPF.Text, Email = textEmail.Text, Telefone = textTelefone.Text, DataNasc = dateTimeNasc.Value });
                db.SaveChanges();
                
            }
            textNome.Text = String.Empty;
            textCPF.Text = String.Empty;
            textEmail.Text = String.Empty;
            textTelefone.Text = String.Empty;
            MessageBox.Show("Cliente Cadastro com sucesso", "Inclusão");
        }
        public void RefreshLista()
        {
            using (var db = new Contexto())
            {
                dgCliente.DataSource = "ID";
                dgCliente.DataSource = db.ObjetoCliente.ToList();



            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshLista();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            RefreshLista();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (var db = new Contexto())
                
                if (string.IsNullOrEmpty(textNome.Text) || string.IsNullOrEmpty(textCPF.Text) || string.IsNullOrEmpty(textEmail.Text) || string.IsNullOrEmpty(textTelefone.Text))
                {
                    MessageBox.Show("Campos não deve esta vazio", "!!! ALERTA !!!");
                    RefreshLista();
                    return;
                }
                else
                {
                    {
                     
                        db.ObjetoCliente.Add(new Cliente { Nome = textNome.Text, CPF = textCPF.Text, Email = textEmail.Text, Telefone = textTelefone.Text, DataNasc = dateTimeNasc.Value });
                        db.SaveChanges();
                        

                    }
                    textNome.Text = String.Empty;
                    textCPF.Text = String.Empty;
                    textEmail.Text = String.Empty;
                    textTelefone.Text = String.Empty;
                    MessageBox.Show("Cliente Cadastro com sucesso", "Inclusão");
                }

                
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            RefreshLista();
        }


        private void pictureProcurar_Click(object sender, EventArgs e)
        {
            using (var db = new Contexto())
            {

                try
                {                    
                    if (string.IsNullOrEmpty(textProcurar.Text))
                    {
                        MessageBox.Show("Você deve digitar Nome ou CPF do Cliente para a Procura","!!! Alerta !!!");
                    }
                    else
                    {
                        String Procurar = textProcurar.Text.Trim();
                        dgCliente.DataSource = db.ObjetoCliente.Where(Name => Name.CPF.Contains(Procurar)).ToList();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            textProcurar.Text = String.Empty;
        }

        private void textCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }

        private void textTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnAlterar1_Click_1(object sender, EventArgs e)
        {
            Alterar formAlterarCliente = new Alterar();
            formAlterarCliente.ShowDialog();
        }

        private void textCPF_TextChanged(object sender, EventArgs e)
        {
            MaskedTextBox textCPF = new MaskedTextBox();

            if (textCPF.Text.Length == 11)

                textCPF.Mask = "000.000.000-00";

            else

                textCPF.Mask = "00.000.000/0000-00";
        }

    }
}
