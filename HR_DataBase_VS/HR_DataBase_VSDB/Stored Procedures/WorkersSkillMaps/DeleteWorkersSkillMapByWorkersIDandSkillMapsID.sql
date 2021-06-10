CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteWorkersSkillMapByWorkersIDandSkillMapsID]
	@WorkerID int,
    @SkillMapsID int
AS
	Delete from [WorkersSkillMaps]
    WHERE [WorkerID] = @WorkerID and [SkillsMapID] = @SkillMapsID