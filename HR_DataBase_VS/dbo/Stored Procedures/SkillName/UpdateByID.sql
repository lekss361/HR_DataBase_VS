CREATE PROCEDURE [dbo].[UpdateByID]
	@Id int,
	@Skill  nvarchar (255),
	@SkillTypeID int
AS
	update  [dbo].[SkillName]
	set [Skill]=@Skill,
	[SkillTypeID]=@SkillTypeID
	where id=@id
