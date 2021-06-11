CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateStatusesByID]
	@Id			int,
    @Name		NVARCHAR (255) 
AS
    INSERT  [Statuses]
        ([Name])
    OUTPUT
    INSERTED.[Id],
    INSERTED.[Name]
    VALUES ( @Name)