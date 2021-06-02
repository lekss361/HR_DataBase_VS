CREATE PROCEDURE [HR_DataBase_VSDB].[GetStatusesByID]
@StatusesID int
AS 
 SELECT *
 FROM [Statuses] 
 WHERE [id]=@StatusesID