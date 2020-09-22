Install
https://fsprojects.github.io/Paket/installation.html#Installation-per-repository

Steps:
1. Run .packet\paket.bootstrapper.exe
2. Run .\paket\packet.exe install (for each change in the paket.dependencies execute this command)
3. Update paket.dependencies, paket.dependencies, paket.references and/or TestProject\TestProject.csproj.paket.references to test more scenarios. (Please note that TestProject.csproj.paket.references settings override the settings in the paket.references).
4. To restore run "msbuild /t:restore TestProject\TestProject.csproj"

