CREATE PROCEDURE [HR_DataBase_VSDB].[GetAllCommentsByWorkersID]
	@Worker int
AS
	SELECT  [id],
    [WorkerID],
    [Comment],
    [Date]
    FROM [Comments]
    WHERE WorkerID=@Worker