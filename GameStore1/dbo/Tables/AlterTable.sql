SET IDENTITY_INSERT Wishlists ON

INSERT INTO Wishlists(WishlistsId, DateAdded) VALUES (1, 10)

SET IDENTITY_INSERT Wishlists OFF

SELECT * FROM Wishlists

SET IDENTITY_INSERT Libraries ON
INSERT INTO Libraries (LibrariesId, DateAdded) VALUES (1, 10)
SET IDENTITY_INSERT Libraries OFF

SELECT * FROM Libraries
SELECT * FROM GamesLibraries

INSERT INTO Games (Name, ESRB, Price, Year, image)
VALUES ('Grand Theft Auto V', 2, 29.99, 2013, 'gta.jpg');

INSERT INTO Games (Name, ESRB, Price, Year, image)
VALUES ('The Witcher 3: Wild Hunt', 3, 29.99, 2015, 'witcher.jpg');

INSERT INTO Games (Name, ESRB, Price, Year, image)
VALUES ('Minecraft', 1, 19.99, 2011, 'minecraft.png');

INSERT INTO Games (Name, ESRB, Price, Year, image)
VALUES ('The Elder Scrolls V: Skyrim', 2, 29.99, 2011, 'skyrim.jpg');

INSERT INTO Games (Name, ESRB, Price, Year, image)
VALUES ('Fortnite', 3, 0, 2017, 'fortnite.jpg');

INSERT INTO Games (Name, ESRB, Price, Year, image)
VALUES ('Call of Duty: Warzone', 3, 0, 2020, 'cod.png');

INSERT INTO Games (Name, ESRB, Price, Year, image)
VALUES ('Apex Legends', 3, 0, 2019, 'apex.jpg');

INSERT INTO Games (Name, ESRB, Price, Year, image)
VALUES ('FIFA 23', 3, 59.99, 2021, 'fifa.jpg');

INSERT INTO Games (Name, ESRB, Price, Year, image)
VALUES ('Assassins Creed Valhalla', 2, 49.99, 2020, 'ac.jpg');

INSERT INTO Games (Name, ESRB, Price, Year, image)
VALUES ('Resident Evil Village', 3, 59.99, 2021, 'resident.jpg');
