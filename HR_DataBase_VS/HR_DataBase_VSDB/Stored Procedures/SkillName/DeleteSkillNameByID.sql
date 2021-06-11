CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteSkillNameByID]
	@id INT
AS
	DELETE from [SkillNames] 
	WHERE [id] = @id