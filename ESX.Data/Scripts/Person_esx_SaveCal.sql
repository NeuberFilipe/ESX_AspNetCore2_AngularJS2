CREATE PROCEDURE Person_esx_saveCal @Id        UNIQUEIDENTIFIER ,
                                   @Name      NVARCHAR(150),
                                   @Email     NVARCHAR(150),
                                   @Salary    DECIMAL(18, 0),
                                   @SalaryLiq DECIMAL(18, 0),
                                   @SalaryBru DECIMAL(18, 0),
                                   @Tax       DECIMAL(18, 0),
                                   @DateCalc  DATETIME2(7)
AS
  BEGIN
      INSERT INTO
      person 
             ([Id],
			 [name],
             [email],
             [salary] ,
             [salaryliq],
             [salarybru],
             [tax],
             [datecalc])
			 VALUES 
			 (@Id,
             @Name,
             @Email,
             @Salary,
             @SalaryLiq,
             @SalaryBru,
             @Tax,
             @DateCalc)
  END 
