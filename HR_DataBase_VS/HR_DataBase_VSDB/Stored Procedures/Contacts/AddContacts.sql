CREATE PROCEDURE [HR_DataBase_VSDB].[AddContacts]
	@Phone			nvarchar (255),
	@Email			nvarchar (255),
	@Information	nvarchar (255)
	
AS
	INSERT INTO  [Contacts]([Phone],[Email],[Information])
	VALUES (@Phone, @Email,@Information )