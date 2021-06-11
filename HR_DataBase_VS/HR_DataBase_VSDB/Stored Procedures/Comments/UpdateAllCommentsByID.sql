CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateAllCommentsByID]
	@id             int,
	@WorkerID       int,
	@Comment        nvarchar (255),
	@Date           date
AS
    INSERT [Comments]
        ([WorkerID], [Comment], [Date])
    OUTPUT
    INSERTED.[id],
    INSERTED.[WorkerID],
    INSERTED.[Comment],
    INSERTED.[Date]
  VALUES ( @WorkerID, @Comment, @Date)