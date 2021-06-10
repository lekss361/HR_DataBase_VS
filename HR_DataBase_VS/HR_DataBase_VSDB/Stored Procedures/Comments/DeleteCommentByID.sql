CREATE PROCEDURE [HR_DataBase_VSDB].[DeleteCommentByID]
	@id INT
AS
	DELETE from [Comments] 
	WHERE id = @id