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
ALTER TABLE [Workers]
WITH CHECK ADD CONSTRAINT FK_Workers_Locations FOREIGN KEY(LocationID)
REFERENCES Locations (ID)
GO
ALTER TABLE [Workers]
WITH CHECK ADD CONSTRAINT FK_Workers_Contacts FOREIGN KEY(ContactID)
REFERENCES Contacts (ID)