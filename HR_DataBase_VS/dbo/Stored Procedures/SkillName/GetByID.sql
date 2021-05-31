CREATE PROCEDURE [HR_DataBase_VSDB].[GetByID]
	@Id int
AS
	select * from [SkillName]
    WHERE ID=@Id
