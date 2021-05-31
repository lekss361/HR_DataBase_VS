CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateByID]
	@Id int,
	@Skill  nvarchar (255),
	@SkillTypeID int
AS
	update [SkillNames]
	set [Skill]=@Skill,
	[SkillTypeID]=@SkillTypeID
	where [id]=@Id
