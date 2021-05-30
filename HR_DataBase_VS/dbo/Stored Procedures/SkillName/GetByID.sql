CREATE PROCEDURE [dbo].[GetByID]
	@Id int
AS
	select * from [SkillName]
    WHERE ID=@Id
