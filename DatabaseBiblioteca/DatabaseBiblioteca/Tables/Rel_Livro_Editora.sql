﻿CREATE TABLE [dbo].[Rel_Livro_Editora]
(
	[Cod_Livro] INT NOT NULL
        CONSTRAINT [FK REL_LIVRO_EDITORA / LIVRO] REFERENCES LIVRO(CODIGO), 
    [Cod_Editora] INT NOT NULL
        CONSTRAINT [FK REL_LIVRO_EDITORA / EDITORA] REFERENCES EDITORA(CODIGO), 
    CONSTRAINT [PK Rel_Livro_Editora] PRIMARY KEY ([Cod_Livro], [Cod_Editora])
)