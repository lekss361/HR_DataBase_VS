CREATE PROCEDURE [HR_DataBase_VSDB].[GetAllWorkerSkillMapsByWorkersID]
	@SkillsMapsID int
AS 
 SELECT *
 FROM [WorkersSkillMaps]
 WHERE [SkillsMapID] = @SkillsMapsID