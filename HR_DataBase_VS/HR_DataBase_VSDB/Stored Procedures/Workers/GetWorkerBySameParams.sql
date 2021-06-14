CREATE PROCEDURE [HR_DataBase_VSDB].[GetWorkerBySameParams]
    @FirstName  NVARCHAR (50),
    @LastName   NVARCHAR (50),
    @Patronymic NVARCHAR (50),
    @BirthDay   DATE,
    @Sex        NVARCHAR (20),
    @StatusID   INT,
    @Education  NVARCHAR (100),
    @ContactID  INT,
    @LocationID INT,
    @Hobby      NVARCHAR (50),
    @PositionID INT,
    @DivisionID INT
AS
 SELECT W.id
 FROM [HR_DataBase_VSDB].[Workers] as W
 WHERE ([FirstName] = @FirstName
     OR [LastName] = @LastName
     OR [Patronymic] = @Patronymic
     OR [BirthDay] = @BirthDay
     OR [Sex] = @Sex
     OR [StatusID] = @StatusID
     OR [Education] = @Education
     OR [ContactID] = @ContactID
     OR [LocationID] = @LocationID
     OR [Hobby] = @Hobby
     OR [PositionID] = @PositionID
     OR [DivisionID] = @DivisionID)