CREATE PROCEDURE Person_esx_getbyId @Id        UNIQUEIDENTIFIER 
AS
  BEGIN
      SELECT [id],
             [name],
             [email],
             [salary],
             [salaryliq],
             [salarybru],
             [datecalc]
      FROM   person
      WHERE  [id] = @Id
             
  END 