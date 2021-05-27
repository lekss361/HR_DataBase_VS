CREATE TABLE [Divisions_Directions] (
	DirectionID int NOT NULL,
	DivisionID int
)
GO
ALTER TABLE [Divisions_Directions]
WITH CHECK ADD CONSTRAINT FK_DivisionsDirections_Directions FOREIGN KEY(DirectionID)
REFERENCES Directions (ID)
GO
ALTER TABLE [Divisions_Directions]
WITH CHECK ADD CONSTRAINT FK_DivisionsDirections_Divisions FOREIGN KEY(DivisionID)
REFERENCES Divisions (ID)