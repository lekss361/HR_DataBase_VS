CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAllPreviousWork]
AS
	DELETE FROM [PreviousWorks]
	DBCC CHECKIDENT ([PreviousWorks], RESEED, 0)