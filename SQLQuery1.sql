CREATE DATABASE food_ordering_system


CREATE TABLE restaurants
(
	restaurant_id INT NOT NULL PRIMARY KEY IDENTITY,
	restaurant_name VARCHAR(50) NOT NULL UNIQUE,
	restaurant_address VARCHAR(50) NOT NULL,
	username VARCHAR(50) NOT NULL UNIQUE,
	restaurant_password VARCHAR(50) NOT NULL,
	phone_number VARCHAR(50) NOT NULL,
	rating INT,
	role_id INT NOT NULL,
	order_time_planned DATETIME,
)


CREATE TABLE users
(
	users_id INT NOT NULL PRIMARY KEY IDENTITY,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	username VARCHAR(50) NOT NULL UNIQUE,
	user_password VARCHAR(50) NOT NULL,
	user_email VARCHAR(50) NOT NULL,
	phone_number VARCHAR(50) NOT NULL,
	user_address VARCHAR(50),
	user_score INT,
	order_count INT,
	role_id INT NOT NULL,
	city_id INT NOT NULL,
	payment_id INT NOT NULL

)


CREATE TABLE products
(
	product_id INT NOT NULL PRIMARY KEY IDENTITY,
	product_name VARCHAR(50) NOT NULL,
	details VARCHAR(50) NOT NULL,
	price VARCHAR(50) NOT NULL,
	active BIT NOT NULL,
	product_image VARCHAR(50) NOT NULL,
	category_id INT NOT NULL,
	restaurant_id INT NOT NULL,

)

CREATE TABLE orders
(
	order_id INT NOT NULL PRIMARY KEY IDENTITY,
	order_type VARCHAR(50) NOT NULL,
	order_details VARCHAR(50) NOT NULL,
	price VARCHAR(50) NOT NULL,
	order_time DATETIME,
	users_id INT NOT NULL,

)


CREATE TABLE shippers
(
	shipper_id INT NOT NULL PRIMARY KEY IDENTITY,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	identification_number VARCHAR(50) NOT NULL,
	restaurant_id INT NOT NULL,

)


CREATE TABLE comments
(
	comment_id INT NOT NULL PRIMARY KEY IDENTITY,
	comment_time DATETIME NOT NULL,
	comment_text VARCHAR(50) NOT NULL,
	users_id INT NOT NULL,
	restaurant_id INT NOT NULL,

)


CREATE TABLE payments
(
	payment_id INT NOT NULL PRIMARY KEY IDENTITY,
	card_number VARCHAR(50) NOT NULL,
	card_date VARCHAR(50) NOT NULL,
	card_cvv VARCHAR(50) NOT NULL
)


CREATE TABLE cities
(
	city_id INT NOT NULL PRIMARY KEY IDENTITY,
	city_name VARCHAR(50) NOT NULL,
	city_zip_code VARCHAR(50) NOT NULL,
)


CREATE TABLE roles
(
	role_id INT NOT NULL PRIMARY KEY IDENTITY,
	role_name VARCHAR(50) NOT NULL,
)

CREATE TABLE categories
(
	category_id INT NOT NULL PRIMARY KEY IDENTITY,
	category_name VARCHAR(50) NOT NULL,
)

CREATE TABLE order_product
(
	order_product_id INT NOT NULL PRIMARY KEY IDENTITY,
	order_id INT NOT NULL,
	product_id INT NOT NULL,
)


CREATE TABLE order_shipper
(
	order_shipper_id INT NOT NULL PRIMARY KEY IDENTITY,
	order_id INT NOT NULL,
	shipper_id INT NOT NULL,
)

CREATE TABLE city_restaurant
(
	city_restaurant_id INT NOT NULL PRIMARY KEY IDENTITY,
	city_id INT NOT NULL,
	restaurant_id INT NOT NULL,
)


ALTER TABLE order_product
ADD FOREIGN KEY (order_id) REFERENCES orders (order_id)

ALTER TABLE order_product
ADD FOREIGN KEY (product_id) REFERENCES products (product_id)


ALTER TABLE order_shipper
ADD FOREIGN KEY (order_id) REFERENCES orders (order_id)

ALTER TABLE order_shipper
ADD FOREIGN KEY (shipper_id) REFERENCES shippers (shipper_id)


ALTER TABLE city_restaurant
ADD FOREIGN KEY (city_id) REFERENCES cities (city_id)

ALTER TABLE city_restaurant
ADD FOREIGN KEY (restaurant_id) REFERENCES restaurants (restaurant_id)

ALTER TABLE users
ADD FOREIGN KEY (city_id) REFERENCES cities (city_id)

ALTER TABLE users
ADD FOREIGN KEY (payment_id) REFERENCES payments (payment_id)

ALTER TABLE users
ADD FOREIGN KEY (role_id) REFERENCES roles (role_id)

ALTER TABLE products
ADD FOREIGN KEY (category_id) REFERENCES categories (category_id)

ALTER TABLE products
ADD FOREIGN KEY (restaurant_id) REFERENCES restaurants (restaurant_id)

ALTER TABLE orders
ADD FOREIGN KEY (users_id) REFERENCES users (users_id)

ALTER TABLE comments
ADD FOREIGN KEY (users_id) REFERENCES users (users_id)

ALTER TABLE comments
ADD FOREIGN KEY (restaurant_id) REFERENCES restaurants (restaurant_id)

ALTER TABLE shippers
ADD FOREIGN KEY (restaurant_id) REFERENCES restaurants (restaurant_id)

ALTER TABLE restaurants
ADD FOREIGN KEY (role_id) REFERENCES roles (role_id)
