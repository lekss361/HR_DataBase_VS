CREATE PROCEDURE [HR_DataBase_VSDB].[GetAllWorkerSkillMapsBySkillID]
	@WorkersID int
AS 
 SELECT *
 FROM [WorkersSkillMaps]
 WHERE [WorkerID] = @WorkersID