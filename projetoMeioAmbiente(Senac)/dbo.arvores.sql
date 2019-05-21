CREATE TABLE [dbo].[arvores] (
    [id_arvore]      INT             IDENTITY (1, 1) NOT NULL,
    [id_rua]         INT             NOT NULL,
    [especie]        VARCHAR (50)    NOT NULL,
    [numeroCasa]     INT             NOT NULL,
    [tipoArvore]     VARCHAR (50)    NOT NULL,
    [projecaoSombra] DECIMAL (10, 2) NULL,
    [perimetro]      DECIMAL (10, 2) NULL,
    [gps]            VARCHAR (50)    NULL,
    CONSTRAINT [PK_arvores] PRIMARY KEY CLUSTERED ([id_arvore] ASC), 
    CONSTRAINT [FK_id_ruas] FOREIGN KEY ([id_rua]) REFERENCES [ruas]([id_rua])
);

