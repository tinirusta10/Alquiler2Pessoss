CREATE TABLE [dbo].[TablaTipoDocumento] (
    [Id]                  INT            IDENTITY (1, 1) NOT NULL,
    [NombreTipoDocumento] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_TablaTipoDocumento] PRIMARY KEY CLUSTERED ([Id] ASC)
);

