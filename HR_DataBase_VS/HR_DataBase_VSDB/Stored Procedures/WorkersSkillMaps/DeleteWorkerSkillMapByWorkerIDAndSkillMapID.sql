CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteWorkerSkillMapByWorkerIDAndSkillMapID]
	@WorkerID		int,
    @SkillMapsID	int
AS
	Delete from [WorkersSkillMaps]
    WHERE [WorkerID] = @WorkerID 
	and [SkillsMapID] = @SkillMapsID