CREATE PROCEDURE [HR_DataBase_VSDB].[GetCompaniesWithContactAndLocation] as	
SELECT C.[Name], C.[Information], Con.Phone, Con.Email, L.City, L.Street, L.HouseNumber
FROM [Companies] as C
left join [Contacts] as Con on C.ContactID=Con.[id]
left join [Locations] as L on C.LocationID=L.[id]
