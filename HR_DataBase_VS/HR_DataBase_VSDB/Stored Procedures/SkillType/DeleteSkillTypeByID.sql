CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteSkillTypeByID]
	@Id INT
AS
	DELETE from [SkillTypes] 
	WHERE [id] = @Id
