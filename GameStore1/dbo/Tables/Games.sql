CREATE TABLE [dbo].[Games] (
    [GamesId] INT           IDENTITY (1, 1) NOT NULL,
    [Name]    VARCHAR (255) NOT NULL,
    [ESRB]    INT           NOT NULL,
    [Price]   INT           NOT NULL,
    [Year]    INT           NOT NULL,
    [image]   VARCHAR (255) NOT NULL,
    CONSTRAINT [PK__Games__B4B95E1D1F837C51] PRIMARY KEY CLUSTERED ([GamesId] ASC)
);
