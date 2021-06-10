CREATE PROCEDURE [HR_DataBase_VSDB].[GetAllWorkersSkillMapsByWorkersID]
	@SkillsMapsID int
AS 
 SELECT *
 FROM [WorkersSkillMaps]
 WHERE [SkillsMapID]=@SkillsMapsID