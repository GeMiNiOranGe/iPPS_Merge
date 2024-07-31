@echo off

@REM set code page to UTF-8
chcp 65001

@REM echo 1. Install database   
@REM echo 2. Re-install database
@REM echo 3. Restore data       
@REM echo 0. Uninstall database 
@REM set /p option="-> Choose an option: "

@REM for %%i in (*.sql) do (
@REM     sqlcmd /S . /d master -E -i"%%i"
@REM )

@REM sqlcmd /S . /d master -E -i"Database/InitialDatabase.sql"
@REM sqlcmd /S . /d master -E -i"Database/Function.sql"
@REM sqlcmd /S . /d master -E -i"Database/StoredProcedure.sql"
@REM sqlcmd /S . /d master -E -i"Database/PopulateData.sql"

@REM %~dp0: will return the Drive and Path to the batch script (e.g. W:\path\to\Database\)
sqlcmd /S . /d master -E -f 65001 -i"Database/PopulateData.sql" -v workspace="%~dp0"

pause
