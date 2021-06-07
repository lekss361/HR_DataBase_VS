CREATE PROCEDURE [HR_DataBase_VSDB].[UpdateLocationByID]
    @Id              INT             ,
    @LocationIndex   INT            ,
    @Country         NVARCHAR (255) ,
    @City            NVARCHAR (255) ,
    @Street          NVARCHAR (255) ,
    @HouseNumber     INT            ,
    @ApartmentNumber INT            
AS
begin if (@LocationIndex is not null) begin
	update [Locations]
	set [LocationIndex]=@LocationIndex WHERE [id]=@Id end end

begin if (@LocationIndex is not null) begin
	update [Locations]
	set [Country]=@Country WHERE [id]=@Id end end

begin if (@LocationIndex is not null) begin
	update [Locations]
	set [City]=@City WHERE [id]=@Id end end

begin if (@LocationIndex is not null) begin
	update [Locations]
	set [Street]=@Street WHERE [id]=@Id end end

begin if (@LocationIndex is not null) begin
	update [Locations]
	set [HouseNumber]=@HouseNumber WHERE [id]=@Id end end

begin if (@LocationIndex is not null) begin
	update [Locations]
	set [ApartmentNumber]=@ApartmentNumber WHERE [id]=@Id end end