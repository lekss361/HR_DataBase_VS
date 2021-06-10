CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateSkillNameByID]
	@Id				int,
	@Skill			nvarchar (255),
	@SkillTypeID	int
AS
	update [SkillNames]
	set [Skill] = @Skill,
	[SkillTypeID] = @SkillTypeID
	where [id] = @Id