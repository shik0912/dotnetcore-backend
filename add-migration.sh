# https://www.entityframeworktutorial.net/efcore/entity-framework-core-migration.aspx

dotnet ef \
  -s "shikService.Api/shikService.Api.csproj" \
  -p "shikService.Infrastructure/shikService.Infrastructure.csproj" \
migrations add "$1" -o "Migrations"