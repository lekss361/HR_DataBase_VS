CREATE PROCEDURE [HR_DataBase].[GetAllCommentsByWorkersID]
	@Worker int
AS
	SELECT  [ID],
    [WorkersID],
    [Comment],
    [Date]
    FROM [Comments]
    WHERE WorkersID=@Worker