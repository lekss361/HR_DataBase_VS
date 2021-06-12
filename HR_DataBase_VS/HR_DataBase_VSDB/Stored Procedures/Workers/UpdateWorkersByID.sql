CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateWorkersByID]
	@Id         int,
    @FirstName  NVARCHAR (255) ,
    @LastName   NVARCHAR (255) ,
    @Patronymic NVARCHAR (50) ,
    @BirthDay   DATE           ,
    @Education  NVARCHAR (255) ,
    @ContactID  INT            ,
    @LocationID INT            ,
    @Sex        NVARCHAR (255) ,
    @StatusID   INT,
    @Hobby      NVARCHAR (255) ,
    @PositionID INT,
    @DivisionID INT
AS
    UPDATE [Workers]
    SET
    [FirstName] =   @FirstName,
    [LastName] =    @LastName,
    [Patronymic] =  @Patronymic,
    [BirthDay] =    @BirthDay,
    [Education] =   @Education,
    [ContactID] =   @ContactID,
    [LocationID] =  @LocationID,
    [Sex] =         @Sex,
    [StatusID] =    @StatusID,
    [Hobby] =       @Hobby,
    [PositionID] =  @PositionID,
    [DivisionID] =  @DivisionID
    WHERE [Id] = @Id