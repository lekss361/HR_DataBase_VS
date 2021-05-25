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