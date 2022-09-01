CREATE TABLE "pic_test" (
	"Id"	INTEGER NOT NULL UNIQUE,
	"pic"	BLOB NOT NULL,
	"name"	TEXT,
	"dates" TEXT NOT NULL DEFAULT (datetime('now', 'localtime')),
	PRIMARY KEY("Id" AUTOINCREMENT)
);