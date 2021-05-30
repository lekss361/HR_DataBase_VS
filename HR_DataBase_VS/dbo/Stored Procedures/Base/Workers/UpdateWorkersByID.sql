CREATE PROCEDURE [dbo].[UpdateWorkersByID]
	@ID int,
    @FirstName  NVARCHAR (255) NOT NULL,
    @LastName   NVARCHAR (255) NOT NULL,
    @BirthDay   DATE           NOT NULL,
    @Education  NVARCHAR (255) NOT NULL,
    @ContactID  INT            NULL,
    @LocationID INT            NULL,
    @Sex        NVARCHAR (255) NOT NULL,
    @Hobby      NVARCHAR (255) NULL
AS
	update  [dbo].[Workers]
	set [FirstName]=@FirstName,
	    [LastName]=@LastName,
	    [BirthDay]=@BirthDay,
	    [Education]=@Education,
	    [ContactID]=@ContactID,
	    [LocationID]=@LocationID,
	    [Sex]=@Sex,
	    [Hobby]=@Hobby
	where ID=@ID