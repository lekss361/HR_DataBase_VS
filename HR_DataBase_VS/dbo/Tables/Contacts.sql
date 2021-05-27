CREATE TABLE [Contacts] (
	ID int PRIMARY KEY NOT NULL,
	Phone decimal NOT NULL,
	Email nvarchar(255),
	Fax nvarchar(255),
	UNIQUE(ID)
)