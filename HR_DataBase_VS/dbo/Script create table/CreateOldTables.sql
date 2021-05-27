CREATE TABLE [WorkersSkillMaps] (
	WorkerID int NOT NULL,
	SkillMapID int NOT NULL
)
GO

CREATE TABLE [SkillMaps] (
	ID int PRIMARY KEY IDENTITY NOT NULL,
	SkillID int NOT NULL,
	LevelID int NOT NULL,
	UNIQUE(ID)
)
GO

CREATE TABLE [Levels] (
	ID int PRIMARY KEY IDENTITY NOT NULL,
	SkillID int NOT NULL,
	LevelName nvarchar(255) NOT NULL,
	UNIQUE(ID)
)
GO

CREATE TABLE [Skills] (
	ID int PRIMARY KEY IDENTITY NOT NULL,
	Name nvarchar(255) NOT NULL,
	UNIQUE(ID)
)
GO

/* это были нижниие таблицы */

CREATE TABLE [WorkersHistory] (
	WorkerID int NOT NULL,
	DateChanged datetime NOT NULL,
	WorkersSkillMapID int NOT NULL,
	Information nvarchar(255) NOT NULL,
	LocationID int NOT NULL,
	EmploymentID int NOT NULL
)
GO

CREATE TABLE [Workers] (
	ID int PRIMARY KEY IDENTITY NOT NULL,
	FirstName nvarchar(255) NOT NULL,
	LastName nvarchar(255) NOT NULL,
	LocationID int NOT NULL,
	ContactID int NOT NULL,
	Information nvarchar(255) NOT NULL,
	UNIQUE(ID)
)
GO

CREATE TABLE [Employment] (
	WorkerID int PRIMARY KEY NOT NULL,
	CompanyID int NOT NULL,
	DivisionID int NOT NULL,
	ProjectID int NOT NULL,
	PositionID int NOT NULL,
	StatusID int NOT NULL,
)
GO

CREATE TABLE [Requiries] (
	PositionID int NOT NULL,
	SkillMapID int NOT NULL
)
GO

CREATE TABLE [Positions] (
	ID int PRIMARY KEY NOT NULL,
	Name nvarchar(255) NOT NULL,
	ProjectID int,
	UNIQUE(ID)
)
GO



CREATE TABLE [Companies] (
	ID int PRIMARY KEY NOT NULL,
	Name nvarchar(255) NOT NULL,
	Iformation nvarchar(255),
	UNIQUE(ID)
)
GO

CREATE TABLE [BranchOffices] (
	ID int PRIMARY KEY NOT NULL,
	Name nvarchar(255) NOT NULL,
	CompanyID int NOT NULL,
	LocationID int NOT NULL,
	ContactID int NOT NULL,
	UNIQUE(ID)
)
GO

CREATE TABLE [Divisions] (
	ID int PRIMARY KEY NOT NULL,
	Name nvarchar(255) NOT NULL,
	ContactID int NOT NULL,
	BranchOfficeID int NOT NULL,
	UNIQUE(ID)
)
GO

CREATE TABLE [Projects] (
	ID int PRIMARY KEY NOT NULL,
	Name nvarchar(255) NOT NULL,
	DivisionID int,
	UNIQUE(ID)
)
GO

CREATE TABLE [Statuses] (
	ID int PRIMARY KEY NOT NULL,
	Name nvarchar(255) NOT NULL,
	UNIQUE(ID)
)
GO

CREATE TABLE [Locations] (
	ID int PRIMARY KEY NOT NULL,
	[Index] int NOT NULL,
	Country nvarchar(255) NOT NULL,
	City nvarchar(255) NOT NULL,
	Street nvarchar(255) NOT NULL,
	HouseNumber int NOT NULL,
	ApartmentNumber int,
	UNIQUE(ID)
)
GO

CREATE TABLE [Contacts] (
	ID int PRIMARY KEY NOT NULL,
	Phone decimal NOT NULL,
	Email nvarchar(255),
	Fax nvarchar(255),
	UNIQUE(ID)
)
GO

CREATE TABLE [Divisions_Directions] (
	DirectionID int NOT NULL,
	DivisionID int
)
GO

CREATE TABLE [Projects_Directions] (
	DirectionID int NOT NULL,
	ProjectID int NOT NULL
)
GO

CREATE TABLE [Directions] (
	ID int PRIMARY KEY NOT NULL,
	Name nvarchar(255) NOT NULL,
	UNIQUE(ID)
)
GO
