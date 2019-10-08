using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;
using mdc.m7.setup.Forms;

namespace mdc.m7.setup
{
    public partial class Servidor : Form
    {
        //## Variaveis Publicas
        public bool Syswow = Directory.Exists("C:\\Program Files (x86)\\Common Files\\MDCi");
        ImportacaoNCM importacaoNCM = new ImportacaoNCM();

        public Servidor()
        {
            InitializeComponent();
        }

        private void Servidor_Load(object sender, EventArgs e) { }


        //## INSTALAÇÃO SERVIDOR
        private void Srv_Click(object sender, EventArgs e)
        {
            try
            {
                Thread threadInstalacao = new Thread(new ThreadStart(instalacao));
                srv.Visible = false;
                estacao.Visible = false;
                label4.Visible = false;
                button1.Visible = false;
                msgInstalacao.Visible = true;
                msgInstalacao2.Visible = true;
                pictureBox3.Visible = true;
                threadInstalacao.Start();
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}. \n\n Informe essa mensagem para a MDC", "MDC Brasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        void instalacao()
        {
            //Criando e atualizando as bases de dados (SERVIDOR)
            //Executar app externo para instalação
            var inf = new ProcessStartInfo("C:\\programdata\\Server_Instalacao.bat");
            var proc = new Process();
            inf.CreateNoWindow = true;
            inf.UseShellExecute = false;
            proc.StartInfo = inf;
            proc.Start();
            proc.WaitForExit();

            // Criando e atualizando as bases de dados(SERVIDOR)
            //Executar app externo para instalação
            var inf2 = new ProcessStartInfo("C:\\programdata\\RegistraArquivos.bat");
            var proc2 = new Process();
            inf2.CreateNoWindow = true;
            inf2.UseShellExecute = false;
            proc2.StartInfo = inf2;
            proc2.Start();
            proc2.WaitForExit();

            this.Invoke(new MethodInvoker(delegate ()
            {
                importacaoNCM.Show();
                this.Close();
            }
            ));
        }

        //## ATUALIZAÇÃO SERVIDOR
        private void Estacao_Click(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(new ThreadStart(loading));
            srv.Visible = false;
            estacao.Visible = false;
            label4.Visible = false;
            button1.Visible = false;
            msgInstalacao.Visible = true;
            msgInstalacao2.Visible = true;            
            pictureBox3.Visible = true;
            thread1.Start();           
        }
        
        void loading()
        {
            //Atualizando as bases de dados (SERVIDOR)
            //Executar app externo para atualização
            var inf = new ProcessStartInfo("C:\\programdata\\Server_Atualizacao.bat");
            var proc = new Process();
            inf.CreateNoWindow = true;
            inf.UseShellExecute = false;
            proc.StartInfo = inf;
            proc.Start();
            proc.WaitForExit();

            //Criando e atualizando as bases de dados (SERVIDOR)
            //Executar app externo para instalação                
            var inf2 = new ProcessStartInfo("C:\\programdata\\RegistraArquivos.bat");
            var proc2 = new Process();
            inf2.CreateNoWindow = true;
            inf2.UseShellExecute = false;
            proc2.StartInfo = inf2;
            proc2.Start();
            proc2.WaitForExit();

            this.Invoke(new MethodInvoker(delegate ()
            {
                importacaoNCM.Show();
                this.Close();
            }
            ));
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            var voltarBaseSetup = new BaseSetup();
            voltarBaseSetup.Show();
            this.Close();
        }

        private void Label9_Click(object sender, EventArgs e) { }

        private void msgInstalacao_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }
    }
}
