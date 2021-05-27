CREATE TABLE [Positions] (
	ID int PRIMARY KEY NOT NULL,
	Name nvarchar(255) NOT NULL,
	ProjectID int,
	UNIQUE(ID)
)
GO
ALTER TABLE [Positions]
WITH CHECK ADD CONSTRAINT FK_Positions_Projects FOREIGN KEY(ProjectID)
REFERENCES Projects (ID)