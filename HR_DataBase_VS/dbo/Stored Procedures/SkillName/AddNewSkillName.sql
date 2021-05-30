CREATE PROCEDURE [dbo].[AddNewSkillName]
	@Skill  nvarchar (255),
	@SkillTypeID int
AS
	INSERT [SkillName]([Skill],[SkillTypeID])
	VALUES (@Skill,@SkillTypeID)
