Add-Migration -Project Tanneryd.BulkOperations.EFCore.Tests -Startup Tanneryd.BulkOperations.EFCore.Tests InitialMigration

// This replaces the out commented line for Tax in the create table above.
migrationBuilder.Sql("ALTER TABLE dbo.Invoice ADD Tax AS (Gross - Net) PERSISTED NOT NULL");

// This replaces the out commented line for FullName in the create table above.
migrationBuilder.Sql("ALTER TABLE dbo.Instructor ADD FullName AS (FirstName + ' ' + LastName) PERSISTED NOT NULL");