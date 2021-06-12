CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateAllCommentsByID]
	@Id             int,
	@WorkerID       int,
	@Comment        nvarchar (255),
	@Date           date
AS
    UPDATE [Comments]
    SET
    [WorkerID] =    @WorkerID,
    [Comment] =     @Comment,
    [Date] =        @Date
    WHERE [Id] = @Id