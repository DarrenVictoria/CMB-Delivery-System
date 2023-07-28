USE [BaggageDeliverySystem]
GO
/****** Object:  Table [dbo].[User]    Script Date: 7/28/2023 9:49:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[username] [nchar](15) NOT NULL,
	[password] [nchar](128) NOT NULL,
	[type] [nchar](6) NULL
) ON [PRIMARY]
GO
