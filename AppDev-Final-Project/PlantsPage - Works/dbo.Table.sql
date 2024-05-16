CREATE TABLE [dbo].[Plant]
(
	[PlantId] INT IDENTITY (1, 1) NOT NULL, 
    [PlantName] VARCHAR(50) NULL, 
    [ScientificPlantName] VARCHAR(50) NULL, 
    [Description] VARCHAR(MAX) NULL, 
    [PlantUse] VARCHAR(MAX) NULL, 
    [Type] NCHAR(10) NULL
)
