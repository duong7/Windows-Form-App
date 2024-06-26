USE [HCG]
GO
/****** Object:  Table [dbo].[tblluat]    Script Date: 5/23/2017 9:47:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblluat](
	[maluat] [char](10) NOT NULL,
	[noidung] [varchar](50) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblsukien]    Script Date: 5/23/2017 9:47:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblsukien](
	[masukien] [varchar](10) NOT NULL,
	[motasukien] [nvarchar](50) NOT NULL,
	[loaisukien] [varchar](50) NULL,
 CONSTRAINT [PK__tblsukien__3108FC185EFD1FA0] PRIMARY KEY CLUSTERED 
(
	[masukien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r1        ', N'K3^HL2^ST5>KL1')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r2        ', N'K3^HL3^ST5>KL1')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r3        ', N'K3^HL2^ST1>KL1')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r4        ', N'K3^HL3^ST1>KL1')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r5        ', N'K1^HL2^ST5>KL1')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r6        ', N'K1^HL3^ST5>KL1')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r7        ', N'K1^HL2^ST1>KL1')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r8        ', N'K1^HL3^ST1>KL1')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r9        ', N'K4^HL2^ST5>KL1')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r10        ', N'K4^HL3^ST5>KL1')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r11        ', N'K4^HL2^ST1>KL1')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r12        ', N'K4^HL3^ST1>KL1')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r13       ', N'K3^HL1^ST2>KL2')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r14        ', N'K3^HL2^ST2>KL2')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r15        ', N'K3^HL3^ST2>KL2')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r16        ', N'K1^HL1^ST2>KL2')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r17        ', N'K1^HL2^ST2>KL2')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r18        ', N'K1^HL3^ST2>KL2')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r19        ', N'K4^HL1^ST2>KL2')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r20        ', N'K4^HL2^ST2>KL2')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r21        ', N'K4^HL3^ST2>KL2')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r22        ', N'K3^HL1^ST2>KL3')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r23        ', N'K3^HL2^ST2>KL3')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r24        ', N'K3^HL3^ST2>KL3')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r25        ', N'K1^HL1^ST2>KL3')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r26        ', N'K1^HL2^ST2>KL3')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r27        ', N'K1^HL3^ST2>KL3')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r28        ', N'K4^HL1^ST2>KL3')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r29        ', N'K4^HL2^ST2>KL3')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r30        ', N'K4^HL3^ST2>KL3')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r31        ', N'K1^HL2^ST3>KL4')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r32        ', N'K1^HL3^ST3>KL4')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r33        ', N'K4^HL2^ST3>KL4')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r34        ', N'K4^HL3^ST3>KL4')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r35        ', N'K1^HL2^ST4>KL5')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r36        ', N'K1^HL3^ST4>KL5')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r37        ', N'K4^HL2^ST4>KL5')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r38        ', N'K4^HL3^ST4>KL5')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r39        ', N'K1^HL1^ST8>KL6')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r40        ', N'K1^HL2^ST8>KL6')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r41        ', N'K1^HL3^ST8>KL6')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r42        ', N'K4^HL1^ST8>KL6')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r43        ', N'K4^HL2^ST8>KL6')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r44        ', N'K4^HL3^ST8>KL6')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r45        ', N'K1^HL2^ST1>KL7')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r46        ', N'K1^HL3^ST1>KL7')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r47        ', N'K2^HL2^ST1>KL7')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r48        ', N'K2^HL3^ST1>KL7')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r49        ', N'K1^HL2^ST9>KL7')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r50        ', N'K1^HL3^ST9>KL7')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r51        ', N'K2^HL2^ST9>KL7')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r52        ', N'K2^HL3^ST9>KL7')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r53        ', N'K3^HL2^ST6>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r54        ', N'K3^HL3^ST6>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r55        ', N'K3^HL2^ST7>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r56        ', N'K3^HL3^ST7>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r57        ', N'K3^HL1^ST6>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r58        ', N'K3^HL1^ST7>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r59        ', N'K4^HL2^ST6>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r60        ', N'K4^HL3^ST6>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r61        ', N'K4^HL2^ST7>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r62        ', N'K4^HL3^ST7>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r63        ', N'K4^HL1^ST6>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r64        ', N'K4^HL1^ST7>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r65        ', N'K3^HL2^ST10>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r66        ', N'K3^HL3^ST10>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r67        ', N'K3^HL2^ST11>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r68        ', N'K3^HL3^ST11>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r69        ', N'K3^HL1^ST10>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r70        ', N'K3^HL1^ST11>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r71        ', N'K4^HL2^ST10>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r72        ', N'K4^HL3^ST10>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r73        ', N'K4^HL2^ST11>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r74        ', N'K4^HL3^ST11>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r75        ', N'K4^HL1^ST10>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r76        ', N'K4^HL1^ST11>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r78        ', N'K1^HL2^ST10>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r79        ', N'K1^HL3^ST10>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r80        ', N'K1^HL2^ST11>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r81        ', N'K1^HL3^ST11>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r82        ', N'K1^HL1^ST10>KL8')
INSERT [dbo].[tblluat] ([maluat], [noidung]) VALUES (N'r83        ', N'K1^HL1^ST11>KL8')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'HL1', N'TB', N'hocluc')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'HL2', N'Khá', N'hocluc')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'HL3', N'Giỏi', N'hocluc')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'K1', N'Khối A', N'khoithi')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'K2', N'Khối B', N'khoithi')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'K3', N'Khối C', N'khoithi')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'K4', N'Khối D', N'khoithi')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'KL1', N'Luật sư', N'nganhnghe')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'KL2', N'Ngân hàng', N'nganhnghe')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'KL3', N'Kế toán', N'nganhnghe')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'KL4', N'Công nghệ thông tin', N'nganhnghe')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'KL5', N'Công nghệ kỹ thuật ô tô', N'nganhnghe')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'KL6', N'Marketing', N'nganhnghe')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'KL7', N'Bác sĩ', N'nganhnghe')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'KL8', N'Nhà báo', N'nganhnghe')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'KL9', N'Du lịch', N'nganhnghe')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'ST1', N'Giúp đỡ mọi người', N'sothich')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'ST2', N'Làm việc với các con số', N'sothich')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'ST3', N'Tìm hiểu về các ngôn ngữ lập trình ', N'sothich')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'ST4', N'Ô tô', N'sothich')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'ST5', N'Tìm hiểu nhiều về các điều luật ', N'sothich')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'ST6', N'Đọc sách', N'sothich')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'ST7', N'Viết lách', N'sothich')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'ST8', N'Kinh doanh', N'sothich')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'ST9', N'Nghiên cứu hóa sinh', N'sothich')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'ST10', N'Khám phá các nền văn hóa', N'sothich')
INSERT [dbo].[tblsukien] ([masukien], [motasukien], [loaisukien]) VALUES (N'ST11', N'Đi du lịch', N'sothich')
