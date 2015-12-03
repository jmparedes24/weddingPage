CREATE TABLE [dbo].[RoomType] (
    [RoomTypeId]  INT           NOT NULL,
    [Description] VARCHAR (100) NULL,
    [Price]       MONEY         NULL,
    PRIMARY KEY CLUSTERED ([RoomTypeId] ASC)
);

