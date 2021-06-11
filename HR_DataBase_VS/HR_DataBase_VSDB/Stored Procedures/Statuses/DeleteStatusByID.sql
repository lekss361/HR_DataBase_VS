CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteStatusByID]
	@Id INT
AS
	DELETE from [Statuses] 
	WHERE [id] = @Id