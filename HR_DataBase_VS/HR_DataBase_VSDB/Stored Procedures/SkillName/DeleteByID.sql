CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteByID]
	@id INT
AS
	DELETE from [SkillNames] 
	WHERE [id] = @id