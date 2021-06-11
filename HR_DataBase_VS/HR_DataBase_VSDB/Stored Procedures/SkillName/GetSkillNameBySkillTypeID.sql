CREATE PROCEDURE [HR_DataBase_VSDB].[GetSkillNameBySkillTypeID]
	@SkillTypeID int
AS
	select * from [SkillNames]
    WHERE [SkillTypeID] = @SkillTypeID