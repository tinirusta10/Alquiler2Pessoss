CREATE TABLE [dbo].[TablaLocalidad] (
    [Id]              INT            IDENTITY (1, 1) NOT NULL,
    [NombreLocalidad] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_TablaLocalidad] PRIMARY KEY CLUSTERED ([Id] ASC), 
   
);

