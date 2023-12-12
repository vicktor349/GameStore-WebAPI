# GAME STORE API

# STARTING SQL SERVER
```powershell
$sa_password = "[SA PASSWORD HERE]"
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=$sa_password" -p 1433:1433
--mount source=sqlvolume,target=/var/opt/mssql -d --rm --name mssql mcr.microsoft.com/mssql/server:2022-latest
```

# SETTING THE CONNECTION STRING TO SECRET MANAGER

```powershell
$sa_password = "password"
dotnet user-secrets set "ConnectionStrings:GameStoreContext" "Server=localhost; Database=GameStore; User Id=sa; Password=$sa_password; TrustServerCertificate=True"
```