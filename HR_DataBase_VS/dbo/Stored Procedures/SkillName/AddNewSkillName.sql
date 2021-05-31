CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewSkillName]
	@Skill  nvarchar (255),
	@SkillTypeID int
AS
	INSERT [SkillName]([Skill],[SkillTypeID])
	VALUES (@Skill,@SkillTypeID)
