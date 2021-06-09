CREATE PROCEDURE [HR_DataBase_VSDB].[AddWorker]
    @FirstName      NVARCHAR (255) ,
    @LastName       NVARCHAR (255) ,
    @BirthDay       DATE           ,
    @Education      NVARCHAR (255) ,
    @Sex            NVARCHAR (255) ,
    @Hobby          NVARCHAR (255) = null,
    @ContactID      INT  = null,
    @LocationID     INT  = null
AS 
INSERT INTO [Workers] (FirstName, LastName, BirthDay, Education, Sex, Hobby, ContactID, LocationID)
VALUES(@FirstName, @LastName, @BirthDay, @Education, @Sex, @Hobby, @ContactID, @LocationID)