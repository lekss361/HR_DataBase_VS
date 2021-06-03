CREATE PROCEDURE [HR_DataBase_VSDB].[GetAllWorkersSkillMapsBySkillID]
	@WorkersID int
AS 
 SELECT *
 FROM [WorkersSkillMaps]
 WHERE [WorkersID]=@WorkersID