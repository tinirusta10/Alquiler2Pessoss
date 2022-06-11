CREATE TABLE [dbo].[TablaProvincia] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [NombreProvincia] NVARCHAR (MAX) NULL,
    [cordoba] NCHAR(10) NULL, 
    CONSTRAINT [PK_TablaProvincia] PRIMARY KEY CLUSTERED ([Id] ASC)
);

