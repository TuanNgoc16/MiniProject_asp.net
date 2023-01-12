CREATE TABLE [dbo].[Services] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [inurance]          NVARCHAR (MAX) NULL,
    [aotomotive_parts]  NVARCHAR (MAX) NULL,
    [service_about_car] NVARCHAR (MAX) NULL,
    [StoreID]          INT            NULL,
    CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Services_Stores_StoresID] FOREIGN KEY ([StoreID]) REFERENCES [dbo].[Stores] ([ID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Services_StoresID]
    ON [dbo].[Services]([StoreID] ASC);

