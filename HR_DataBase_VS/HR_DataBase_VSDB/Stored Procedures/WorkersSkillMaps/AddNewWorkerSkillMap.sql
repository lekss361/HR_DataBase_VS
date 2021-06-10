CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewWorkerSkillMap]
    @WorkerID		int,
    @SkillMapsID	int
AS
	INSERT INTO [WorkersSkillMaps]
        ([WorkerID], [SkillsMapID])
	VALUES (@WorkerID, @SkillMapsID)
	SELECT @@IDENTITY