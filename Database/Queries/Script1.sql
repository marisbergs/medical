IF EXISTS (SELECT * FROM sysobjects WHERE type = 'U' AND name = 'Table_Name')
	BEGIN
		DROP  Table Table_Name
	END
GO

CREATE TABLE Table_Name
(
   


)
GO

/*
GRANT SELECT ON Table_Name TO PUBLIC

GO
*/
