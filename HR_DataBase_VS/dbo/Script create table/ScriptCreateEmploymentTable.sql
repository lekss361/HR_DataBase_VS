CREATE TABLE [Employment] (
	WorkerID int NOT NULL,
	CompanyID int NOT NULL,
	DivisionID int NOT NULL,
	ProjectID int NOT NULL,
	PositionID int NOT NULL,
	StatusID int NOT NULL,
  CONSTRAINT [PK_EMPLOYMENT] PRIMARY KEY CLUSTERED
  (
  [WorkerID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO