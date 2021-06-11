CREATE PROCEDURE [HR_DataBase_VSDB].[GetSkillNameByID]
	@Id int
AS
	select * from [SkillNames]
    WHERE [id] = @Id