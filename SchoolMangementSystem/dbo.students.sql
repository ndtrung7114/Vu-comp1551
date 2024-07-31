CREATE TABLE [dbo].[students] (
    [id]                      INT           IDENTITY (1, 1) NOT NULL,
    [student_id]              VARCHAR (MAX) NULL,
    [student_name]            VARCHAR (MAX) NULL,
    [student_gender]          VARCHAR (MAX) NULL,
    [student_email]           VARCHAR (MAX) NULL,
    [student_phone]           VARCHAR (MAX) NULL,
    [student_role]            VARCHAR (MAX) NULL,
    [student_currentsubject1] VARCHAR (MAX) NULL,
    [student_currentsubject2] VARCHAR (MAX) NULL,
    [student_studiedsubject1] VARCHAR (MAX) NULL,
    [student_studiedsubject2] VARCHAR (MAX) NULL,
    [student_status]          VARCHAR (MAX) NULL,
    [date_insert]             DATETIME      NULL,
    [date_update]             DATETIME      NULL,
    [date_delete]             DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

