CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteWorkersSkillMapByID]
	@WorkerID int,
    @SkillMapID int
AS
	DELETE from [WorkersSkillMaps] 
	WHERE [WorkersID] = @WorkerID
	--WHERE [SkillsMapsID] = @SkillMapID 
