CREATE TABLE [Employment] (
	WorkerID int PRIMARY KEY NOT NULL,
	CompanyID int NOT NULL,
	DivisionID int NOT NULL,
	ProjectID int NOT NULL,
	PositionID int NOT NULL,
	StatusID int NOT NULL,
)
GO
/* Таблица Employment */
ALTER TABLE [Employment]
WITH CHECK ADD CONSTRAINT FK_Employment_Workers FOREIGN KEY(WorkerID)
REFERENCES Workers (ID)
GO
ALTER TABLE [Employment]
WITH CHECK ADD CONSTRAINT FK_Employment_Companies FOREIGN KEY(CompanyID)
REFERENCES Companies (ID)
GO
ALTER TABLE [Employment]
WITH CHECK ADD CONSTRAINT FK_Employment_Divisions FOREIGN KEY(DivisionID)
REFERENCES Divisions (ID)
GO
ALTER TABLE [Employment]
WITH CHECK ADD CONSTRAINT FK_Employment_Projects FOREIGN KEY(ProjectID)
REFERENCES Projects (ID)
GO
ALTER TABLE [Employment]
WITH CHECK ADD CONSTRAINT FK_Employment_Positions FOREIGN KEY(PositionID)
REFERENCES Positions (ID)
GO
ALTER TABLE [Employment]
WITH CHECK ADD CONSTRAINT FK_Employment_Statuses FOREIGN KEY(StatusID)
REFERENCES Statuses (ID)