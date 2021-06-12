CREATE PROCEDURE [HR_DataBase_VSDB].[CompanyWithForeignKeyValueById]
@id int 
AS
SELECT C.[Name], C.[Information], Con.Phone, Con.Email, Con.Information as ContactInformation, L.City, L.Street, L.Country, L.ApartmentNumber, L.LocationIndex, L.HouseNumber
FROM [Companies] as C
left join [Contacts] as Con on C.ContactID=Con.[id]
left join [Locations] as L on C.LocationID=L.[id]
WHERE (C.id = @id)