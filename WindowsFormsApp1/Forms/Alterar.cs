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
    public partial class Alterar : Form
    {
        public Alterar()
        {
            InitializeComponent();
        }


        private void pictureIncluir_Click(object sender, EventArgs e)
        {
            using (var db = new Contexto())
                try
                {
                    {
                        var objeto = db.ObjetoCliente.Find(Convert.ToInt32(textAID.Text));
                        objeto.Nome = textANome.Text;
                        objeto.Email = textAEmail.Text;
                        objeto.Telefone = textATelefone.Text;
                        objeto.CPF = textACPF.Text;
                        objeto.DataNasc = dateTimeANasc.Value;

                        db.Entry(objeto).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();

                        MessageBox.Show("Alterado com Sucesso", "Alteração no Cliente");

                    }
                }
                catch
                {
                    MessageBox.Show("Cliente Ja cadastrado","Cliente ja Existente no banco de Dados");
                }
            
            Close();
        }

        private void pictureExcluir_Click(object sender, EventArgs e)
        {
            using (var db = new Contexto())

            {
                if (string.IsNullOrEmpty(textAID.Text))
                {
                    MessageBox.Show("Campo ID Esta vazio", "!!! ALERTA !!!");
                    return;
                }
                
                else
                {                     
                    try
                    {
                        var objeto = db.ObjetoCliente.Find(Convert.ToInt32(textAID.Text));
                        db.ObjetoCliente.Remove(objeto);
                        db.SaveChanges();

                        MessageBox.Show("Excluido com Sucesso", "Excluido Cliente");
                        Close();
                    }
                    catch (Exception ex) //usa uma das opções
                                         //catch //usa uma das opções
                    {
                        MessageBox.Show(ex.Message);
                        //MessageBox.Show("Não existe Cliente cadastro do ID","ERROR"); //usa uma das opções
                        Close();
                    }
                }
            }
            
        }
    }
}
