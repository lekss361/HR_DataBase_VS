CREATE PROCEDURE [dbo].[DeleteAll]
AS
	delete from [Comments]
	DBCC CHECKIDENT ([Comments], RESEED, 0)
