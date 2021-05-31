CREATE PROCEDURE [HR_DataBase_VSDB].[GetSkillTypeByID]
@SkillTypeID int
AS 
 SELECT *
 FROM [SkillTypes] 
 WHERE [id]=@SkillTypeID