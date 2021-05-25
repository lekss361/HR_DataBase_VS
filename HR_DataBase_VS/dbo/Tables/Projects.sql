CREATE TABLE [Projects] (
	ID int PRIMARY KEY NOT NULL,
	Name nvarchar(255) NOT NULL,
	DivisionID int,
	UNIQUE(ID)
)
GO
ALTER TABLE [Projects]
WITH CHECK ADD CONSTRAINT FK_Projects_Divisions FOREIGN KEY(DivisionID)
REFERENCES Divisions (ID)