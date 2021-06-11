CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateContactsByID]
	@Id				int,
	@Phone			nvarchar (15),
	@Email			nvarchar (255),
	@Information	nvarchar (255)
AS
 INSERT  [Contacts]
        ([Phone], [Email], [Information])
    OUTPUT
    INSERTED.[id],
    INSERTED.[Phone],
    INSERTED.[Email],
    INSERTED.[Information]
  VALUES ( @Phone, @Email, @Information)