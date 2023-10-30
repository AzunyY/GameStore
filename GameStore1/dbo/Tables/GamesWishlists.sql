CREATE TABLE [dbo].[GamesWishlists] (
    [GamesWishlistsId] INT IDENTITY (1, 1) NOT NULL,
    [WishlistsId]      INT NULL,
    [GamesId]          INT NULL,
    PRIMARY KEY CLUSTERED ([GamesWishlistsId] ASC),
    FOREIGN KEY ([WishlistsId]) REFERENCES [dbo].[Wishlists] ([WishlistsId]),
    CONSTRAINT [FK__GamesWish__Games__47DBAE45] FOREIGN KEY ([GamesId]) REFERENCES [dbo].[Games] ([GamesId])
);

