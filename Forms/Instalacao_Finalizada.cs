using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mdc.m7.setup.Forms;

namespace mdc.m7.setup
{
    public partial class Instalacao_Finalizada : Form
    {
        public Instalacao_Finalizada()
        {
            InitializeComponent();
        }

        private void Instalacao_Finalizada_Load(object sender, EventArgs e)
        {

        }

        private void Srv_Click(object sender, EventArgs e)
        {
            //Executar app externo para instalação
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            pProcess.StartInfo.FileName = "C:\\MDCi\\MDCTools\\MDCTools.exe";
            pProcess.Start();

            Application.Exit();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
