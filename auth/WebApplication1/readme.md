
## Migrations
### installing the tool
dotnet tool install --global dotnet-ef --version 6.*
### creating a migration
dotnet ef migrations add Migrationname
### applying the migration
dotnet ef database update