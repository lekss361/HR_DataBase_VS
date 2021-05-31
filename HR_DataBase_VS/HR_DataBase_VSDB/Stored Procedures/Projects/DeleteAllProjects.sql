CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAllProjects]
AS
	DELETE FROM [Projects]
	DBCC CHECKIDENT ([Projects], RESEED, 0)