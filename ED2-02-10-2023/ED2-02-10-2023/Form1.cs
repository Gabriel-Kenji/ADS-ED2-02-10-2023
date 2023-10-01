using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ED2_02_10_2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        Guiches guiches = new Guiches();
        private Senhas listaSenhas = new Senhas();

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            guiches.adicionar(new Guiche(guiches.ListaGuiches.Count()+1));
            lblGui.Text = guiches.ListaGuiches.Count().ToString();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            listaSenhas.gerar();
            listaSenhas.ProximoAtendimento += 1;
        }

        private void btnListarSenhas_Click(object sender, EventArgs e)
        {
            LbSenhas.Items.Clear();
            foreach (var senha in listaSenhas.FilaSenhas)
            {
                LbSenhas.Items.Add(senha.dadosParciais());
            }
            
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            if (txtGuiche.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Escolha um guiche");
            }
            else
            {
                int gui = int.Parse(txtGuiche.Text);
                foreach (var guiche in guiches.ListaGuiches)
                {
                    if (guiche.Id == gui)
                    {
                        if (listaSenhas.FilaSenhas.Count != 0)
                        {
                            Senha senha = listaSenhas.FilaSenhas.Peek();
                            if (guiche.chamar(listaSenhas.FilaSenhas))
                            {
                                MessageBox.Show("GUICHE: " + senha.Id.ToString() + "\nSENHA: " + gui);
                            }
                        }else
                        {
                            MessageBox.Show("Não existem senhas na fila");
                        }
                    
                    }
                }
            }
            
        }

        private void btnListarAtendimentos_Click(object sender, EventArgs e)
        {
            if (txtGuiche.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Escolha um guiche");
            }
            else
            {
                int gui = int.Parse(txtGuiche.Text);
                foreach (var guiche in guiches.ListaGuiches)
                {
                    if (guiche.Id == gui)
                    {
                        LbAtendimentos.Items.Clear();
                        foreach (var senha in guiche.Atendimentos)
                        {
                            LbAtendimentos.Items.Add(senha.dadosCompletos());
                        }
                    }
                }
            }
        }
    }
}
