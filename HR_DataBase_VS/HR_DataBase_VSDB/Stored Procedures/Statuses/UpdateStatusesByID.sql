CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateStatusesByID]
	@Id			int,
    @Name		NVARCHAR (255) 
AS
    UPDATE [Statuses]
    SET    [Name] = @Name
    WHERE  [id] = @Id