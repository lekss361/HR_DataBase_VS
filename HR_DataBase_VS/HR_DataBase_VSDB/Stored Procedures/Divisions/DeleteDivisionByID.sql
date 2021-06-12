CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteDivisionByID]
	@Id int
AS
	DELETE FROM [Divisions] 
	WHERE [id] = @Id