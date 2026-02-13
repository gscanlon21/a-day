# Migrations

Add-Migration SquashMigrations -Project Shared.Data -Context SharedContext

Remove-Migration -Project Shared.Data -Context SharedContext

Update-Database -Project Shared.Data -Context SharedContext


## Squash Migrations

- Delete all migration files including the CoreContextModelSnapshot.cs
- Add a new migration to generate a migration for the entire database.
- Delete all old migrations from the __EFMigrationsHistory table.
- Add the new migration to the __EFMigrationsHistory table.
- Update the database and check no migrations were applied.