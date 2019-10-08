using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using mdc.m7.setup.Forms;

namespace mdc.m7.setup
{
    public partial class Estacao : Form
    {
        //## VARIAVEIS PUBLICAS
        Modulos_Instalados modulos_Instalados = new Modulos_Instalados();

        public Estacao()
        {
            InitializeComponent();            
        }

        //## ESTAÇÃO INSTALAÇÃO
        private void Srv_Click(object sender, EventArgs e)
        {
            try
            {
                Thread threadInstalacao = new Thread(new ThreadStart(instalacao));
                //Executar app externo para atualização 
                srv.Visible = false;
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
            //Executar app externo para Atualização (Registrando Arquivos)
            var inf = new ProcessStartInfo("C:\\programdata\\RegistraArquivos.bat");
            var proc = new Process();
            inf.CreateNoWindow = true;
            inf.UseShellExecute = false;
            proc.StartInfo = inf;
            proc.Start();
            proc.WaitForExit();

            this.Invoke(new MethodInvoker(delegate ()
            {
                modulos_Instalados.Show();
                this.Close();
            }
            ));
        }

        //## ATUALIZAÇÃO DE ESTAÇÃO
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Executar app externo para atualização 
                Thread threadAtualizacao = new Thread(new ThreadStart(atualizacao));
                srv.Visible = false;
                label4.Visible = false;
                button1.Visible = false;
                msgInstalacao.Visible = true;
                msgInstalacao2.Visible = true;
                pictureBox3.Visible = true;
                threadAtualizacao.Start();
            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}. \n\n Informe essa mensagem para a MDC", "MDC Brasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        void atualizacao()
        {
            //Executar app externo para Atualização (Registrando Arquivos)
            var inf = new ProcessStartInfo("C:\\programdata\\RegistraArquivos.bat");
            var proc = new Process();
            inf.CreateNoWindow = true;
            inf.UseShellExecute = false;
            proc.StartInfo = inf;
            proc.Start();
            proc.WaitForExit();

            this.Invoke(new MethodInvoker(delegate ()
            {
                MessageBox.Show("\n Sistema MDC atualizado com sucesso!", "MDC Brasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            ));
        }

        private void Estacao_Load(object sender, EventArgs e) { }
       

        private void button2_Click(object sender, EventArgs e)
        {
            var voltarBaseSetup = new BaseSetup();
            voltarBaseSetup.Show();
            this.Close();
        }
    }
}
