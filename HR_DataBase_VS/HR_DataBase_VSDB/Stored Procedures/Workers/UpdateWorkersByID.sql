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
	 INSERT  [Workers]
        ([FirstName], [LastName], [Patronymic], [BirthDay], [Education], [ContactID], [LocationID], [Sex], [StatusID], [Hobby], [PositionID], [DivisionID])
    OUTPUT
    INSERTED.[Id],
    INSERTED.[FirstName],
    INSERTED.[LastName],
    INSERTED.[Patronymic],
    INSERTED.[BirthDay],
    INSERTED.[Education],
    INSERTED.[ContactID],
    INSERTED.[LocationID],
    INSERTED.[Sex],
    INSERTED.[StatusID],
    INSERTED.[Hobby],
    INSERTED.[PositionID],
    INSERTED.[DivisionID]
  VALUES ( @FirstName, @LastName, @Patronymic, @BirthDay, @Education, @ContactID, @LocationID, @Sex, @StatusID, @Hobby, @PositionID, @DivisionID)