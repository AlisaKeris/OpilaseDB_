CREATE TABLE [dbo].[Toodetable] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [Toodenimetus] VARCHAR (50) NOT NULL,
    [Kogus]        INT          NULL,
    [Hind]         REAL         NULL,
  
    
    [Pilt] VARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

