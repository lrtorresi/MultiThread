using System.Diagnostics;
using System.IO;
using mdc.m7.setup.Entities;

namespace mdc.m7.setup.Services
{
    public class GerarBatNCM
    {
        //## Gerar script para importação de NCM
        public void GerarArquivoBat(EstadoNCM estadoNCM)
        {       
            var streamWriter = new StreamWriter("C:\\programdata\\NCM.bat");           
            streamWriter.WriteLine("@echo off");
            streamWriter.WriteLine("cls");
            streamWriter.WriteLine($"sqlcmd -S localhost -i \"C:\\programdata\\{estadoNCM.Estado}.sql\" ");
            streamWriter.Close();
        }
    }
}

 