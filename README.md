# Housing

Cliente: John

## Migrations

Criar uma migration nova e atualizar o banco de dados:
Deixe setado o projeto API como projeto principal, v� em "Package Manager Console" e digite o c�digo abaixo:

```
Add-Migration -OutputDir "Database/Migrations" [NomeMigration] -Project Housing -StartupProject Housing -Context ApplicationDbContext

Update-Database -Project Housing -StartupProject Housing
```