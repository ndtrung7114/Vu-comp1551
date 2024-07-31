CREATE TABLE [dbo].[login] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [email]        VARCHAR (MAX) NULL,
    [username]     VARCHAR (MAX) NULL,
    [password]     VARCHAR (MAX) NULL,
    [role]         VARCHAR (MAX) NULL,
    [date_created] DATE          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

