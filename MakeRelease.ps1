$MyInvocation.MyCommand.Path | Split-Path | Push-Location # Run from this script's directory
$Name = (ls *.csproj).BaseName
dotnet build -c Release
cp bin\Release\netstandard2.1\$Name.dll BepInEx\plugins\$Name\