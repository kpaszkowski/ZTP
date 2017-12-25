CREATE TABLE [Player] (
	id integer NOT NULL,
	firstName varchar(64) NOT NULL,
	lastName varchar(64) NOT NULL,
	clubID integer,
	recordID integer,
  CONSTRAINT [PK_PLAYER] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Club] (
	id integer NOT NULL,
	name varchar(64) NOT NULL,
	stadiumID integer,
	recordID integer,
  CONSTRAINT [PK_CLUB] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [TrainingStaff] (
	id integer NOT NULL,
	firstName varchar(64) NOT NULL,
	lastName varchar(64) NOT NULL,
	age integer NOT NULL,
	duty varchar(64) NOT NULL,
	clubID integer,
	recordID integer,
  CONSTRAINT [PK_TRAININGSTAFF] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Stadium] (
	id integer NOT NULL,
	name varchar(64) NOT NULL,
	city varchar(64) NOT NULL,
	country varchar(64) NOT NULL,
  CONSTRAINT [PK_STADIUM] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Timetable] (
	id integer NOT NULL,
	matchID integer NOT NULL,
	refereeID integer NOT NULL,
  CONSTRAINT [PK_TIMETABLE] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Match] (
	id integer NOT NULL,
	stadiumID integer NOT NULL,
	hostID integer NOT NULL,
	guestID integer NOT NULL,
	mainRefereeID integer NOT NULL,
	technicalRefereeID integer NOT NULL,
	linesRefereeID integer NOT NULL,
	observerRefereeID integer NOT NULL,
	hostGoals integer NOT NULL,
	guestGoals integer NOT NULL,
  CONSTRAINT [PK_MATCH] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Referee] (
	id integer NOT NULL,
	firstName varchar(64) NOT NULL,
	lastName varchar(64) NOT NULL,
	recordID integer,
	salary float NOT NULL,
	isBusy integer NOT NULL,
  CONSTRAINT [PK_REFEREE] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Record] (
	id integer NOT NULL,
	type varchar(64) NOT NULL,
	name varchar(64) NOT NULL,
  CONSTRAINT [PK_RECORD] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Ticket] (
	id integer NOT NULL,
	matchID integer NOT NULL,
	PESEL varchar(20) NOT NULL,
	date date NOT NULL,
  CONSTRAINT [PK_TICKET] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Winners] (
	id integer NOT NULL,
	clubID integer NOT NULL,
	year varchar(4) NOT NULL,
	wonMatches integer NOT NULL,
	lostMatches integer NOT NULL,
	goalsScored integer NOT NULL,
	goalsLost integer NOT NULL,
  CONSTRAINT [PK_WINNERS] PRIMARY KEY CLUSTERED
  (
  [id] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
ALTER TABLE [Player] WITH CHECK ADD CONSTRAINT [Player_fk0] FOREIGN KEY ([clubID]) REFERENCES [Club]([id])
GO
ALTER TABLE [Player] CHECK CONSTRAINT [Player_fk0]
GO
ALTER TABLE [Player] WITH CHECK ADD CONSTRAINT [Player_fk1] FOREIGN KEY ([recordID]) REFERENCES [Record]([id])
GO
ALTER TABLE [Player] CHECK CONSTRAINT [Player_fk1]
GO

ALTER TABLE [Club] WITH CHECK ADD CONSTRAINT [Club_fk0] FOREIGN KEY ([stadiumID]) REFERENCES [Stadium]([id])

GO
ALTER TABLE [Club] CHECK CONSTRAINT [Club_fk0]
GO
ALTER TABLE [Club] WITH CHECK ADD CONSTRAINT [Club_fk1] FOREIGN KEY ([recordID]) REFERENCES [Record]([id])

GO
ALTER TABLE [Club] CHECK CONSTRAINT [Club_fk1]
GO

ALTER TABLE [TrainingStaff] WITH CHECK ADD CONSTRAINT [TrainingStaff_fk0] FOREIGN KEY ([clubID]) REFERENCES [Club]([id])

GO
ALTER TABLE [TrainingStaff] CHECK CONSTRAINT [TrainingStaff_fk0]
GO
ALTER TABLE [TrainingStaff] WITH CHECK ADD CONSTRAINT [TrainingStaff_fk1] FOREIGN KEY ([recordID]) REFERENCES [Record]([id])

GO
ALTER TABLE [TrainingStaff] CHECK CONSTRAINT [TrainingStaff_fk1]
GO


ALTER TABLE [Timetable] WITH CHECK ADD CONSTRAINT [Timetable_fk0] FOREIGN KEY ([matchID]) REFERENCES [Match]([id])

GO
ALTER TABLE [Timetable] CHECK CONSTRAINT [Timetable_fk0]
GO
ALTER TABLE [Timetable] WITH CHECK ADD CONSTRAINT [Timetable_fk1] FOREIGN KEY ([refereeID]) REFERENCES [Referee]([id])

GO
ALTER TABLE [Timetable] CHECK CONSTRAINT [Timetable_fk1]
GO

ALTER TABLE [Match] WITH CHECK ADD CONSTRAINT [Match_fk0] FOREIGN KEY ([stadiumID]) REFERENCES [Stadium]([id])

GO
ALTER TABLE [Match] CHECK CONSTRAINT [Match_fk0]
GO
ALTER TABLE [Match] WITH CHECK ADD CONSTRAINT [Match_fk1] FOREIGN KEY ([hostID]) REFERENCES [Club]([id])

GO
ALTER TABLE [Match] CHECK CONSTRAINT [Match_fk1]
GO
ALTER TABLE [Match] WITH CHECK ADD CONSTRAINT [Match_fk2] FOREIGN KEY ([guestID]) REFERENCES [Club]([id])

GO
ALTER TABLE [Match] CHECK CONSTRAINT [Match_fk2]
GO
ALTER TABLE [Match] WITH CHECK ADD CONSTRAINT [Match_fk3] FOREIGN KEY ([mainRefereeID]) REFERENCES [Referee]([id])

GO
ALTER TABLE [Match] CHECK CONSTRAINT [Match_fk3]
GO
ALTER TABLE [Match] WITH CHECK ADD CONSTRAINT [Match_fk4] FOREIGN KEY ([technicalRefereeID]) REFERENCES [Referee]([id])

GO
ALTER TABLE [Match] CHECK CONSTRAINT [Match_fk4]
GO
ALTER TABLE [Match] WITH CHECK ADD CONSTRAINT [Match_fk5] FOREIGN KEY ([linesRefereeID]) REFERENCES [Referee]([id])

GO
ALTER TABLE [Match] CHECK CONSTRAINT [Match_fk5]
GO
ALTER TABLE [Match] WITH CHECK ADD CONSTRAINT [Match_fk6] FOREIGN KEY ([observerRefereeID]) REFERENCES [Referee]([id])

GO
ALTER TABLE [Match] CHECK CONSTRAINT [Match_fk6]
GO

ALTER TABLE [Referee] WITH CHECK ADD CONSTRAINT [Referee_fk0] FOREIGN KEY ([recordID]) REFERENCES [Record]([id])

GO
ALTER TABLE [Referee] CHECK CONSTRAINT [Referee_fk0]
GO


ALTER TABLE [Ticket] WITH CHECK ADD CONSTRAINT [Ticket_fk0] FOREIGN KEY ([matchID]) REFERENCES [Match]([id])

GO
ALTER TABLE [Ticket] CHECK CONSTRAINT [Ticket_fk0]
GO

ALTER TABLE [Winners] WITH CHECK ADD CONSTRAINT [Winners_fk0] FOREIGN KEY ([clubID]) REFERENCES [Club]([id])

GO
ALTER TABLE [Winners] CHECK CONSTRAINT [Winners_fk0]
GO
