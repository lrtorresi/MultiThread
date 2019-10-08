using System;
using System.Windows.Forms;
using mdc.m7.setup.Entities;
using mdc.m7.setup.Services;
using mdc.m7.setup.Forms;
using System.Threading;
using System.Diagnostics;

namespace mdc.m7.setup
{
    public partial class ImportacaoNCM : Form
    {
        //## Variaveis Publicas
        public EstadoNCM EstadoNCM = new EstadoNCM();
        public GerarBatNCM gerarbatncm = new GerarBatNCM();
        Modulos_Instalados modulos_instalados = new Modulos_Instalados();
        FrmDadosConexao dadosConexao = new FrmDadosConexao();

        public ImportacaoNCM()
        {
            InitializeComponent();
            
        }

        #region All

       
        private void ImportacaoNCM_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }
        #endregion

        // ESTADOS
        #region RJ
        private void Button1_Click(object sender, EventArgs e)
        {            
            try
            {
                Thread threadNCM = new Thread(new ThreadStart(ncm));
                label4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                lblAguardeNCM.Visible = true;
                pictureBox3.Visible = true;
                threadNCM.Start();

                //NCM RJ
                EstadoNCM.Estado = "NCM_RJ";                
                gerarbatncm.GerarArquivoBat(EstadoNCM);                
            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}. \n\n Informe essa mensagem para a MDC", "MDC Brasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion

        #region MG                
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                Thread threadNCM = new Thread(new ThreadStart(ncm));
                label4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                lblAguardeNCM.Visible = true;
                pictureBox3.Visible = true;
                threadNCM.Start();

                //NCM MG
                EstadoNCM.Estado = "NCM_MG";
                gerarbatncm.GerarArquivoBat(EstadoNCM);

                modulos_instalados.Show();
                this.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}. \n\n Informe essa mensagem para a MDC", "MDC Brasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion

        #region BA
        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                Thread threadNCM = new Thread(new ThreadStart(ncm));
                label4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                lblAguardeNCM.Visible = true;
                pictureBox3.Visible = true;
                threadNCM.Start();

                //NCM BA
                EstadoNCM.Estado = "NCM_BA";
                gerarbatncm.GerarArquivoBat(EstadoNCM);

                modulos_instalados.Show();
                this.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}. \n\n Informe essa mensagem para a MDC", "MDC Brasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion

        #region PR
                
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                Thread threadNCM = new Thread(new ThreadStart(ncm));
                label4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                lblAguardeNCM.Visible = true;
                pictureBox3.Visible = true;
                threadNCM.Start();

                //NCM PR
                EstadoNCM.Estado = "NCM_PR";
                gerarbatncm.GerarArquivoBat(EstadoNCM);

                modulos_instalados.Show();
                this.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}. \n\n Informe essa mensagem para a MDC", "MDC Brasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion

        #region DF
                
        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Thread threadNCM = new Thread(new ThreadStart(ncm));
                label4.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                lblAguardeNCM.Visible = true;
                pictureBox3.Visible = true;
                threadNCM.Start();

                //NCM DF
                EstadoNCM.Estado = "NCM_DF";
                gerarbatncm.GerarArquivoBat(EstadoNCM);

                modulos_instalados.Show();
                this.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}. \n\n Informe essa mensagem para a MDC", "MDC Brasil", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        #endregion

        void ncm()
        {
            // Executando a Bat gerada para importar o NCM
            var inf = new ProcessStartInfo("C:\\ProgramData\\NCM.bat");
            var proc = new Process();
            inf.CreateNoWindow = true;
            inf.UseShellExecute = false;
            proc.StartInfo = inf;
            proc.Start();
            proc.WaitForExit();

            this.Invoke(new MethodInvoker(delegate ()
            {
                modulos_instalados.Show();
                this.Close();
            }
            ));
        }

        // Exit 
        private void Button6_Click(object sender, EventArgs e)
        {
            var voltarServidor = new Servidor();
            voltarServidor.Show();
            this.Close();
        }   
    }
}
