DROP TABLE user;
CREATE TABLE user(
	id TEXT NOT NULL PRIMARY KEY,
	username TEXT NOT NULL UNIQUE
);

DROP TABLE profile;
CREATE TABLE profile(
	id TEXT NOT NULL PRIMARY KEY,
	address TEXT,
	latitude REAL,
	longitude REAL,
	phone TEXT,
	email TEXT
);

DROP TABLE product;
CREATE TABLE product(
	id TEXT NOT NULL PRIMARY KEY,
	code TEXT,
	name TEXT,
	description TEXT,
	price REAL
);

DROP TABLE image;
CREATE TABLE image(
	id TEXT NOT NULL PRIMARY KEY,
	product_id TEXT NOT NULL,
	url TEXT,
	FOREIGN KEY (product_id) REFERENCES product (id) ON UPDATE CASCADE ON DELETE CASCADE
);
