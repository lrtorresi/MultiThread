@echo off
cls

if exist "%SystemRoot%\SysWOW64\AdvancedInstallers" goto server64 goto server32
:server32

cls
echo.
cls
echo.
echo.
ECHO ======= REGISTRANDO ARQUIVOS (Windows 32Bits) =======
ECHO POR FAVOR NAO FECHAR ESTA TELA!
ECHO ATT.,
ECHO MDC
ECHO =====================================================
ECHO.
ECHO.
echo REGISTRANDO ARQUIVOS...
echo ----------------------------------
echo Progresso: 께께께께께께께께께께 5%%
echo ----------------------------------
ping localhost -n 3 >NUL
cd\program files\Common Files\MDCi
attrib /s -a
regsvr32 mdclog60.dll -u -s
regsvr32 mdclog60.dll -s
regsvr32 mdclog70.dll -u -s
regsvr32 mdclog70.dll -s
regsvr32 mdcroute.dll -u -s
regsvr32 mdcroute.dll -s
regsvr32 mdcdash.ocx -u -s
regsvr32 mdcdash.ocx -s
regasm_20 /u mdc.licclient3.dll
regasm_20 mdc.licclient3.dll
C:\Windows\Microsoft.NET\Framework\v4.0.30319\regasm MDC.LicClient3.dll /tlb:MDC.LicClient3.tlb /codebase
regasm_20 /u mdc.licclient3.xmlserializers.dll
regasm_20 mdc.licclient3.xmlserializers.dll
gacutil -i mdc.licclient3.dll
gacutil -i mdc.licclient3.xmlserializers.dll
mdcpos4.exe
mdcpos5.exe
cls


echo.
cls
echo.
echo.
ECHO ======= REGISTRANDO ARQUIVOS (Windows 32Bits) =======
ECHO POR FAVOR NAO FECHAR ESTA TELA!
ECHO ATT.,
ECHO MDC
ECHO =====================================================
ECHO.
ECHO.
echo REGISTRANDO ARQUIVOS...
echo ----------------------------------
echo Progresso: 께께께께께께께께께께 10%%
echo ----------------------------------
ping localhost -n 3 >NUL
cd\program files\mdci\
attrib /s -a

cd\program files\mdci\show4\
regasm_20 /u mdc.shw4rep.dll
regasm_20 /u mdc.acc4rep.dll
regasm_20 mdc.shw4rep.dll
regasm_20 mdc.acc4rep.dll
regasm_20 /u MDC.Fin6Rep.dll
regasm_20  MDC.Fin6Rep.dll
regasm_20 /u MDC.Fin6Tools.dll
regasm_20 MDC.Fin6Tools.dll
regsvr32 MDCSHWPR.dll -s
regsvr32 MDCSHWPR.dll -u -s
regasm_20 /u mdc.licclient3.dll
regasm_20 mdc.licclient3.dll
C:\Windows\Microsoft.NET\Framework\v4.0.30319\regasm MDC.LicClient3.dll /tlb:MDC.LicClient3.tlb /codebase
cls

echo.
cls
echo.
echo.
ECHO ======= REGISTRANDO ARQUIVOS (Windows 32Bits) =======
ECHO POR FAVOR NAO FECHAR ESTA TELA!
ECHO ATT.,
ECHO MDC
ECHO =====================================================
ECHO.
ECHO.
echo REGISTRANDO ARQUIVOS...
echo ----------------------------------
echo Progresso: 께께께께께께께께께께 20%%
echo ----------------------------------
ping localhost -n 3 >NUL

cd\program files\mdci\show3\
regsvr32 MDCSHWPR.dll -u -s
regsvr32 MDCSHWPR.dll -s


cd\program files\mdci\mdccrm\
regsvr32 mdccrm1.dll -u -s
regsvr32 mdccrm1.dll -s


cd\program files\mdci\tcw4\
regsvr32 tcw4hal.dll -u -s
regsvr32 tcw4hal.dll -s
regsvr32 tcw4rep.dll -u -s
regsvr32 tcw4rep.dll -s


