CREATE PROCEDURE [HR_DataBase_VSDB].[GetByID]
	@Id int
AS
	select * from [SkillNames]
    WHERE [id]=@Id
