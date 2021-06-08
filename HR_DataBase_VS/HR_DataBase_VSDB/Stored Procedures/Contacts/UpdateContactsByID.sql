CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateContactsByID]
	@Id				int,
	@Phone			nvarchar (15),
	@Email			nvarchar (255),
	@Information	nvarchar (255)
	
AS
UPDATE [Contacts]
	SET [Phone] = @Phone,
		[Email] = @Email,
		[Information] = @Information

	WHERE [id] = @Id