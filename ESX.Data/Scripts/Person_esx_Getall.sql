CREATE PROCEDURE Person_esx_getall @Id        UNIQUEIDENTIFIER = NULL,
                                   @Name      NVARCHAR(150) = NULL,
                                   @Email     NVARCHAR(150) = NULL,
                                   @Salary    DECIMAL(18, 0) = NULL,
                                   @SalaryLiq DECIMAL(18, 0) = NULL,
                                   @SalaryBru DECIMAL(18, 0) = NULL,
                                   @Tax       DECIMAL(18, 0) = NULL,
                                   @DateCalc  DATETIME2(7) = NULL
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
      WHERE  [id] = Isnull(@Id, [id])
             AND [name] = Isnull(@Name, [name])
             AND [email] = Isnull(@Email, [email])
             AND [salary] = Isnull(@Salary, [salary])
             AND [salaryliq] = Isnull(@SalaryLiq, [salaryliq])
             AND [salarybru] = Isnull(@SalaryBru, [salarybru])
             AND [tax] = Isnull(@Tax, [tax])
             AND [datecalc] = Isnull(@DateCalc, [datecalc])
  END 