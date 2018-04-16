CREATE PROCEDURE Person_esx_update @Id        UNIQUEIDENTIFIER ,
                                   @Name      NVARCHAR(150),
                                   @Email     NVARCHAR(150),
                                   @Salary    DECIMAL(18, 0),
                                   @SalaryLiq DECIMAL(18, 0),
                                   @SalaryBru DECIMAL(18, 0),
                                   @Tax       DECIMAL(18, 0),
                                   @DateCalc  DATETIME2(7)
AS
  BEGIN
      UPDATE
      person Set
             [name] = @Name,
             [email] =@Email,
             [salary] = @Salary,
             [salaryliq] = @SalaryLiq,
             [salarybru] = @SalaryBru,
             [tax] = @Tax,
             [datecalc] = @DateCalc
			 WHERE [Id] = @Id
  END 



