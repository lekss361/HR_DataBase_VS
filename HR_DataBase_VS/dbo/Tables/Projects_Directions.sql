CREATE TABLE [Projects_Directions] (
	DirectionID int NOT NULL,
	ProjectID int NOT NULL
)
GO
ALTER TABLE [Projects_Directions]
WITH CHECK ADD CONSTRAINT FK_ProjectsDirections_Directions FOREIGN KEY(DirectionID)
REFERENCES Directions(ID)
GO
ALTER TABLE [Projects_Directions]
WITH CHECK ADD CONSTRAINT FK_ProjectsDirections_Projects FOREIGN KEY(ProjectID)
REFERENCES Projects(ID)