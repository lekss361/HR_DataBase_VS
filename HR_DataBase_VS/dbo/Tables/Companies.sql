CREATE TABLE [Companies] (
	ID int PRIMARY KEY NOT NULL,
	Name nvarchar(255) NOT NULL,
	Iformation nvarchar(255),
	UNIQUE(ID)
)