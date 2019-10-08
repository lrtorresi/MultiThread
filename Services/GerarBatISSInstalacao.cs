using System.Diagnostics;
using System.IO;
using mdc.m7.setup.Entities;

namespace mdc.m7.setup.Services
{
    public class GerarBatISSInstalacao
    {
        public void GerarArquivoBatIIS(GerarBatISSInstalacao iisInstalacao)
        {
            var streamWriter = new StreamWriter("C:\\programdata\\IISInstalacao.bat");
            streamWriter.WriteLine("@echo off");
            streamWriter.WriteLine("@ECHO ======= Adicionar o site no IIS (MDC.M8.API)");
            streamWriter.WriteLine("cd\\windows\\System32\\inetsrv > NULL");
            streamWriter.WriteLine("appcmd add site /name:mdc.m8.api /id:8 /physicalPath:C:\\inetpub\\wwwroot\\mdc.m8.api /bindings:http/*:9090: > NULL");
            streamWriter.WriteLine("appcmd add apppool /name:mdc.m8.api /managedRuntimeVersion:v4.0 /managedPipelineMode:Integrated > NULL");
            streamWriter.WriteLine("appcmd set site /site.name:mdc.m8.api /[path='/'].applicationPool:mdc.m8.api > NULL");
            streamWriter.WriteLine("cd\\windows\\System32\\inetsrv > NULL");
            streamWriter.WriteLine("appcmd add site /name:mdc.m8.orchestra /id:9 /physicalPath:C:\\inetpub\\wwwroot\\mdc.m8.orchestra /bindings:http/*:9081: > NULL");
            streamWriter.WriteLine("appcmd add apppool /name:mdc.m8.orchestra /managedRuntimeVersion:v4.0 /managedPipelineMode:Integrated > NULL");
            streamWriter.WriteLine("appcmd set site /site.name:mdc.m8.orchestra /[path='/'].applicationPool:mdc.m8.orchestra > NULL");
            streamWriter.WriteLine("cd\\windows\\System32\\inetsrv > NULL");
            streamWriter.WriteLine("appcmd add site /name:mdc.m8.report /id:10 /physicalPath:C:\\inetpub\\wwwroot\\mdc.m8.report /bindings:http/*:9091: > NULL");
            streamWriter.WriteLine("appcmd add apppool /name:mdc.m8.report /managedRuntimeVersion: /managedPipelineMode:Integrated > NULL");
            streamWriter.WriteLine("appcmd set site /site.name:mdc.m8.report /[path='/'].applicationPool:mdc.m8.report > NULL");
            streamWriter.WriteLine("cd\\windows\\System32\\inetsrv > NULL");
            streamWriter.WriteLine("appcmd add site /name:mdc.m8.rms /id:11 /physicalPath:C:\\inetpub\\wwwroot\\mdc.m8.rms /bindings:http/*:9082: > NULL");
            streamWriter.WriteLine("appcmd add apppool /name:mdc.m8.rms /managedRuntimeVersion:v4.0 /managedPipelineMode:Integrated > NULL");
            streamWriter.WriteLine("appcmd set site /site.name:mdc.m8.rms /[path='/'].applicationPool:mdc.m8.rms > NULL");
            streamWriter.WriteLine("C:\\Windows\\System32\\inetsrv\\appcmd add app /site.name:\"Default Web Site\" /path:/WS_M7 /physicalPath:\"C:\\inetpub\\wwwroot\\WS_M7\"");
            streamWriter.WriteLine("C:\\Windows\\System32\\inetsrv\\appcmd add app /site.name:\"Default Web Site\" /path:/mdc.restapi /physicalPath:\"C:\\inetpub\\wwwroot\\mdc.restapi\"");            
            streamWriter.WriteLine("c:");
            streamWriter.WriteLine("cd\\inetpub\\wwwroot\\mdc.restapi > NULL");
            streamWriter.WriteLine("copy \"C:\\Temp\\Config\\mdc.restapi\\Web.config\" > NULL");
            streamWriter.WriteLine("c:");
            streamWriter.WriteLine("cd\\inetpub\\wwwroot\\WS_M7 > NULL");
            streamWriter.WriteLine("copy \"C:\\Temp\\Config\\WS_M7\\Web.config\" > NULL");
            streamWriter.WriteLine("c:");
            streamWriter.WriteLine("cd\\inetpub\\wwwroot\\mdc.m8.rms > NULL");
            streamWriter.WriteLine("copy \"C:\\Temp\\Config\\mdc.m8.rms\\Web.config\" > NULL");
            streamWriter.WriteLine("iisreset /stop");
            streamWriter.WriteLine("iisreset /start");            
            streamWriter.Close();
        }
    }
}

