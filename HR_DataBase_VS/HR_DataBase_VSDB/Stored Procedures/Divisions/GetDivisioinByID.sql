CREATE PROCEDURE [HR_DataBASe_VSDB].[GetDivisionByID]
	@Id int
AS
	SELECT 
Com.id AS CompanyID,Com.Name AS CompanyName,
Div.Name, Div.Information,
Dir.Id AS DirectionId, Dir.Name AS DirectionName,
C.Id AS ContactID, C.Phone, C.Email, C.Information AS ContactInformation,
L.Id AS LocationID, L.Country, L.City, L.ApartmentNumber,L.HouseNumber,L.LocationIndex,L.Street

FROM  [HR_DataBASe_VSDB].[Divisions] AS Div
LEFT JOIN [HR_DataBASe_VSDB].[Directions] AS Dir on(Div.DirectionID=Dir.id)
LEFT JOIN [HR_DataBASe_VSDB].[Locations] AS L on(Div.LocationID=L.id)
LEFT JOIN [HR_DataBASe_VSDB].[Contacts] AS C on(Div.ContactID=C.id)
LEFT JOIN [HR_DataBASe_VSDB].[Companies] AS Com on(Div.CompanyID=Com.id)
WHERE(Div.id =@Id)