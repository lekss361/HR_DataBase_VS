CREATE PROCEDURE [dbo].[AddWorker]
    @FirstName  NVARCHAR (255) NOT NULL,
    @LastName   NVARCHAR (255) NOT NULL,
    @BirthDay   DATE           NOT NULL,
    @Education  NVARCHAR (255) NOT NULL,
    @Hobby      NVARCHAR (255) NULL
AS 
INSERT INTO [Workers] 
VALUES(@FirstName, @LastName, @BirthDay, @Education, @Hobby)