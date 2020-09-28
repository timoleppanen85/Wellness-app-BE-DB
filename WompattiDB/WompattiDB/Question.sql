CREATE TABLE [dbo].[Question]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(MAX) NOT NULL, 
    [Image] NVARCHAR(MAX) NOT NULL, 
    [Option1] NVARCHAR(MAX) NULL, 
    [Option2] NVARCHAR(MAX) NULL, 
    [Option3] NVARCHAR(MAX) NULL, 
    [SubjectId] BIGINT NOT NULL, 
    [Hidden] BIT NOT NULL DEFAULT 0, 
    CONSTRAINT [FK_Question_Subject] FOREIGN KEY ([SubjectId]) REFERENCES [Subject]([Id])
)
