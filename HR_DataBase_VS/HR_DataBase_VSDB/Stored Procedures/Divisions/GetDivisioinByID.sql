CREATE PROCEDURE [HR_DataBase_VSDB].[GetDivisionByID]
	@Id int
AS
	SELECT 
Com.Name as CompanyName,
Div.Name, Div.Information,
Dir.Name as DirectionName,
C.Phone, C.Email, C.Information as ContactInformation,
L.Country, L.City, L.ApartmentNumber,L.HouseNumber,L.LocationIndex,L.Street

FROM  [HR_DataBase_VSDB].[Divisions] as Div
LEFT JOIN [HR_DataBase_VSDB].[Directions] as Dir on(Div.DirectionID=Dir.id)
LEFT JOIN [HR_DataBase_VSDB].[Locations] as L on(Div.LocationID=L.id)
LEFT JOIN [HR_DataBase_VSDB].[Contacts] as C on(Div.ContactID=C.id)
LEFT JOIN [HR_DataBase_VSDB].[Companies] as Com on(Div.CompanyID=Com.id)
WHERE(Div.id =@Id)