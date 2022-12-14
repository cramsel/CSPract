CREATE TABLE [dbo].[Contacts]
(
	[ContactID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL, 
    [Company] VARCHAR(50) NULL, 
    [Telephone] INT NULL, 
    [Email] VARCHAR(50) NULL, 
    [Client] BIT NULL
)
