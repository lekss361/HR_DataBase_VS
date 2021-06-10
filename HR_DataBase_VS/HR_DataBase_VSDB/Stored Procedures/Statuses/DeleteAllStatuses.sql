CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAllStatuses]
AS 
	DELETE FROM [Statuses]
	DBCC CHECKIDENT ([Statuses], RESEED, 0)