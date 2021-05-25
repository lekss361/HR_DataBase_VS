CREATE TABLE [Requiries] (
	PositionID int NOT NULL,
	SkillMapID int NOT NULL
)
GO
/* Таблица Requiries */
ALTER TABLE [Requiries]
WITH CHECK ADD CONSTRAINT FK_Requiries_SkillMaps FOREIGN KEY(SkillMapID)
REFERENCES SkillMaps(ID)
GO
ALTER TABLE [Requiries]
WITH CHECK ADD CONSTRAINT FK_Requiries_Positions FOREIGN KEY(PositionID)
REFERENCES Positions(ID)