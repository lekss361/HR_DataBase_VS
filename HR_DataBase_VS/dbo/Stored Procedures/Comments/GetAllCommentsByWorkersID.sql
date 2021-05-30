CREATE PROCEDURE [dbo].[GetAllCommentsByWorkersID]
	@Worker int
AS
	SELECT  [ID],
    [WorkersID],
    [Comment],
    [Date]
    FROM [Comments]
    WHERE WorkersID=@Worker