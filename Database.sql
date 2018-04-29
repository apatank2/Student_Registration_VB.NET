USE [Student_portal]
GO

/****** Object:  Table [dbo].[cancel_orders]    Script Date: 06-04-2018 19:50:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[cancel_orders](
	[rx_refill] [int] NOT NULL,
	[cancel_date_time] [date] NULL,
	[patientname] [varchar](100) NULL,
	[productid] [int] NULL,
	[Medication] [int] NULL,
	[Cancel_reason] [varchar](100) NULL,
	[Operator] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[rx_refill] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [Student_portal]
GO

/****** Object:  Table [dbo].[registration]    Script Date: 06-04-2018 19:50:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[registration](
	[studentid] [int] NOT NULL,
	[student_name] [varchar](100) NOT NULL,
	[student_email] [varchar](100) NOT NULL,
	[student_passwd] [varchar](100) NOT NULL,
	[student_gender] [varchar](10) NOT NULL,
	[country] [varchar](50) NOT NULL,
	[univ_name] [varchar](100) NOT NULL,
	[student_dob] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[studentid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [Student_portal]
GO

/****** Object:  Table [dbo].[studentdetails]    Script Date: 06-04-2018 19:50:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[studentdetails](
	[CRN] [int] NOT NULL,
	[student_id] [int] NULL,
	[subject_student] [varchar](50) NULL,
	[course] [varchar](50) NULL,
	[section] [int] NULL,
	[course_title] [varchar](200) NULL,
	[campus] [varchar](50) NULL,
	[final_grade] [varchar](10) NULL,
	[attempted] [int] NULL,
	[earned] [int] NULL,
	[gpa_hrs] [int] NULL,
	[quality_points] [int] NULL
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[studentdetails]  WITH CHECK ADD FOREIGN KEY([student_id])
REFERENCES [dbo].[registration] ([studentid])
GO


