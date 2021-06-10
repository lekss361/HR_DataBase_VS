CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewWorkersSkillMap]
    @WorkerID int,
    @SkillMapsID int
AS
	INSERT INTO [WorkersSkillMaps]
        ([WorkersID],[SkillsMapsID])
	VALUES (@WorkerID, @SkillMapsID)
	SELECT @@IDENTITY