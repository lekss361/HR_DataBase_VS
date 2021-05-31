CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteByID]
	@id INT
AS
	DELETE from [SkillName] 
	WHERE ID = @id