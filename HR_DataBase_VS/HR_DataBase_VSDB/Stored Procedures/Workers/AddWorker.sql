CREATE PROCEDURE [HR_DataBase_VSDB].[AddWorker]
    @FirstName      NVARCHAR (50) ,
    @LastName       NVARCHAR (50) ,
    @Patronymic     NVARCHAR (50) ,
    @BirthDay       DATE          ,
    @Education      NVARCHAR (100),
    @Sex            NVARCHAR (20) ,
    @StatusID       INT,
    @Hobby          NVARCHAR (50) = null,
    @ContactID      INT  = null,
    @LocationID     INT  = null,
    @PositionID     INT  = null,
    @DivisionID     INT  = null
AS
    INSERT INTO [Workers] (FirstName, LastName, Patronymic  , BirthDay, Education, Sex, StatusID, Hobby, ContactID, LocationID, PositionID, DivisionID)
    VALUES(@FirstName, @LastName, @Patronymic, @BirthDay, @Education, @Sex, @StatusID, @Hobby, @ContactID, @LocationID, @PositionID, @DivisionID)
	SELECT @@IDENTITY