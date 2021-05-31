CREATE PROCEDURE [HR_DataBase_VSDB].[GetDivisionByID]
	@id int
AS
	SELECT * FROM [Divisions]
    WHERE [id] = @id