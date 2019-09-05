# https://www.entityframeworktutorial.net/efcore/entity-framework-core-migration.aspx

dotnet ef \
  -s "shikService.Api/shikService.Api.csproj" \
  -p "shikService.Api/shikService.Api.csproj" \
database update
