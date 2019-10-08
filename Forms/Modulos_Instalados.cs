using IWshRuntimeLibrary;
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
    public partial class Modulos_Instalados : Form
    {

        public Modulos_Instalados()
        {
            InitializeComponent();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {            
            // verifica se existem itens marcados
            if (checkedListBox1.CheckedItems.Count != 0)
            {
                // percorre todos os itens marcados
                // e verifica se um item especifico foi marcado
                for (int i = 0; i <= checkedListBox1.CheckedItems.Count - 1; i++)
                {
                    if (checkedListBox1.CheckedItems[i].ToString() == "Orchestra M7")
                    {
                        object shDesktop = (object)"Desktop";
                        WshShell shell = new WshShell();
                        string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\MDC Orchestra M7.lnk";
                        IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);                        
                        shortcut.TargetPath = @"C:\Program Files (x86)\MDCi\Show4\Show4.Exe";
                        shortcut.Save();
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "Estoque M7")
                    {
                        object shDesktop = (object)"Desktop";
                        WshShell shell = new WshShell();
                        string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\MDC Estoque M7.lnk";
                        IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                        shortcut.TargetPath = @"C:\Program Files (x86)\MDCi\TCW4\TCW4.Exe";
                        shortcut.Save();
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "Finance M7")
                    {
                        object shDesktop = (object)"Desktop";
                        WshShell shell = new WshShell();
                        string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\MDC Finance M7.lnk";
                        IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                        shortcut.TargetPath = @"C:\Program Files (x86)\MDCi\MDCFin6\mdcfin6.Exe";
                        shortcut.Save();
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "Fidelity M7")
                    {
                        object shDesktop = (object)"Desktop";
                        WshShell shell = new WshShell();
                        string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\MDC Fidelity M7.lnk";
                        IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                        shortcut.TargetPath = @"C:\Program Files (x86)\MDCi\MDCCRM\Chamada.Exe";
                        shortcut.Save();
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "Acesso M7")
                    {
                        object shDesktop = (object)"Desktop";
                        WshShell shell = new WshShell();
                        string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\MDC Acesso M7.lnk";
                        IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                        shortcut.TargetPath = @"C:\Program Files (x86)\MDCi\Show4\MDC.Acesso4.Exe";
                        shortcut.Save();
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "Caixa / PDV M7")
                    {
                        object shDesktop = (object)"Desktop";
                        WshShell shell = new WshShell();
                        string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\MDC Caixa M7.lnk";
                        IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                        shortcut.TargetPath = @"C:\Program Files (x86)\MDCi\Show3\CAIXA3.Exe";
                        shortcut.Save();
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "Touch M7")
                    {
                        object shDesktop = (object)"Desktop";
                        WshShell shell = new WshShell();
                        string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\MDC Touch M7.lnk";
                        IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                        shortcut.TargetPath = @"C:\Program Files (x86)\MDCi\Show4\Showtouch4.Exe";
                        shortcut.Save();
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "Delivery M7")
                    {
                        object shDesktop = (object)"Desktop";
                        WshShell shell = new WshShell();
                        string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\MDC Delivery M7.lnk";
                        IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                        shortcut.TargetPath = @"C:\Program Files (x86)\MDCi\Show4\Delivery2.Exe";
                        shortcut.Save();
                    }
                    if (checkedListBox1.CheckedItems[i].ToString() == "KDS")
                    {
                        object shDesktop = (object)"Desktop";
                        WshShell shell = new WshShell();
                        string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\MDC KDS.lnk";
                        IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                        shortcut.TargetPath = @"C:\Program Files (x86)\MDCi\KDS\MDC.KDSM7.Exe";
                        shortcut.Save();
                    }

                    var instalacao_finalizada = new Instalacao_Finalizada();
                    instalacao_finalizada.Show();
                    this.Close();
                }

                
            }
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Modulos_Instalados_Load(object sender, EventArgs e)
        {

        }
    }
}
