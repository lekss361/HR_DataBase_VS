CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteContactsByID]
	@id INT
AS
	DELETE from [Contacts] 
	WHERE [id] = @id
