CREATE PROCEDURE [dbo].[GetSkillTypeByID]
@SkillTypeID int
AS 
 SELECT *
 FROM [SkillType] 
 WHERE ID=@SkillTypeID