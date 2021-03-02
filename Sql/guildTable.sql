CREATE TABLE IF NOT EXISTS `Guilds` (
    `ID` INT NOT NULL AUTO_INCREMENT=0,
    `Name` VARCHAR(40) Not NULL,
    `OwnerID` INT NOT NULL,
    FOREIGN KEY (OwnerID, ID) REFERENCES `Members`(ID, GuildID),
    PRIMARY KEY (ID)
);