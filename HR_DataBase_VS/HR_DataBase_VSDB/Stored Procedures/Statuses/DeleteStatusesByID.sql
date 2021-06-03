CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteStatusesByID]
	@Id INT
AS
	DELETE from [Statuses] 
	WHERE [id] = @Id
