CREATE TABLE [dbo].[teachers] (
    [id]               INT           IDENTITY (1, 1) NOT NULL,
    [teacher_id]       VARCHAR (MAX) NULL,
    [teacher_name]     VARCHAR (MAX) NULL,
    [teacher_gender]   VARCHAR (MAX) NULL,
    [teacher_email]    VARCHAR (MAX) NULL,
    [teacher_phone]    VARCHAR (MAX) NULL,
    [teacher_role]     VARCHAR (MAX) NULL,
    [teacher_subject1] VARCHAR (MAX) NULL,
    [teacher_subject2] VARCHAR (MAX) NULL,
    [salary]           INT           NULL,
    [status]           VARCHAR (MAX) NULL,
    [insert_date]      DATETIME      NULL,
    [update_date]      DATETIME      NULL,
    [delete_date]      DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

