CREATE TABLE [dbo].[Borrowing] (
    [ID]         INT           IDENTITY (1, 1) NOT NULL,
    [MemberID]   INT           NULL,
    [BookID]     INT           NULL,
    [ReturnDate] DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_Borrowing] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Borrowing_Book_BookID] FOREIGN KEY ([BookID]) REFERENCES [dbo].[Book] ([ID]),
    CONSTRAINT [FK_Borrowing_Member_MemberID] FOREIGN KEY ([MemberID]) REFERENCES [dbo].[Member] ([ID])
);


GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Borrowing_BookID]
    ON [dbo].[Borrowing]([BookID] ASC) WHERE ([BookID] IS NOT NULL);


GO
CREATE NONCLUSTERED INDEX [IX_Borrowing_MemberID]
    ON [dbo].[Borrowing]([MemberID] ASC);
