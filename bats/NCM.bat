@echo off
cls


SQLCMD -S localhost -i "%TEMP%\NCM_RJ.sql"
cls
SQLCMD -S localhost -U sa -P 1q2w3e -i "%TEMP%\NCM_RJ.sql"
cls
goto crm


:ncm_ba
SQLCMD -S localhost -i "%TEMP%\NCM_BA.sql"
cls
SQLCMD -S localhost -U sa -P 1q2w3e -i "%TEMP%\NCM_BA.sql"
cls
goto crm


:ncm_mg
SQLCMD -S localhost -i "%TEMP%\NCM_MG.sql"
cls
SQLCMD -S localhost -U sa -P 1q2w3e -i "%TEMP%\NCM_MG.sql"
cls

exit