cd\program files\mdci\mdcfin6\
regsvr32 fin6hal.dll -u -s
regsvr32 fin6hal.dll -s
regasm_20 mdc.licclient3.xmlserializers.dll
regasm_20 /u MDC.Fin6Rep.dll
regasm_20 /u MDC.Fin6Tools.dll
regasm_20 MDC.Fin6Rep.dll
regasm_20 MDC.Fin6Tools.dll
cls

echo.
cls
echo.
echo.
ECHO ======= REGISTRANDO ARQUIVOS (Windows 32Bits) =======
ECHO POR FAVOR NAO FECHAR ESTA TELA!
ECHO ATT.,
ECHO MDC
ECHO =====================================================
ECHO.
ECHO.
echo REGISTRANDO ARQUIVOS...
echo ----------------------------------
echo Progresso: 께께께께께께께께께께 35%%
echo ----------------------------------
ping localhost -n 3 >NUL
cd\arquivos de programas\arquivos comuns\MDCi
attrib /s -a
regsvr32 mdclog60.dll -u -s
regsvr32 mdclog60.dll -s
regsvr32 mdclog70.dll -u -s
regsvr32 mdclog70.dll -s
regsvr32 mdcroute.dll -u -s
regsvr32 mdcroute.dll -s
regasm_20 /u mdc.licclient3.dll
regasm_20 mdc.licclient3.dll
regasm_20 /u mdc.licclient3.xmlserializers.dll
regasm_20 mdc.licclient3.xmlserializers.dll
gacutil -i mdc.licclient3.dll
gacutil -i mdc.licclient3.xmlserializers.dll
mdcpos4.exe
mdcpos5.exe
cls

echo.
cls
echo.
echo.
ECHO ======= REGISTRANDO ARQUIVOS (Windows 32Bits) =======
ECHO POR FAVOR NAO FECHAR ESTA TELA!
ECHO ATT.,
ECHO MDC
ECHO =====================================================
ECHO.
ECHO.
echo REGISTRANDO ARQUIVOS...
echo ----------------------------------
echo Progresso: 께께께께께께께께께께 45%%
echo ----------------------------------
ping localhost -n 3 >NUL
cd\arquivos de programas\mdci\
attrib /s -a

cd\arquivos de programas\mdci\show4\
regasm_20 /u mdc.shw4rep.dll
regasm_20 /u mdc.acc4rep.dll
regasm_20 mdc.shw4rep.dll
regasm_20 mdc.acc4rep.dll
regasm_20 /u MDC.Fin6Rep.dll
regasm_20  MDC.Fin6Rep.dll
regasm_20 /u MDC.Fin6Tools.dll
regasm_20 MDC.Fin6Tools.dll
regsvr32 MDCSHWPR.dll -s
regsvr32 MDCSHWPR.dll -u -s
regsvr32 mdc.m7.delivery.dll -u -s
regsvr32 mdc.m7.delivery.dll -s

cd\arquivos de programas\mdci\show3\
regsvr32 MDCSHWPR.dll -u -s
regsvr32 MDCSHWPR.dll -s


cd\arquivos de programas\mdci\mdccrm\
regsvr32 mdccrm1.dll -u -s
regsvr32 mdccrm1.dll -s


cd\arquivos de programas\mdci\tcw4\
regsvr32 tcw4hal.dll -u -s
regsvr32 tcw4hal.dll -s
regsvr32 tcw4rep.dll -u -s
regsvr32 tcw4rep.dll -s
cls

echo.
cls
echo.
echo.
ECHO ======= REGISTRANDO ARQUIVOS (Windows 32Bits) =======
ECHO POR FAVOR NAO FECHAR ESTA TELA!
ECHO ATT.,
ECHO MDC
ECHO =====================================================
ECHO.
ECHO.
echo REGISTRANDO ARQUIVOS...
echo ----------------------------------
echo Progresso: 께께께께께께께께께께 85%%
echo ----------------------------------
ping localhost -n 3 >NUL
cd\arquivos de programas\mdci\mdcfin6\
regsvr32 fin6hal.dll -u -s
regsvr32 fin6hal.dll -s
regasm_20 mdc.licclient3.xmlserializers.dll
regasm_20 /u MDC.Fin6Rep.dll
regasm_20 /u MDC.Fin6Tools.dll
regasm_20 MDC.Fin6Rep.dll
regasm_20 MDC.Fin6Tools.dll
cls

