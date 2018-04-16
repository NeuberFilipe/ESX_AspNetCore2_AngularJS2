CREATE PROCEDURE Person_esx_create @Id    UNIQUEIDENTIFIER ,
                                   @Name      NVARCHAR(150),
                                   @Email     NVARCHAR(150),
                                   @Salary    DECIMAL(18, 0),
                                   @SalaryLiq DECIMAL(18, 0),
                                   @SalaryBru DECIMAL(18, 0),
                                   @Tax       DECIMAL(18, 0),
                                   @DateCalc  DATETIME2(7)
AS
  BEGIN
	   SET NOCOUNT ON;
	     INSERT INTO 
         person(
		     [id],
             [name], 
             [email],
             [salary],
             [salaryliq],
             [salarybru],
             [tax],
             [datecalc])
			 OUTPUT inserted.Id
			 VALUES(@Id, @Name, @Email,@Salary, @SalaryLiq, @SalaryBru, @Tax, @DateCalc)
  END 

