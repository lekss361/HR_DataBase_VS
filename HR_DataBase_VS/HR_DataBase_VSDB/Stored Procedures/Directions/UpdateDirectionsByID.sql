CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateDirectionsByID]
    @Id             INT             ,
    @Name         NVARCHAR (255) 
            
AS
	update [Directions]
	set [Name]=@Name	   
	    
	WHERE [id]=@Id