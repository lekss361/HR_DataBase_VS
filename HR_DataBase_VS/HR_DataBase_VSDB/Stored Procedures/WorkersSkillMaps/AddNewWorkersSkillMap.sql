CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewWorkersSkillMap]
    @WorkerID int,
    @SkillMapID int
AS
	INSERT INTO [WorkersSkillMaps]
        ([WorkersID],[SkillsMapsID])
	VALUES (@WorkerID, @SkillMapID)
