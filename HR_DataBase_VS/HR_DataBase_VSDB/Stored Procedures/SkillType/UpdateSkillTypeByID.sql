CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateSkillTypeByID]
	@Id			int,
    @Name		NVARCHAR (255) 
AS
    INSERT  [SkillTypes]
        ([Name])
    OUTPUT
    INSERTED.[Id],
    INSERTED.[Name]
    VALUES ( @Name)