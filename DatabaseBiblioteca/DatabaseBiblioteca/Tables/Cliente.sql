﻿CREATE TABLE [dbo].[Cliente]
(
	[Cpf] VARCHAR(14) NOT NULL CONSTRAINT [PK CLIENTE] PRIMARY KEY, 
    [Nome] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL CONSTRAINT [UN CLIENTE_EMAIL] UNIQUE, 
    [Uf] VARCHAR(2) NOT NULL, 
    [Cep] VARCHAR(10) NOT NULL, 
    [Cidade] VARCHAR(50) NOT NULL, 
    [Bairro] VARCHAR(50) NOT NULL, 
    [Logradouro] VARCHAR(50) NOT NULL, 
    [Numero] VARCHAR(5) NOT NULL, 
    [Complemento] VARCHAR(50) NULL
)
