/* это были нижниие таблицы */

CREATE TABLE [WorkersHistory] (
	WorkerID int NOT NULL,
	DateChanged datetime NOT NULL,
	WorkersSkillMapID int NOT NULL,
	Information nvarchar(255) NOT NULL,
	LocationID int NOT NULL,
	EmploymentID int NOT NULL
)
GO
/* это были нижниие таблицы */

ALTER TABLE [WorkersHistory]
WITH CHECK ADD CONSTRAINT FK_WorkersHistory_Workers FOREIGN KEY(WorkerID)
REFERENCES Workers (ID)