CREATE PROCEDURE [HR_DataBase_VSDB].[CompanyWithForeignKeyValueById]
@id int 
AS
SELECT
Com.id, Com.[Name], Com.[Information],
Con.id AS ContactID,Con.Phone, Con.Email, Con.Information as ContactInformation,
L.id AS LocationID, L.City, L.Street, L.Country, L.ApartmentNumber, L.LocationIndex, L.HouseNumber
FROM [HR_DataBase_VSDB].[Companies] as Com
left join [HR_DataBase_VSDB].[Contacts] as Con on (Com.ContactID=Con.id)
left join [HR_DataBase_VSDB].[Locations] as L on Com.LocationID=L.[id]
WHERE (Com.id = @id)