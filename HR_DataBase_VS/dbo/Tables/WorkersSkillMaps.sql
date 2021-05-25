CREATE TABLE [WorkersSkillMaps] (
	WorkerID int NOT NULL,
	SkillMapID int NOT NULL
)
GO
ALTER TABLE [WorkersSkillMaps]
WITH CHECK ADD CONSTRAINT FK_WorkersSkillMaps_SkillMaps FOREIGN KEY(SkillMapID)
REFERENCES SkillMaps (ID)
GO
ALTER TABLE [WorkersSkillMapS]
WITH CHECK ADD CONSTRAINT FK_WorkersSkillMaps_Workers FOREIGN KEY(WorkerID)
REFERENCES Workers (ID)