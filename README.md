# Food Ordering Manage System

## Description

It is a web application where users can order food without leaving their homes and without communicate with restaurants.

## Getting Started

### Programming Languages

* C#
* ASP
* JavaScript

### Additional

* Entity Framework
* MS Sql Server
* Code First

### UI Frameworks

* Bootstrap
* ASP.NET Framework 

## Data Dictionary

### Restaurant Table

| Variable Name | Data Type | Detail |
| --- | --- | --- |
| restaurant_id | INT | Restaurant ID Number |
| restaurant_name | VARCHAR(50) | Restaurant Name |
| restaurant_address | VARCHAR(50) | Restaurant Address |
| phone_number | VARCHAR(50) | Restaurant Phone Number |
| rating | INT | Restaurant Rating Score |
| order_time_planned | DATETIME | Restaurant Delivery Time |

### User Table

| Variable Name | Data Type | Detail |
| --- | --- | --- |
| user_id | INT | User ID Number |
| role_id | INT | Role ID Number |
| city_id | INT | City ID Number |
| payment_id | INT | Payment ID Number |
| first_name | VARCHAR(50) | User First Name |
| last_name | VARCHAR(50) | User Last Name |
| username | VARCHAR(50) | Nickname |
| user_password | VARCHAR(50) | User Password |
| user_email | VARCHAR(50) | User Email |
| phone_number | VARCHAR(50) | User Phone Number |
| user_address | VARCHAR(50) | User Address |
| user_score | INT | User Score |

### Product Table

| Variable Name | Data Type | Detail |
| --- | --- | --- |
| product_id | INT | Product ID Number |
| category_id | INT | Category ID Number |
| restaurant_id | INT | Restaurant ID Number |
| product_name | VARCHAR(50) | Product Name |
| details | VARCHAR(50) | Details About Product |
| price | VARCHAR(50) | Product Price |
| active | BIT | Product active/passive |
| product_image | VARCHAR(50) | Product Image |

### Order Table

| Variable Name | Data Type | Detail |
| --- | --- | --- |
| order_id | INT | Order ID Number |
| user_id | INT | User ID Number |
| payment_type | VARCHAR(50) | Payment Type(with cash, credit card etc.) |
| order_details | VARCHAR(50) | Details About Order |
| price | VARCHAR(50) | Order Price |
| order_time | DATETIME | Order Time |

### Shipper Table

| Variable Name | Data Type | Detail |
| --- | --- | --- |
| shipper_id | INT | Shipper ID Number |
| restaurant_id | INT | Restaurant ID Number |
| first_name | VARCHAR(50) | Shipper First Name |
| last_name | VARCHAR(50) | Shipper Last Name |
| identification_number | VARCHAR(50) | Shipper Identification Number |

### Comment Table

| Variable Name | Data Type | Detail |
| --- | --- | --- |
| comment_id | INT | Shipper ID Number |
| user_id | INT | User ID Number |
| restaurant_id | INT | Restaurant ID Number |
| comment_time | DATETIME | Comment Time |
| comment_text | VARCHAR(50) | Comment Text |

### Payment Table

| Variable Name | Data Type | Detail |
| --- | --- | --- |
| payment_id | INT | Payment ID Number |
| card_number | VARCHAR(50) | Credit Card Number |
| card_date | VARCHAR(50) | Credit Card Date |
| card_cvv | VARCHAR(50) | Credit Card CVV Number |

### City Table

| Variable Name | Data Type | Detail |
| --- | --- | --- |
| city_id | INT | City ID Number |
| city_name | VARCHAR(50) | City Name |
| city_zip_code | INT | City Zip Code |

### Role Table

| Variable Name | Data Type | Detail |
| --- | --- | --- |
| role_id | INT | Role ID Number |
| role_name | VARCHAR(50) | Role Name(admin, user) |

### Category Table

| Variable Name | Data Type | Detail |
| --- | --- | --- |
| category_id | INT | Category ID Number |
| category_name | VARCHAR(50) | Food Category(breakfast, desert, drink etc.) |


# Database Design

![database-design](https://user-images.githubusercontent.com/43720773/89989913-42a61680-dc8a-11ea-85a4-314a86012139.png)








