CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteAllContacts]
AS
	delete from [Contacts]
	DBCC CHECKIDENT ([Contacts] , RESEED, 0)