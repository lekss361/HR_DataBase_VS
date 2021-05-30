CREATE PROCEDURE [dbo].[DeleteByID]
	@id INT
AS
	DELETE from [SkillName] 
	WHERE id = @id