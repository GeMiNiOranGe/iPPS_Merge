@echo off

@REM set code page to UTF-8
set code_page=65001
set server_name=.
set db_name=master

chcp %code_page%

@REM echo 1. Install database   
@REM echo 2. Re-install database
@REM echo 3. Restore data       
@REM echo 0. Uninstall database 
@REM set /p option="-> Choose an option: "

@REM for %%i in (*.sql) do (
@REM     sqlcmd /S . /d master -E -i"%%i"
@REM )

sqlcmd /S %server_name% /d %db_name% -E -f %code_page% -i"Database/InitialDatabase.sql"
echo Create database successful & echo:

sqlcmd /S %server_name% /d %db_name% -E -f %code_page% -i"Database/Function.sql"
echo Create functions successful & echo:

sqlcmd /S %server_name% /d %db_name% -E -f %code_page% -i"Database/StoredProcedure.sql"
echo Create stored procedure successful & echo:

@REM %~dp0: will return the Drive and Path to the batch script (e.g. W:\path\to\Database\)
sqlcmd /S %server_name% /d %db_name% -E -f %code_page% -i"Database/PopulateData.sql" -v workspace="%~dp0"
echo Insert data successful & echo:

@pause
