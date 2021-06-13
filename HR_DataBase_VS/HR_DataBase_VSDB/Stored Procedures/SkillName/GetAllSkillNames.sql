CREATE PROCEDURE [HR_DataBase_VSDB].[GetAllSkillNames]
AS
	select Sn.[id], Sn.[SkillTypeID], Sn.[Skill] as SkillName, St.[Name] as SkillType
	from [SkillNames] as Sn
	left join [SkillTypes] as St On Sn.SkillTypeID=St.id