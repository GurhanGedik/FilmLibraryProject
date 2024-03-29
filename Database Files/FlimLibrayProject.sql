USE [FilmLibraryProject]
GO
/****** Object:  Table [dbo].[Flimlerim]    Script Date: 3.7.2019 15:56:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Flimlerim](
	[FlimID] [int] IDENTITY(1,1) NOT NULL,
	[FlimAdi] [nvarchar](500) NULL,
	[FlimTuru] [nvarchar](500) NULL,
	[Yonetmen] [nvarchar](500) NULL,
	[Senarist] [nvarchar](500) NULL,
	[ImdbPuani] [nvarchar](50) NULL,
	[FlimTarihi] [datetime] NULL,
	[Oyuncular] [text] NULL,
	[Konusu] [text] NULL,
	[ResimUrl] [text] NULL,
 CONSTRAINT [PK_Flimlerim] PRIMARY KEY CLUSTERED 
(
	[FlimID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Flimlerim] ON 

INSERT [dbo].[Flimlerim] ([FlimID], [FlimAdi], [FlimTuru], [Yonetmen], [Senarist], [ImdbPuani], [FlimTarihi], [Oyuncular], [Konusu], [ResimUrl]) VALUES (1, N'Dumbo', N'Adventure, Family, Fantasy', N'Tim Burton', N'Ehren Kruger (screenplay by), Helen Aberson (novel), Harold Pearl (novel)', N'6.5', CAST(N'2019-07-03T14:39:38.623' AS DateTime), N'Colin Farrell, Michael Keaton, Danny DeVito, Eva Green', N'A young elephant, whose oversized ears enable him to fly, helps save a struggling circus, but when the circus plans a new venture, Dumbo and his friends discover dark secrets beneath its shiny veneer.', N'https://m.media-amazon.com/images/M/MV5BNjMxMDE0MDI1Ml5BMl5BanBnXkFtZTgwMzExNTU3NjM@._V1_SX300.jpg')
INSERT [dbo].[Flimlerim] ([FlimID], [FlimAdi], [FlimTuru], [Yonetmen], [Senarist], [ImdbPuani], [FlimTarihi], [Oyuncular], [Konusu], [ResimUrl]) VALUES (2, N'Iron Man 3', N'Action, Adventure, Sci-Fi', N'Shane Black', N'Drew Pearce (screenplay by), Shane Black (screenplay by), Stan Lee (based on the Marvel comic book by), Don Heck (based on the Marvel comic book by), Larry Lieber (based on the Marvel comic book by), Jack Kirby (based on the Marvel comic book by), Warren Ellis (based on the &quot;Extremis&quot; mini-series written by), Adi Granov (based on the &quot;Extremis&quot; mini-series illustrated by)', N'7.2', CAST(N'2013-05-03T00:00:00.000' AS DateTime), N'Robert Downey Jr., Gwyneth Paltrow, Don Cheadle, Guy Pearce', N'When Tony Stark''s world is torn apart by a formidable terrorist called the Mandarin, he starts an odyssey of rebuilding and retribution.', N'https://m.media-amazon.com/images/M/MV5BMjE5MzcyNjk1M15BMl5BanBnXkFtZTcwMjQ4MjcxOQ@@._V1_SX300.jpg')
INSERT [dbo].[Flimlerim] ([FlimID], [FlimAdi], [FlimTuru], [Yonetmen], [Senarist], [ImdbPuani], [FlimTarihi], [Oyuncular], [Konusu], [ResimUrl]) VALUES (3, N'The Best of Enemies', N'Biography, Drama, History', N'Robin Bissell', N'Robin Bissell (adaptation), Osha Gray Davidson (based on the book by)', N'6.8', CAST(N'2019-04-05T00:00:00.000' AS DateTime), N'Taraji P. Henson, Sam Rockwell, Babou Ceesay, Nick Searcy', N'Civil rights activist Ann Atwater faces off against C.P. Ellis, Exalted Cyclops of the Ku Klux Klan, in 1971 Durham, North Carolina over the issue of school integration.', N'https://m.media-amazon.com/images/M/MV5BMjQ5MjA2NDkyM15BMl5BanBnXkFtZTgwNTIwNjUzNzM@._V1_SX300.jpg')
INSERT [dbo].[Flimlerim] ([FlimID], [FlimAdi], [FlimTuru], [Yonetmen], [Senarist], [ImdbPuani], [FlimTarihi], [Oyuncular], [Konusu], [ResimUrl]) VALUES (4, N'Escape Plan: The Extractors', N'Action, Thriller', N'John Herzfeld', N'Miles Chapman (screenplay), John Herzfeld', N'4.7', CAST(N'2019-06-21T00:00:00.000' AS DateTime), N'Sylvester Stallone, Dave Bautista, 50 Cent, Jaime King', N'After security expert Ray Breslin is hired to rescue the kidnapped daughter of a Hong Kong tech mogul from a formidable Latvian prison, Breslin''s girlfriend is also captured.', N'https://m.media-amazon.com/images/M/MV5BMDQ2ZjUxMGUtMDg1Yy00ZWE4LWIyZTMtNThiN2IwZmE4ZDVkXkEyXkFqcGdeQXVyOTg4MDYyNw@@._V1_SX300.jpg')
INSERT [dbo].[Flimlerim] ([FlimID], [FlimAdi], [FlimTuru], [Yonetmen], [Senarist], [ImdbPuani], [FlimTarihi], [Oyuncular], [Konusu], [ResimUrl]) VALUES (5, N'Patrick Melrose', N'Drama', N'N/A', N'N/A', N'8.2', CAST(N'2018-05-12T00:00:00.000' AS DateTime), N'Benedict Cumberbatch, Jennifer Jason Leigh, Hugo Weaving, Sebastian Maltz', N'Based on the Patrick Melrose Novels by Edward St. Aubyn.', N'https://m.media-amazon.com/images/M/MV5BMjIwNzk4OTQ1NV5BMl5BanBnXkFtZTgwMjE0NDMyNTM@._V1_SX300.jpg')
INSERT [dbo].[Flimlerim] ([FlimID], [FlimAdi], [FlimTuru], [Yonetmen], [Senarist], [ImdbPuani], [FlimTarihi], [Oyuncular], [Konusu], [ResimUrl]) VALUES (6, N'Five Feet Apart', N'Drama, Romance', N'Justin Baldoni', N'Mikki Daughtry, Tobias Iaconis', N'7.2', CAST(N'2019-03-15T00:00:00.000' AS DateTime), N'Haley Lu Richardson, Cole Sprouse, Moises Arias, Kimberly Hebert Gregory', N'A pair of teenagers with cystic fibrosis meet in a hospital and fall in love, though their disease means they must avoid close physical contact.', N'https://m.media-amazon.com/images/M/MV5BNzVmMjJlN2MtNWQ4Ny00Zjc2LWJjYTgtYjJiNGM5MTM1ZTlkXkEyXkFqcGdeQXVyMjM4NTM5NDY@._V1_SX300.jpg')
INSERT [dbo].[Flimlerim] ([FlimID], [FlimAdi], [FlimTuru], [Yonetmen], [Senarist], [ImdbPuani], [FlimTarihi], [Oyuncular], [Konusu], [ResimUrl]) VALUES (7, N'Lost in Space', N'Adventure, Drama, Family, Mystery, Sci-Fi', N'N/A', N'Matt Sazama, Burk Sharpless, Irwin Allen', N'7.2', CAST(N'2018-04-13T00:00:00.000' AS DateTime), N'Molly Parker, Toby Stephens, Maxwell Jenkins, Taylor Russell', N'After crash-landing on an alien planet, the Robinson family fight against all odds to survive and escape, but they''re surrounded by hidden dangers.', N'https://m.media-amazon.com/images/M/MV5BMjI3MjI5OTczNV5BMl5BanBnXkFtZTgwODA4MTc5NDM@._V1_SX300.jpg')
INSERT [dbo].[Flimlerim] ([FlimID], [FlimAdi], [FlimTuru], [Yonetmen], [Senarist], [ImdbPuani], [FlimTarihi], [Oyuncular], [Konusu], [ResimUrl]) VALUES (8, N'Captain Marvel', N'Action, Adventure, Sci-Fi', N'Anna Boden, Ryan Fleck', N'Anna Boden (screenplay by), Ryan Fleck (screenplay by), Geneva Robertson-Dworet (screenplay by), Nicole Perlman (story by), Meg LeFauve (story by), Anna Boden (story by), Ryan Fleck (story by), Geneva Robertson-Dworet (story by)', N'7.0', CAST(N'2019-03-08T00:00:00.000' AS DateTime), N'Brie Larson, Samuel L. Jackson, Ben Mendelsohn, Jude Law', N'Carol Danvers becomes one of the universe''s most powerful heroes when Earth is caught in the middle of a galactic war between two alien races.', N'https://m.media-amazon.com/images/M/MV5BMTE0YWFmOTMtYTU2ZS00ZTIxLWE3OTEtYTNiYzBkZjViZThiXkEyXkFqcGdeQXVyODMzMzQ4OTI@._V1_SX300.jpg')
INSERT [dbo].[Flimlerim] ([FlimID], [FlimAdi], [FlimTuru], [Yonetmen], [Senarist], [ImdbPuani], [FlimTarihi], [Oyuncular], [Konusu], [ResimUrl]) VALUES (9, N'The Mustang', N'Drama', N'Laure de Clermont-Tonnerre', N'Mona Fastvold, Brock Norman Brock, Laure de Clermont-Tonnerre', N'7.0', CAST(N'2019-06-19T00:00:00.000' AS DateTime), N'Matthias Schoenaerts, Jason Mitchell, Bruce Dern, Gideon Adlon', N'The story of Roman Coleman, a violent convict, who is given the chance to participate in a rehabilitation therapy program involving the training of wild mustangs.', N'https://m.media-amazon.com/images/M/MV5BNDkwYzBjOTItYTFhZC00ZWZlLTg1YzYtZWU4ZGZhZWI0MmNkXkEyXkFqcGdeQXVyODAzODU1NDQ@._V1_SX300.jpg')
INSERT [dbo].[Flimlerim] ([FlimID], [FlimAdi], [FlimTuru], [Yonetmen], [Senarist], [ImdbPuani], [FlimTarihi], [Oyuncular], [Konusu], [ResimUrl]) VALUES (10, N'Crypto', N'Crime, Drama, Thriller', N'John Stalberg Jr.', N'Carlyle Eubank, David Frigerio, Jeff Ingber (story by)', N'5.7', CAST(N'2019-04-12T00:00:00.000' AS DateTime), N'Cat Alter, Annalé, Alexis Bledel, Sean Cullen', N'Demoted back to his hometown. A young Wall Street banker is drawn into investigating a tangled web of corruption and fraud in Upstate New York. Affecting both his personal life and business career.', N'https://m.media-amazon.com/images/M/MV5BN2I3YjljOTMtNTg0Ny00NDdhLTlkODUtMzEwMzMwZWNkZTIwXkEyXkFqcGdeQXVyOTg4MDYyNw@@._V1_SX300.jpg')
INSERT [dbo].[Flimlerim] ([FlimID], [FlimAdi], [FlimTuru], [Yonetmen], [Senarist], [ImdbPuani], [FlimTarihi], [Oyuncular], [Konusu], [ResimUrl]) VALUES (11, N'Norm of the North: King Sized Adventure', N'Animation, Adventure, Comedy, Family', N'Richard Finn, Tim Maltby', N'Daniel Altiere (characters), Steven Altiere (characters), Malcolm T. Goldman (characters), Dean Stefan', N'3.6', CAST(N'2019-06-11T00:00:00.000' AS DateTime), N'Jennifer Cameron, Brian Dobson, Michael Dobson, Lisa Durupt', N'An ancient Chinese artifact has been stolen by a villainous archaeologist named Dexter. With the help of his Lemming friends, Norm must keep his word and embark on a journey across the ...', N'https://m.media-amazon.com/images/M/MV5BNjMwZDhhZWYtOTM0OC00ZTQzLWIyNDktNDM1NmVkYTY4NWNlXkEyXkFqcGdeQXVyNTYyNDUxMDc@._V1_SX300.jpg')
INSERT [dbo].[Flimlerim] ([FlimID], [FlimAdi], [FlimTuru], [Yonetmen], [Senarist], [ImdbPuani], [FlimTarihi], [Oyuncular], [Konusu], [ResimUrl]) VALUES (12, N'White Chamber', N'Drama, Sci-Fi', N'Paul Raschid', N'Paul Raschid', N'4.4', CAST(N'2019-03-29T00:00:00.000' AS DateTime), N'Shauna Macdonald, Oded Fehr, Amrita Acharia, Sharon Maughan', N'The United Kingdom. Soon. Civil war rages. A woman wakes up in a blindingly white cuboid cell. Using its sophisticated functionality, her captor tortures her for information; information she claims not to have - or does she?', N'https://m.media-amazon.com/images/M/MV5BOTU2OTIwMjE4OF5BMl5BanBnXkFtZTgwNzUxNzg0NzM@._V1_SX300.jpg')
INSERT [dbo].[Flimlerim] ([FlimID], [FlimAdi], [FlimTuru], [Yonetmen], [Senarist], [ImdbPuani], [FlimTarihi], [Oyuncular], [Konusu], [ResimUrl]) VALUES (13, N'Killing Eve', N'Drama, Thriller', N'N/A', N'Phoebe Waller-Bridge', N'8.3', CAST(N'2018-04-08T00:00:00.000' AS DateTime), N'Sandra Oh, Jodie Comer, Fiona Shaw, Kim Bodnia', N'After a series of events, the lives of a security operative and an assassin become inextricably linked.', N'https://m.media-amazon.com/images/M/MV5BYTVhMmUwZTktMGJlZC00NDUyLWExYjktNDBkZTU3YjU0ODNiXkEyXkFqcGdeQXVyNzQ2NjI4MDM@._V1_SX300.jpg')
INSERT [dbo].[Flimlerim] ([FlimID], [FlimAdi], [FlimTuru], [Yonetmen], [Senarist], [ImdbPuani], [FlimTarihi], [Oyuncular], [Konusu], [ResimUrl]) VALUES (17, N'Apollo 11', N'Documentary, History', N'Todd Douglas Miller', N'N/A', N'8.3', CAST(N'2019-06-26T00:00:00.000' AS DateTime), N'Buzz Aldrin, Joan Ann Archer, Janet Armstrong, Neil Armstrong', N'A look at the Apollo 11 mission to land on the moon led by commander Neil Armstrong and pilots Buzz Aldrin and Michael Collins.', N'https://m.media-amazon.com/images/M/MV5BMTYyMzEzNjI4M15BMl5BanBnXkFtZTgwODgxOTgyNzM@._V1_SX300.jpg')
SET IDENTITY_INSERT [dbo].[Flimlerim] OFF
/****** Object:  StoredProcedure [dbo].[FlimAraAdaGore]    Script Date: 3.7.2019 15:56:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[FlimAraAdaGore] 
@FlimAdi nvarchar(50)  As
select * from Flimlerim f where f.FlimAdi like @FlimAdi+'%'
GO
/****** Object:  StoredProcedure [dbo].[FlimAraFlimAdiveTariheGore]    Script Date: 3.7.2019 15:56:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[FlimAraFlimAdiveTariheGore] 
@FlimAdi nvarchar(50),
@FlimTarihi datetime  As
select * from Flimlerim f where f.FlimTarihi=@FlimTarihi  and f.FlimAdi like @FlimAdi+'&'
GO
/****** Object:  StoredProcedure [dbo].[FlimAraTariheGore]    Script Date: 3.7.2019 15:56:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[FlimAraTariheGore] 
@FlimTarihi datetime  As
select * from Flimlerim f where f.FlimTarihi=@FlimTarihi
GO
