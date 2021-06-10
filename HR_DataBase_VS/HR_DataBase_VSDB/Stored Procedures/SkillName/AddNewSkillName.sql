CREATE PROCEDURE [HR_DataBase_VSDB].[AddNewSkillName]
	@Skill			nvarchar (255),
	@SkillTypeID	int
AS
	INSERT [SkillNames]([Skill], [SkillTypeID])
	VALUES (@Skill, @SkillTypeID)
	SELECT @@IDENTITY