CREATE TABLE [dbo].[Table] (
    [Id]             INT           IDENTITY (1, 1) NOT NULL,
    [Vonalkod]       VARCHAR (50)  NULL,
    [Megnevezes]     VARCHAR (50)  NULL,
    [Mennyiseg]      INT           NULL,
    [Szallito]       VARCHAR (50)  NULL,
    [Varhatoerkezes] DATETIME2 (7) NULL,
    [Rendelesideje]  DATETIME2 (7) NULL,
    [Beerkezett]     BIT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

