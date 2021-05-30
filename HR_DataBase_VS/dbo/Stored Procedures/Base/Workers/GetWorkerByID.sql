CREATE PROCEDURE [dbo].[GetWorkerByID]
@WorkersID int
AS 
 SELECT *
 FROM [Workers] as W
 WHERE W.[ID]=@WorkersID