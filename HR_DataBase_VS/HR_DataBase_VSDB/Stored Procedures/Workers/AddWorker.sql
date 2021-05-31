CREATE PROCEDURE [HR_DataBase_VSDB].[AddWorker]
    @FirstName  NVARCHAR (255) ,
    @LastName   NVARCHAR (255) ,
    @BirthDay   DATE           ,
    @Education  NVARCHAR (255) ,
    @Hobby      NVARCHAR (255) 
AS 
INSERT INTO [Workers] (FirstName, LastName, BirthDay, Education, Hobby)
VALUES(@FirstName, @LastName, @BirthDay, @Education, @Hobby)