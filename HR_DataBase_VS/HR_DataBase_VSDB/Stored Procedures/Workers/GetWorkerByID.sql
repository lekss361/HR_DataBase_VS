CREATE PROCEDURE [HR_DataBase_VSDB].[GetWorkerByID]
@WorkersID int
AS 
 SELECT *
 FROM [Workers] as W
 WHERE W.[id]=@WorkersID