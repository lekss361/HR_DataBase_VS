CREATE PROCEDURE [HR_DataBase_VSDB].[GetAllWorkerInformationByID]
	@Id int
AS
 SELECT
 W.id, W.FirstName,W.LastName,W.Patronymic,W.BirthDay,W.Sex,W.Education,W.Hobby,W.ContactID,W.LocationID,W.StatusID,W.PositionID,W.DivisionID,
 C.id as ContactID, C.Phone,C.Email,C.Information as ContactInformation,
 L.Country,L.City,L.Street,L.ApartmentNumber,L.HouseNumber,L.LocationIndex,
 S.id as StatusID, S.Name as StatusName,
 P.id as PositionID, P.Name as PositionName,
 D.id as DivisionID, D.Name as DivisionName,
 Com.Name as CompanyName
 FROM [HR_DataBase_VSDB].[Workers] as W
 left join [HR_DataBase_VSDB].[Contacts] as C on C.id=W.ContactID
 left join [HR_DataBase_VSDB].[Locations] as L on L.id=W.LocationID
 left join [HR_DataBase_VSDB].[Statuses] as S on S.id=W.StatusID
 left join [HR_DataBase_VSDB].[Positions] as P on P.id=W.PositionID
 left join [HR_DataBase_VSDB].[Divisions] as D on D.id=W.DivisionID
 left join [HR_DataBase_VSDB].[Companies] as Com on Com.id=D.CompanyID
 WHERE (W.id = @Id)