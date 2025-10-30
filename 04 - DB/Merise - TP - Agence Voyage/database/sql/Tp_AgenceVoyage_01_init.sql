USE db_agence_voyage;

DROP TABLE IF EXISTS t_service;
DROP TABLE IF EXISTS t_theme;
DROP TABLE IF EXISTS t_country;
DROP TABLE IF EXISTS t_city;
DROP TABLE IF EXISTS t_com;
DROP TABLE IF EXISTS t_client;
DROP TABLE IF EXISTS t_trip;
DROP TABLE IF EXISTS t_step;
DROP TABLE IF EXISTS jt_order;
DROP TABLE IF EXISTS jt_trip_service;
DROP TABLE IF EXISTS jt_trip_theme;
DROP TABLE IF EXISTS jt_order_service;

CREATE TABLE t_service(
   service_code INT AUTO_INCREMENT,
   service_name VARCHAR(32) NOT NULL,
   service_description TEXT,
   PRIMARY KEY(service_code)
);

CREATE TABLE t_theme(
   theme_code INT AUTO_INCREMENT,
   theme_name VARCHAR(32) NOT NULL,
   theme_description TEXT,
   PRIMARY KEY(theme_code)
);

CREATE TABLE t_country(
   country_code CHAR(2),
   country_name VARCHAR(128) NOT NULL,
   PRIMARY KEY(country_code)
);

CREATE TABLE t_city(
   city_code INT AUTO_INCREMENT,
   city_name VARCHAR(128) NOT NULL,
   country_code CHAR(2) NOT NULL,
   PRIMARY KEY(city_code),
   FOREIGN KEY(country_code) REFERENCES t_country(country_code)
);

CREATE TABLE t_com(
   com_code VARCHAR(5),
   com_name VARCHAR(64) NOT NULL,
   com_password VARCHAR(60) NOT NULL,
   com_code_1 VARCHAR(5) NOT NULL,
   PRIMARY KEY(com_code),
   FOREIGN KEY(com_code_1) REFERENCES t_com(com_code)
);

CREATE TABLE t_client(
   client_id INT AUTO_INCREMENT,
   client_lastname VARCHAR(32) NOT NULL,
   client_firstname VARCHAR(32) NOT NULL,
   client_email VARCHAR(128) NOT NULL,
   client_phone VARCHAR(16) NOT NULL,
   client_added DATE NOT NULL,
   client_password CHAR(60) NOT NULL,
   com_code VARCHAR(5) NOT NULL,
   PRIMARY KEY(client_id),
   FOREIGN KEY(com_code) REFERENCES t_com(com_code)
);

CREATE TABLE t_trip(
   trip_code INT AUTO_INCREMENT,
   trip_title VARCHAR(128) NOT NULL,
   trip_available BIGINT NOT NULL,
   trip_start DATETIME NOT NULL,
   trip_end DATETIME NOT NULL,
   trip_price DECIMAL(7,2) NOT NULL,
   trip_overview TEXT NOT NULL,
   trip_description TEXT,
   city_code INT NOT NULL,
   PRIMARY KEY(trip_code),
   FOREIGN KEY(city_code) REFERENCES t_city(city_code)
);

CREATE TABLE t_step(
   step_id INT AUTO_INCREMENT,
   step_start DATETIME NOT NULL,
   step_end DATETIME NOT NULL,
   city_code INT NOT NULL,
   trip_code INT NOT NULL,
   PRIMARY KEY(step_id),
   FOREIGN KEY(city_code) REFERENCES t_city(city_code),
   FOREIGN KEY(trip_code) REFERENCES t_trip(trip_code)
);

CREATE TABLE jt_order(
   trip_code INT,
   client_id INT,
   order_quantity SMALLINT NOT NULL,
   order_paid BOOLEAN NOT NULL DEFAULT '0',
   PRIMARY KEY(trip_code, client_id),
   FOREIGN KEY(trip_code) REFERENCES t_trip(trip_code),
   FOREIGN KEY(client_id) REFERENCES t_client(client_id)
);

CREATE TABLE jt_trip_service(
   trip_code INT,
   service_code INT,
   PRIMARY KEY(trip_code, service_code),
   FOREIGN KEY(trip_code) REFERENCES t_trip(trip_code),
   FOREIGN KEY(service_code) REFERENCES t_service(service_code)
);

CREATE TABLE jt_trip_theme(
   trip_code INT,
   theme_code INT,
   PRIMARY KEY(trip_code, theme_code),
   FOREIGN KEY(trip_code) REFERENCES t_trip(trip_code),
   FOREIGN KEY(theme_code) REFERENCES t_theme(theme_code)
);

CREATE TABLE jt_order_service(
   service_code INT,
   trip_code INT,
   client_id INT,
   service_score TINYINT NOT NULL,
   service_commentaire VARCHAR(255),
   PRIMARY KEY(service_code, trip_code, client_id),
   FOREIGN KEY(service_code) REFERENCES t_service(service_code),
   FOREIGN KEY(trip_code, client_id) REFERENCES jt_order(trip_code, client_id)
);