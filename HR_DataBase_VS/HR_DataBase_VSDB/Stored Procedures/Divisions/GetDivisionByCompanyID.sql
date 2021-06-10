CREATE PROCEDURE [HR_DataBase_VSDB].[GetDivisionByCompanyID]
	
	@CompanyID int 
AS
SELECT Div.Name, Dir.Name as DirectionName, C.Phone, C.Email, L.Country, L.City
FROM  [HR_DataBase_VSDB].[Divisions] as Div
LEFT JOIN [HR_DataBase_VSDB].[Directions] as Dir on(Div.DirectionID=Dir.id)
LEFT JOIN [HR_DataBase_VSDB].[Locations] as L on(Div.LocationID=L.id)
LEFT JOIN [HR_DataBase_VSDB].[Contacts] as C on(Div.ContactID=C.id)
WHERE(Div.CompanyID =@CompanyID)
