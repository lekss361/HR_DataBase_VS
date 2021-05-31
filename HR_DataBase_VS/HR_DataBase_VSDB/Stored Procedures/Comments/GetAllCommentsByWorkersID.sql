CREATE PROCEDURE [HR_DataBase_VSDB].[GetAllCommentsByWorkersID]
	@Worker int
AS
	SELECT  [id],
    [WorkersID],
    [Comment],
    [Date]
    FROM [Comments]
    WHERE WorkersID=@Worker