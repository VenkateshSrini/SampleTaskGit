REM Deployment in PCF
cf push -u none
cf stop SampleTask
cf run-task SampleTask "dotnet SampleTask.dll "Sample"" --name execute-sample-task