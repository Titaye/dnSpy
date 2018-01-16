pushd %~dp0
dotnet publish -f net45 -c Release -o %~dp0dnSpyLibs\lib\net45\
dotnet publish -f netstandard2.0 -c Release -o %~dp0dnSpyLibs\lib\netstandard2.0\
popd
