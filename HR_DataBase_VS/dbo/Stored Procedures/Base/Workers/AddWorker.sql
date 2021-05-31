CREATE PROCEDURE [HR_DataBase_VSDB].[AddWorker]
    @FirstName  NVARCHAR (255) NOT NULL,
    @LastName   NVARCHAR (255) NOT NULL,
    @BirthDay   DATE           NOT NULL,
    @Education  NVARCHAR (255) NOT NULL,
    @Hobby      NVARCHAR (255) NULL
AS 
INSERT INTO [Workers] (FirstName, LastName, BirthDay, Education, Hobby)
VALUES(@FirstName, @LastName, @BirthDay, @Education, @Hobby)