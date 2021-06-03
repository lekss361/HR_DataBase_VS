CREATE PROCEDURE [HR_DataBase_VSDB].[GetContactsByID]
	@id int
AS 
 SELECT *
 FROM [Contacts] 
 WHERE [id]=@id