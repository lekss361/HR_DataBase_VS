CREATE PROCEDURE [HR_DataBase_VSDB].[GetPositionByID]
	@Id int
AS
    SELECT * FROM [Positions]
    WHERE [id]= @Id