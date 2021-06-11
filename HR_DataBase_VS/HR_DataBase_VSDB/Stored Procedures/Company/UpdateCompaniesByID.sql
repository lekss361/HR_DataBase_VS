CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateCompaniesByID]
    @Id           INT,
    @Name         NVARCHAR (255),
    @Information  NVARCHAR (255),
    @ContactID    INT,
    @LocationID   INT
AS
    INSERT  [Companies]
        ([Name], [Information], [ContactID], [LocationID])
    OUTPUT
    INSERTED.[Id],
    INSERTED.[Name],
    INSERTED.[Information],
    INSERTED.[ContactID],
    INSERTED.[LocationID]
    VALUES ( @Name, @Information, @ContactID, @LocationID)