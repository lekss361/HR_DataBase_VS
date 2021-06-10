CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateSkillTypeByID]
	@Id			int,
    @Name		NVARCHAR (255) 
AS
	update [SkillTypes]
	set [Name] = @Name
	WHERE [id] = @Id