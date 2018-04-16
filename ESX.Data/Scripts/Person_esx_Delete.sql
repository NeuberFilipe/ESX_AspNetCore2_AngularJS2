CREATE PROCEDURE Person_esx_delete @Id UNIQUEIDENTIFIER 
AS
  BEGIN
      DELETE
      FROM   person
      WHERE  [id] = @Id
             
  END 
