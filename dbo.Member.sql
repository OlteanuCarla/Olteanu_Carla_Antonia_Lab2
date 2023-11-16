CREATE TABLE [dbo].[Member] (
    [ID]        INT            IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (MAX) NULL,
    [LastName]  NVARCHAR (MAX) NULL,
    [Adress]    NVARCHAR (MAX) NULL,
    [Email]     NVARCHAR (MAX) NOT NULL,
    [Phone]     NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED ([ID] ASC)
);
