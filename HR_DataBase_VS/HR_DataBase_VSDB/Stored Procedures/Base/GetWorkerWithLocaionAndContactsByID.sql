CREATE PROCEDURE [HR_DataBase_VSDB].[GetWorkerWithLocaionAndContactsByID]
@WorkersID int
as 
SELECT W.[FirstName], W.[LastName], W.[BirthDay], W.[Education], W.[Sex], W.[Hobby], 
L.[Country], L.[City], L.[Street], L.[HouseNumber], L.[ApartmentNumber], L.[LocationIndex],
Con.[Phone], Con.[Email], Con.[Information]
FROM [Workers] as W
left join [Locations] as L on W.LocationID=L.id
left join [Contacts] as Con on W.ContactID=Con.id
WHERE W.[id]=@WorkersID