@ECHO Registrando arquivos
cd\Program Files\mdci\MDCCRM\
regsvr32 mdccrm1.dll -u -s
regsvr32 mdccrm1.dll -s
echo.
cls

echo.
ECHO ======= REGISTRANDO ARQUIVOS (Windows 32Bits) =======
ECHO POR FAVOR NAO FECHAR ESTA TELA!
ECHO ATT.,
ECHO MDC
ECHO =====================================================
ECHO.
ECHO.
echo REGISTRANDO ARQUIVOS...
echo ----------------------------------
echo Progresso: 께께께께께께께께께께 95%%
echo ----------------------------------
ping localhost -n 3 >NUL

cls
echo.
echo.
echo REGISTRANDO ARQUIVOS...
echo ----------------------------------
echo Progresso: 栢栢栢栢栢栢栢栢栢栢 100%%
echo ----------------------------------
GOTO END
:END
cls

c:
cd\
cd Program Files
cd Common Files\MDCi
start RegistraNFCe.bat
cls
goto exit


:server64
cls
echo.
cls
echo.
echo.
ECHO ======= REGISTRANDO ARQUIVOS (Windows 64Bits) =======
ECHO POR FAVOR NAO FECHAR ESTA TELA!
ECHO ATT.,
ECHO MDC
ECHO =====================================================
ECHO.
ECHO.
echo REGISTRANDO ARQUIVOS...
echo ----------------------------------
echo Progresso: 께께께께께께께께께께 5%%
echo ----------------------------------
ping localhost -n 3 >NUL

cls


echo.
cls
echo.
echo.
ECHO ======= REGISTRANDO ARQUIVOS (Windows 64Bits) =======
ECHO POR FAVOR NAO FECHAR ESTA TELA!
ECHO ATT.,
ECHO MDC
ECHO =====================================================
ECHO.
ECHO.
echo REGISTRANDO ARQUIVOS...
echo ----------------------------------
echo Progresso: 께께께께께께께께께께 10%%
echo ----------------------------------
ping localhost -n 3 >NUL
cd\Program Files (x86)\Common Files\mdci\

attrib /s -a
regsvr32 mdclog60.dll -u -s
regsvr32 mdclog60.dll -s
regsvr32 mdclog70.dll -u -s
regsvr32 mdclog70.dll -s
regsvr32 mdcroute.dll -u -s
regsvr32 mdcroute.dll -s
regsvr32 mdcdash.ocx -u -s
regsvr32 mdcdash.ocx -s
regasm_20 /u mdc.licclient3.dll
regasm_20 mdc.licclient3.dll
C:\Windows\Microsoft.NET\Framework\v4.0.30319\regasm MDC.LicClient3.dll /tlb:MDC.LicClient3.tlb /codebase
regasm_20 /u mdc.licclient3.xmlserializers.dll
regasm_20 mdc.licclient3.xmlserializers.dll
gacutil -i mdc.licclient3.dll
gacutil -i mdc.licclient3.xmlserializers.dll
mdcpos4.exe
mdcpos5.exe
cls

echo.
cls
echo.
echo.
ECHO ======= REGISTRANDO ARQUIVOS (Windows 64Bits) =======
ECHO POR FAVOR NAO FECHAR ESTA TELA!
ECHO ATT.,
ECHO MDC
ECHO =====================================================
ECHO.
ECHO.
echo REGISTRANDO ARQUIVOS...
echo ----------------------------------
echo Progresso: 께께께께께께께께께께 20%%
echo ----------------------------------
ping localhost -n 3 >NUL
cd\Program Files (x86)\mdci\
attrib /s -a

