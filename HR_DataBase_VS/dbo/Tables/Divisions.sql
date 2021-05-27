CREATE TABLE [Divisions] (
	ID int PRIMARY KEY NOT NULL,
	Name nvarchar(255) NOT NULL,
	ContactID int NOT NULL,
	BranchOfficeID int NOT NULL,
	UNIQUE(ID)
)
GO
ALTER TABLE [Divisions]
WITH CHECK ADD CONSTRAINT FK_Divisions_Contacts FOREIGN KEY(ContactID)
REFERENCES Contacts (ID)
GO
ALTER TABLE [Divisions]
WITH CHECK ADD CONSTRAINT FK_Divisions_BranchOffices FOREIGN KEY(BranchOfficeID)
REFERENCES BranchOffices (ID)