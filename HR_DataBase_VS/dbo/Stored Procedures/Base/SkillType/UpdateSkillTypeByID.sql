CREATE PROCEDURE [dbo].[UpdateSkillTypeByID]
	@ID int,
    @Name  NVARCHAR (255) NOT NULL
AS
	update  [dbo].[SkillType]
	set [Name]=@Name
	WHERE ID=@ID