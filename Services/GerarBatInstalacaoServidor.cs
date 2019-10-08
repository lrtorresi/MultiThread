using System.Diagnostics;
using System.IO;
using mdc.m7.setup.Entities;

namespace mdc.m7.setup.Services
{
    public class GerarBatInstalacaoServidor
    {
        public void GerarArquivoBatServidor(DadosConexao dadosConexao)
        {    
                        
            //## 32BITS
            var streamWriter = new StreamWriter("C:\\programdata\\Server_Instalacao.bat");
            streamWriter.WriteLine("@echo off");            
            streamWriter.WriteLine("if exist \"%SystemRoot%\\SysWOW64\\AdvancedInstallers\" goto server64 goto server32");
            streamWriter.WriteLine(":server32");
            streamWriter.WriteLine("echo. ((CRIANDO BANCO DE DADOS -- 32 BITS))");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files\\Common Files\\MDCi\\Criamdccrm.sql \"");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files\\Common Files\\MDCi\\Criamdcfin6.sql\"");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files\\Common Files\\MDCi\\Criamdclog.sql\"");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files\\Common Files\\MDCi\\CriaShow4.sql\"");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files\\Common Files\\MDCi\\CriaShow4BKP.sql\"");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files\\Common Files\\MDCi\\CriaTcw4.sql\"");            
            streamWriter.WriteLine("regedit /s \"C:\\Program Files\\MDCi\\MDCFin6\\reg_x32.reg\"");
            streamWriter.WriteLine("");

            streamWriter.WriteLine("echo. ((ATUALIZANDO BANCO DE DADOS -- 32 BITS))");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files\\MDCi\\MDCCRM\\SPCRM1.sql \"");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files\\MDCi\\MDCFin6\\spFin6.sql \"");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files\\MDCi\\Show4\\SPSHW4.sql\"");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files\\MDCi\\TCW4\\SPTCW4.sql\"");
            streamWriter.WriteLine("Exit");
            streamWriter.WriteLine("");
            streamWriter.WriteLine("");


            //## 64BITS            
            streamWriter.WriteLine(":server64");
            streamWriter.WriteLine("echo. ((CRIANDO BANCO DE DADOS -- 64 BITS))");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files (x86)\\Common Files\\MDCi\\Criamdccrm.sql \"");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files (x86)\\Common Files\\MDCi\\Criamdcfin6.sql\"");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files (x86)\\Common Files\\MDCi\\Criamdclog.sql\"");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files (x86)\\Common Files\\MDCi\\CriaShow4.sql\"");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files (x86)\\Common Files\\MDCi\\CriaShow4BKP.sql\"");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files (x86)\\Common Files\\MDCi\\CriaTcw4.sql\"");
            streamWriter.WriteLine("regedit /s \"C:\\Program Files (x86)\\MDCi\\MDCFin6\\reg_x64.reg\"");
            streamWriter.WriteLine("");

            streamWriter.WriteLine("echo. ((ATUALIZANDO BANCO DE DADOS -- 64 BITS))");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files (x86)\\MDCi\\MDCCRM\\SPCRM1.sql \"");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files (x86)\\MDCi\\MDCFin6\\spFin6.sql \"");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files (x86)\\MDCi\\Show4\\SPSHW4.sql\"");
            streamWriter.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files (x86)\\MDCi\\TCW4\\SPTCW4.sql\"");
            streamWriter.WriteLine("");
            streamWriter.WriteLine("Exit");
            streamWriter.Close();




            //## ATUALIZAÇÃO

            //## 64BITS 
            var streamWriter2 = new StreamWriter("C:\\programdata\\Server_Atualizacao.bat");
            streamWriter2.WriteLine("@echo off");
            streamWriter2.WriteLine("if exist \"%SystemRoot%\\SysWOW64\\AdvancedInstallers\" goto server64 goto server32");
            streamWriter2.WriteLine(":server32");
            streamWriter2.WriteLine("echo. ((ATUALIZANDO BANCO DE DADOS -- 32 BITS))");
            streamWriter2.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files\\MDCi\\MDCCRM\\SPCRM1.sql \"");
            streamWriter2.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files\\MDCi\\MDCFin6\\spFin6.sql \"");
            streamWriter2.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files\\MDCi\\Show4\\SPSHW4.sql\"");
            streamWriter2.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files\\MDCi\\TCW4\\SPTCW4.sql\"");
            streamWriter2.WriteLine("Exit");
            streamWriter2.WriteLine("");
            streamWriter2.WriteLine("");

            //## 64BITS 
            streamWriter2.WriteLine(":server64");            
            streamWriter2.WriteLine("echo. ((ATUALIZANDO BANCO DE DADOS -- 64 BITS))");
            streamWriter2.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files (x86)\\MDCi\\MDCCRM\\SPCRM1.sql \"");
            streamWriter2.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files (x86)\\MDCi\\MDCFin6\\spFin6.sql \"");
            streamWriter2.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files (x86)\\MDCi\\Show4\\SPSHW4.sql\"");
            streamWriter2.WriteLine($"SQLCMD -S {dadosConexao.Server} -U sa -P {dadosConexao.Password} -i \"C:\\Program Files (x86)\\MDCi\\TCW4\\SPTCW4.sql\"");
            streamWriter2.WriteLine("");
            streamWriter2.WriteLine("Exit");
            streamWriter2.Close();
        }
    }
}

