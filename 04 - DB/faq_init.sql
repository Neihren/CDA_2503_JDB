DROP TABLE IF EXISTS t_user;
DROP TABLE IF EXISTS t_question;
DROP TABLE IF EXISTS t_category;

CREATE TABLE IF NOT EXISTS t_user
(
   user_id INT AUTO_INCREMENT,
   user_email VARCHAR(128) NOT NULL,
   user_lastname VARCHAR(50) NOT NULL,
   user_firstname VARCHAR(50) NOT NULL,
   PRIMARY KEY (user_id),
   UNIQUE (user_email),
   CONSTRAINT C_email_validation
		CHECK (user_email REGEXP "^([^\x00-\x20\x22\x28\x29\x2c\x2e\x3a-\x3c\x3e\x40\x5b-\x5d\x7f-\xff]+|\x22([^\x0d\x22\x5c\x80-\xff]|\x5c[\x00-\x7f])*\x22)(\x2e([^\x00-\x20\x22\x28\x29\x2c\x2e\x3a-\x3c\x3e\x40\x5b-\x5d\x7f-\xff]+|\x22([^\x0d\x22\x5c\x80-\xff]|\x5c[\x00-\x7f])*\x22))*\x40([^\x00-\x20\x22\x28\x29\x2c\x2e\x3a-\x3c\x3e\x40\x5b-\x5d\x7f-\xff]+|\x5b([^\x0d\x5b-\x5d\x80-\xff]|\x5c[\x00-\x7f])*\x5d)(\x2e([^\x00-\x20\x22\x28\x29\x2c\x2e\x3a-\x3c\x3e\x40\x5b-\x5d\x7f-\xff]+|\x5b([^\x0d\x5b-\x5d\x80-\xff]|\x5c[\x00-\x7f])*\x5d))*$")
);

CREATE TABLE IF NOT EXISTS t_question
(
	question_id INT AUTO_INCREMENT,
	question_date DATE NOT NULL,
	question_label VARCHAR(255) NOT NULL,
	question_response VARCHAR(65535) NOT NULL,
	PRIMARY KEY (question_id),
);

CREATE TABLE IF NOT EXISTS t_category
(
	category_id INT AUTO_INCREMENT,
	categoty_name VARCHAR
);