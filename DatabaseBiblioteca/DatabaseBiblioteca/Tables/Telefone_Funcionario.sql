﻿CREATE TABLE [dbo].[Telefone_Funcionario]
(
	[Cod_Funcionario] INT NOT NULL 
	CONSTRAINT [FK TELEFONE_FUNCIONARIO / FUNCIONARIO] REFERENCES FUNCIONARIO(CODIGO), 
    [Telefone] VARCHAR(16) NOT NULL, 
    CONSTRAINT [PK TELEFONE_FUNCIONARIO] PRIMARY KEY ([Cod_Funcionario], [Telefone])
)