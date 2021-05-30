CREATE PROCEDURE [HR_DataBase].[DeleteSkillTypeByID]
	@id INT
AS
	DELETE from [SkillType] 
	WHERE ID = @id
