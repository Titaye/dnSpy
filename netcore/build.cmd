pushd %~dp0
dotnet publish -c Release -o %~dp0dnSpyLibs\lib\netstandard2.0\
popd