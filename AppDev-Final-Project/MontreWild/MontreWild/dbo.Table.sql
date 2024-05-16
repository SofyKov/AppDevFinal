CREATE TABLE [dbo].[Plants]
(	[PlantId]             INT           IDENTITY (1, 1) NOT NULL,
    [PlantName]           VARCHAR (50)  NULL,
    [ScientificPlantName] VARCHAR (50)  NULL,
    [Description]         VARCHAR (MAX) NULL,
    [PlantUse]            VARCHAR (MAX) NULL,
    [Type]                VARCHAR (50)  NULL, 
    [Place]				  INT NULL
	FOREIGN KEY ([Place]) REFERENCES [dbo].[Map] ([MapID])
)
