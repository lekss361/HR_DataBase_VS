CREATE PROCEDURE [HR_DataBase_VSDB].[GetDivisionByID]
	@Id int
AS
	SELECT * FROM [Divisions]
    WHERE [id] = @Id