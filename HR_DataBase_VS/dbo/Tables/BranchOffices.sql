CREATE TABLE [BranchOffices] (
	ID int PRIMARY KEY NOT NULL,
	Name nvarchar(255) NOT NULL,
	CompanyID int NOT NULL,
	LocationID int NOT NULL,
	ContactID int NOT NULL,
	UNIQUE(ID)
)
GO
ALTER TABLE [BranchOffices]
WITH CHECK ADD CONSTRAINT FK_BranchOffices_Companies FOREIGN KEY(CompanyID)
REFERENCES Companies (ID)
GO
ALTER TABLE [BranchOffices]
WITH CHECK ADD CONSTRAINT FK_BranchOffices_Location FOREIGN KEY(LocationID)
REFERENCES Locations (ID)
GO
ALTER TABLE [BranchOffices]
WITH CHECK ADD CONSTRAINT FK_BranchOffices_Contacts FOREIGN KEY(ContactID)
REFERENCES Contacts (ID)