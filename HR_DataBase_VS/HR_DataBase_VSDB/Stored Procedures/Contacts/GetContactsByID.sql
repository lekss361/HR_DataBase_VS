CREATE PROCEDURE [HR_DataBase_VSDB].[GetContactsByID]
	@id int
AS 
 SELECT *
 FROM [HR_DataBase_VSDB].[Contacts] 
 WHERE [id]=@id