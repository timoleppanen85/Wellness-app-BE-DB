CREATE TABLE [dbo].[Answer]
(
	[Id] BIGINT NOT NULL PRIMARY KEY IDENTITY, 
    [Answer] INT NOT NULL, 
    [ExtraText] NVARCHAR(MAX) NULL, 
    [AnswerSet] INT NOT NULL, 
    [QuestionId] BIGINT NOT NULL, 
    [UserId] BIGINT NOT NULL, 
    [Timestamp] DATE NOT NULL DEFAULT GETUTCDATE(), 
    CONSTRAINT [FK_Answer_Question] FOREIGN KEY ([QuestionId]) REFERENCES [Question]([Id]), 
    CONSTRAINT [FK_Answer_User] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
	ON DELETE CASCADE
	ON UPDATE CASCADE
)
