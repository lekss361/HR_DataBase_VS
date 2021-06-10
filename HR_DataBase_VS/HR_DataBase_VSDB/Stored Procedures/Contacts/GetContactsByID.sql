CREATE PROCEDURE [HR_DataBase_VSDB].[GetContactsByID]
	@id int
AS 
 SELECT *
 FROM [HR_DataBase_VSDB].[Contacts] 
 WHERE [HR_DataBase_VSDB].[Contacts].[id]=@id