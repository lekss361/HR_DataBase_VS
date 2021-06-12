CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateSkillNameByID]
	@Id				int,
	@Skill			nvarchar (255),
	@SkillTypeID	int
AS
    UPDATE [SkillNames]
    SET
    [Skill] =        @Skill,
    [SkillTypeID] =  @SkillTypeID
    WHERE [Id] = @Id