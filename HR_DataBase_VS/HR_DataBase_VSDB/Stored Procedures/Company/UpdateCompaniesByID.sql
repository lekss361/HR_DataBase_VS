CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateCompaniesByID]
    @Id           INT,
    @Name         NVARCHAR (255),
    @Information  NVARCHAR (255),
    @ContactID    INT,
    @LocationID   INT
AS
    UPDATE [Companies]
    SET
    [Name] =        @Name,
    [Information] = @Information,
    [ContactID] =   @ContactID,
    [LocationID] =  @LocationID
    WHERE [Id] = @Id