﻿CREATE TABLE [dbo].[Livro]
(
	[Codigo] INT NOT NULL CONSTRAINT [PK LIVRO] PRIMARY KEY IDENTITY, 
    [Cod_Autor] INT NOT NULL CONSTRAINT [FK LIVRO_AUTOR] REFERENCES AUTOR(CODIGO), 
    [Nome] VARCHAR(50) NOT NULL, 
    [Genero] VARCHAR(50) NOT NULL, 
    [Dt_Publicacao] DATE NOT NULL, 
    [Paginas] INT NOT NULL, 
    [Valor] FLOAT NOT NULL
)
