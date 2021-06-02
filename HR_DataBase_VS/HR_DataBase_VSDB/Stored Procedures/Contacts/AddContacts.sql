CREATE PROCEDURE [HR_DataBase_VSDB].[AddContacts]
	@id				int,
	@Phone			decimal (30),
	@Email			nvarchar (255),
	@Information	nvarchar (255)
	
AS
	INSERT INTO  [Contacts]([id], [Phone],[Email],[Information])
	VALUES (@id, @Phone, @Email,@Information )
