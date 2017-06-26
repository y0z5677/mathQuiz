
drop table [dbo].[MathQuiz]
go
CREATE TABLE [dbo].[MathQuiz](
	[id] [int] IDENTITY(1,1) Primary key NOT NULL,
	[operand1] [decimal](18, 0) NOT NULL,
	[operand2] [decimal](18, 0) NOT NULL,
	[operator] [char](1) NOT NULL,
	[correctAnswer] [decimal](18, 0) NOT NULL,
	[difficultLevel] [int] NOT NULL,
	[answer] [decimal](18, 0) NULL
)

GO
insert into  [Examples].[dbo].[MathQuiz]
  (operand1, operand2, operator, correctAnswer, difficultLevel)
values (19, 19, '+', 38, 1), 
		(61, 10, '-', 51, 2),
		(51, 10, '*', 510, 3),
		(1, 1, '*', 1, 3),
		(110, 2, '+', 112, 1), 
		(51, 100, '-', 5100, 2)




