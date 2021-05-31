CREATE PROCEDURE [HR_DataBase_VSDB].[GetProjectByID]
	@Id int
AS
	SELECT * FROM [Projects]
    WHERE [id]=@Id