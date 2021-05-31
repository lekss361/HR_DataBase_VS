CREATE PROCEDURE [HR_DataBase_VSDB].[AddCompanies]
    @id              INT,
    @Name         NVARCHAR (255),
    @Information NVARCHAR (255),
    @ContactID    INT,
    @LocationID   INT            
             
AS
	INSERT INTO [Companies]  ([id],[Name],[Information],[ContactID],[LocationID])
	VALUES (@id,@Name,@Information,@ContactID, @LocationID  )
