CREATE TABLE employees
(
	id INT PRIMARY KEY IDENTITY (1,1),
	employee_id VARCHAR(MAX) NULL,
	employee_name VARCHAR(MAX) NULL,
	employee_gender VARCHAR(MAX) NULL,
	employee_email VARCHAR(MAX) NULL,
	employee_phone VARCHAR(MAX) NULL,
	employee_role VARCHAR(MAX) NULL,
	salary INT NULL,
	status VARCHAR(MAX) NULL,
	insert_date DATETIME NULL,
	update_date DATETIME NULL,
	delete_date DATETIME NULL
);