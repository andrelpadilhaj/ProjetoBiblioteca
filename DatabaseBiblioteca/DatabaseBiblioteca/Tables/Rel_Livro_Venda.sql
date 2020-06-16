﻿CREATE TABLE [dbo].[Rel_Livro_Venda]
(
	[Cod_Venda] INT NOT NULL CONSTRAINT [FK REL_LIVRO_VENDA / VENDA] REFERENCES VENDA(CODIGO), 
    [Cod_Livro] INT NOT NULL CONSTRAINT [FK REL_LIVRO_VENDA / LIVRO] REFERENCES LIVRO(CODIGO), 
    [Quantidade] INT NOT NULL, 
    CONSTRAINT [PK Rel_Livro_Venda] PRIMARY KEY ([Cod_Venda], [Cod_Livro])
)