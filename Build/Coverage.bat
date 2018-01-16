@echo on

SET dotnet="C:\Program Files\dotnet\dotnet.exe"  
SET opencover="..\Tools\opencover.4.6.519\OpenCover.Console.exe"
SET reportgenerator="..\Tools\ReportGenerator_2.5.9.0\ReportGenerator.exe"

SET targetargs="App.BL.Test\App.BL.Test.csproj"
SET filter=+[App]* 
SET coveragefile=Coverage.xml
SET coveragedir=Coverage

echo filter

REM Run code coverage analysis  
%opencover% ^
-target:%dotnet% ^
-targetargs:"test \"..\UTExample\App.BL.Test\App.BL.Test.csproj\"" ^
-mergeoutput ^
-hideskipped:File ^
-output:"%coveragedir%\%coveragefile%" ^
-oldStyle ^
-filter:"+[App*]*" ^
-searchdirs:"App.BL.Test\bin\Debug\netcoreapp1.1" ^
-register:user

REM Generate the report  
%reportgenerator% ^
-reports:"%coveragedir%\%coveragefile%" ^
-targetdir:%coveragedir% ^
-reporttypes:Html;Badges ^
-verbosity:Error

REM Open the report  
start "report" "%coveragedir%\index.htm"