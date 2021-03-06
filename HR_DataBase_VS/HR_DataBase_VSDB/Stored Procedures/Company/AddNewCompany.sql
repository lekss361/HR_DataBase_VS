CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewCompany]
    @Name         NVARCHAR (255),
    @Information  NVARCHAR (255),
    @ContactID    INT,
    @LocationID   INT
AS
	INSERT INTO [Companies] ([Name], [Information], [ContactID], [LocationID])
	VALUES (@Name, @Information, @ContactID, @LocationID)
	SELECT @@IDENTITY