DROP DATABASE `Cardinal`;

CREATE DATABASE IF NOT EXISTS `Cardinal`;

USE `Cardinal`;

CREATE TABLE IF NOT EXISTS `Guilds` (
    `ID` INT NOT NULL AUTO_INCREMENT,
    `Name` VARCHAR(40) Not NULL,
    `OwnerID` INT DEFAULT 0,
    PRIMARY KEY (ID)
);

CREATE TABLE IF NOT EXISTS `Members` (
    `ID` INT NOT NULL AUTO_INCREMENT,
    `Name` VARCHAR(40) Not NULL,
    `GuildID` INT NOT NULL,
    `Rank` INT DEFAULT 1,
    FOREIGN KEY (GuildID) REFERENCES `Guilds`(ID),
    PRIMARY KEY (ID, GuildID)
);

ALTER TABLE `Guilds`
ADD FOREIGN KEY (OwnerID, ID) REFERENCES `Members`(ID, GuildID);

INSERT INTO `Cardinal`.`Guilds`
(Name)
VALUES
("Guild 1"),( "Second"), ("Guild the third");

INSERT INTO `Cardinal`.`Members`
(Name, GuildID)
VALUES
("MEMB1", 1) , ("Gyro", 1) , ("hyrion", 2) , ("testing", 3);