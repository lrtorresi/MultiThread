using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mdc.m7.setup.Entities;
using mdc.m7.setup.Services;
using mdc.m7.setup.Forms;
using System.Threading;
using System.Diagnostics;

namespace mdc.m7.setup.Forms
{
    public partial class FrmConfigIIS : Form
    {
        GerarBatISSInstalacao gerarBatIISInstalacao = new GerarBatISSInstalacao();

        public FrmConfigIIS()
        {
            InitializeComponent();
        }

        private void btnInstalacao_Click(object sender, EventArgs e)
        {
            
            //Gera a Bat de instalação do ISS
            gerarBatIISInstalacao.GerarArquivoBatIIS(gerarBatIISInstalacao);

            Thread threadIIS = new Thread(new ThreadStart(issInstalacao));
            btnInstalacao.Visible = false;
            btnAtualizacao.Visible = false;
            label4.Visible = false;
            label9.Visible = false;
            msgInstalacao.Visible = true;
            msgInstalacao2.Visible = true;
            pictureBox3.Visible = true;
            threadIIS.Start();
        }

        void issInstalacao()
        {
            //Atualizando as bases de dados (SERVIDOR)
            //Executar app externo para atualização
            var inf = new ProcessStartInfo("C:\\programdata\\IISInstalacao.bat");
            var proc = new Process();
            inf.CreateNoWindow = true;
            inf.UseShellExecute = false;
            proc.StartInfo = inf;
            proc.Start();
            proc.WaitForExit();


            this.Invoke(new MethodInvoker(delegate ()
            {
                MessageBox.Show($"Instalação concluida com Sucesso! ", "MDC Brasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            ));
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair sem Instalar/Atualizar o IIS? ", "MDC Brasil", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }
    }
}
