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
	 INSERT  [Workers]
        ([FirstName], [LastName], [BirthDay], [Education], [ContactID], [LocationID], [Sex], [Hobby])
    OUTPUT
    INSERTED.[FirstName],
    INSERTED.[LastName],
    INSERTED.[BirthDay],
    INSERTED.[Education],
    INSERTED.[ContactID],
    INSERTED.[LocationID],
    INSERTED.[Sex],
    INSERTED.[Hobby]
  VALUES ( @FirstName, @LastName, @BirthDay, @Education, @ContactID, @LocationID, @Sex, @Hobby)