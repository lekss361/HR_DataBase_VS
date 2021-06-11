CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateSkillNameByID]
	@Id				int,
	@Skill			nvarchar (255),
	@SkillTypeID	int
AS
    INSERT  [SkillNames]
        ([Skill], [SkillTypeID])
    OUTPUT
    INSERTED.[Id],
    INSERTED.[Skill],
    INSERTED.[SkillTypeID]
    VALUES (@Skill, @SkillTypeID)