-- Desactivar temporalmente las restricciones de clave foránea
ALTER TABLE [db_crud_net].[dbo].[BookGenre] NOCHECK CONSTRAINT ALL;

-- Borrar los datos de las tablas respetando la relación entre ellas
DELETE FROM [db_crud_net].[dbo].[BookGenre];
DELETE FROM [db_crud_net].[dbo].[Books];
DELETE FROM [db_crud_net].[dbo].[Authors];
DELETE FROM [db_crud_net].[dbo].[Genres];

-- Reactivar las restricciones de clave foránea
ALTER TABLE [db_crud_net].[dbo].[BookGenre] CHECK CONSTRAINT ALL;