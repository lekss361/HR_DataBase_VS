CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAllCompanies]
AS
	delete from [Companies]
	DBCC CHECKIDENT ([Companies], RESEED, 0)