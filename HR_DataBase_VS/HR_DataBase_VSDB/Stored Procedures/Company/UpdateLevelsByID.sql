CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateCompaniesByID]
    @Id           INT,
    @Name         NVARCHAR (255),
    @Information  NVARCHAR (255),
    @ContactID    INT,
    @LocationID   INT
AS
	update [Companies]
	set [Name] = @Name,	   
		[Information] = @Information,
		[ContactID] = @ContactID, 
		[LocationID] = @LocationID	   
	WHERE [id] = @Id