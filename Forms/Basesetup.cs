using System;
using System.IO;
using System.Windows.Forms;
using mdc.m7.setup.Forms;

namespace mdc.m7.setup
{
    public partial class BaseSetup : Form
    {
        public BaseSetup()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Setup1_Load(object sender, EventArgs e)
        {
            
        }

        //## ESTAÇÃO
        private void Button2_Click(object sender, EventArgs e)
        {
            var estacao = new Estacao();
            estacao.Show();            
        }

        //## SERVIDOR
        private void Button1_Click(object sender, EventArgs e)
        {
            var FrmDadosConexao = new FrmDadosConexao();
            FrmDadosConexao.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