cd\Program Files (x86)\mdci\show4\
regasm_20 /u mdc.shw4rep.dll
regasm_20 /u mdc.acc4rep.dll
regasm_20 mdc.shw4rep.dll
regasm_20 mdc.acc4rep.dll
regasm_20 /u MDC.Fin6Rep.dll
regasm_20  MDC.Fin6Rep.dll
regasm_20 /u MDC.Fin6Tools.dll
regasm_20 MDC.Fin6Tools.dll
regsvr32 MDCSHWPR.dll -s
regsvr32 MDCSHWPR.dll -u -s
regsvr32 mdc.m7.delivery.dll -u -s
regsvr32 mdc.m7.delivery.dll -s
regasm_20 /u mdc.licclient3.dll
regasm_20 mdc.licclient3.dll
C:\Windows\Microsoft.NET\Framework\v4.0.30319\regasm MDC.LicClient3.dll /tlb:MDC.LicClient3.tlb /codebase
cls

echo.
cls
echo.
echo.
ECHO ======= REGISTRANDO ARQUIVOS (Windows 64Bits) =======
ECHO POR FAVOR NAO FECHAR ESTA TELA!
ECHO ATT.,
ECHO MDC
ECHO =====================================================
ECHO.
ECHO.
echo REGISTRANDO ARQUIVOS...
echo ----------------------------------
echo Progresso: 께께께께께께께께께께 35%%
echo ----------------------------------
ping localhost -n 3 >NUL
cd\Program Files (x86)\mdci\show3\
regsvr32 MDCSHWPR.dll -u -s
regsvr32 MDCSHWPR.dll -s


cd\Program Files (x86)\mdci\mdccrm\
regsvr32 mdccrm1.dll -u -s
regsvr32 mdccrm1.dll -s
cls

echo.
cls
echo.
echo.
ECHO ======= REGISTRANDO ARQUIVOS (Windows 64Bits) =======
ECHO POR FAVOR NAO FECHAR ESTA TELA!
ECHO ATT.,
ECHO MDC
ECHO =====================================================
ECHO.
ECHO.
echo REGISTRANDO ARQUIVOS...
echo ----------------------------------
echo Progresso: 께께께께께께께께께께 45%%
echo ----------------------------------
ping localhost -n 3 >NUL

cd\Program Files (x86)\mdci\tcw4\
regsvr32 tcw4hal.dll -u -s
regsvr32 tcw4hal.dll -s
regsvr32 tcw4rep.dll -u -s
regsvr32 tcw4rep.dll -s
cls


echo.
cls
echo.
echo.
ECHO ======= REGISTRANDO ARQUIVOS (Windows 64Bits) =======
ECHO POR FAVOR NAO FECHAR ESTA TELA!
ECHO ATT.,
ECHO MDC
ECHO =====================================================
ECHO.
ECHO.
echo REGISTRANDO ARQUIVOS...
echo ----------------------------------
echo Progresso: 께께께께께께께께께께 70%%
echo ----------------------------------
ping localhost -n 3 >NUL
cd\Program Files (x86)\mdci\mdcfin6\
regsvr32 fin6hal.dll -u -s
regsvr32 fin6hal.dll -s
regasm_20 mdc.licclient3.xmlserializers.dll
regasm_20 /u MDC.Fin6Rep.dll
regasm_20 /u MDC.Fin6Tools.dll
regasm_20 MDC.Fin6Rep.dll
regasm_20 MDC.Fin6Tools.dll
cls


echo.
cls
echo.
ECHO ======= REGISTRANDO ARQUIVOS (Windows 64Bits) =======
ECHO POR FAVOR NAO FECHAR ESTA TELA!
ECHO ATT.,
ECHO MDC
ECHO =====================================================
ECHO.
ECHO.
echo REGISTRANDO ARQUIVOS...
echo ----------------------------------
echo Progresso: 께께께께께께께께께께 95%%
echo ----------------------------------
ping localhost -n 3 >NUL



cls
echo.
echo.
echo REGISTRANDO ARQUIVOS...
echo ----------------------------------
echo Progresso: 栢栢栢栢栢栢栢栢栢栢 100%%
echo ----------------------------------

cls

@ECHO ======================MDC Brasil======================
c:
cd\
cd Program Files (x86)
cd Common Files\MDCi
start RegistraNFCe.bat
@ECHO ======================================================
cls

:exit
exit
