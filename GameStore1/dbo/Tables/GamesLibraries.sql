CREATE TABLE [dbo].[GamesLibraries] (
    [GamesLibrariesId] INT IDENTITY (1, 1) NOT NULL,
    [GamesId]          INT NULL,
    [LibrariesId]      INT NULL,
    PRIMARY KEY CLUSTERED ([GamesLibrariesId] ASC),
    FOREIGN KEY ([LibrariesId]) REFERENCES [dbo].[Libraries] ([LibrariesId]),
    CONSTRAINT [FK__GamesLibr__Games__440B1D61] FOREIGN KEY ([GamesId]) REFERENCES [dbo].[Games] ([GamesId])
);

