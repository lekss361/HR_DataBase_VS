CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateWorkersByID]
	@Id int,
    @FirstName  NVARCHAR (255) ,
    @LastName   NVARCHAR (255) ,
    @BirthDay   DATE           ,
    @Education  NVARCHAR (255) ,
    @ContactID  INT            ,
    @LocationID INT            ,
    @Sex        NVARCHAR (255) ,
    @Hobby      NVARCHAR (255) 
AS
	update [Workers]
	set [FirstName]=@FirstName,
	    [LastName]=@LastName,
	    [BirthDay]=@BirthDay,
	    [Education]=@Education,
	    [ContactID]=@ContactID,
	    [LocationID]=@LocationID,
	    [Sex]=@Sex,
	    [Hobby]=@Hobby
	where [id]=@Id