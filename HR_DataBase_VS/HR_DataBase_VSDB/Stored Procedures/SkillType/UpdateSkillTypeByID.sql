CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateSkillTypeByID]
	@Id			int,
    @Name		NVARCHAR (255) 
AS
    UPDATE [SkillTypes]
    SET
    [Name] =   @Name
    WHERE [Id] = @Id