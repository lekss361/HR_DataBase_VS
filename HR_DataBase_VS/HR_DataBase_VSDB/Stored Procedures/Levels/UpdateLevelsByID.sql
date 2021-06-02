CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateLevelsByID]
    @Id             INT             ,
    @Name         NVARCHAR (255) 
            
AS
	update [Levels]
	set [Name]=@Name	   
	    
	WHERE [id]=@Id