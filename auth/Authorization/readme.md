
## Migrations
### installing the tool
dotnet tool install --global dotnet-ef --version 6.*
### creating a migration
dotnet ef migrations add Migrationname
### applying the migration
dotnet ef database update

dotnet ef migrations add initialAuth -c AuthDbContext -o Migrations/IdentityServer/Auth
dotnet ef database update -c AuthDbContext
dotnet ef migrations add Grants -c PersistedGrantDbContext -o Migrations/IdentityServer/PersistedGrantDb
dotnet ef database update -c PersistedGrantDbContext
dotnet ef migrations add Config -c ConfigurationDbContext -o Migrations/IdentityServer/ConfigurationDb
dotnet ef database update -c ConfigurationDbContext
dotnet ef migrations script -c PersistedGrantDbContext -o Migrations/IdentityServer/PersistedGrantDb.sql
dotnet ef migrations script -c ConfigurationDbContext -o Migrations/IdentityServer/ConfigurationDb.sql