﻿CREATE TABLE [dbo].[Subject]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(MAX) NOT NULL, 
    [Header1] NVARCHAR(MAX) NOT NULL, 
    [Header2] NVARCHAR(MAX) NULL, 
    [Header3] NVARCHAR(MAX) NULL, 
    [Header4] NVARCHAR(MAX) NULL, 
    [Hidden] BIT NOT NULL DEFAULT 0
)
