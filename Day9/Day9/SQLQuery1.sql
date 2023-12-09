-- create
CREATE TABLE DETAILS (
  empId int,
  age varchar(100),
  address varchar(100)

);

-- insert
INSERT INTO EMPLOYEE(empId,name,dept) VALUES (0006, 'Clint', 'Jersey');
INSERT INTO EMPLOYEE(empId,name,dept) VALUES (0007, 'Marsh', 'Charkton');
INSERT INTO DETAILS(empId) VALUES (0005);
INSERT INTO DETAILS(empId) VALUES (0006);
INSERT INTO DETAILS(empId,address) VALUES (0007,'Ballard');
INSERT INTO DETAILS(empId,address) VALUES (0008,'Hungary');

-- fetch 
SELECT * FROM DETAILS;


Select * from EMPLOYEE
Union ALl
Select * from COMPANY;

Update EMPLOYEE
set name = 'Bishop'
Where empId=005;

Select empid as ID ,name as Employee_Name ,dept as Department_Name from EMPLOYEE 
full outer join DETAILS
on EMPLOYEE.empId=DETAILS.empId;


DELETE FROM DETAILS
WHERE empId = 5 AND age IS NULL AND address IS NULL;



CREATE TABLE Manufacturer (
  regId int,
  manId varchar(100),
  m_product varchar(100),
  m_cost varchar(100)

);

-- insert
INSERT INTO EMPLOYEE(empId,name,dept) VALUES (0006, 'Clint', 'Jersey');
INSERT INTO EMPLOYEE(empId,name,dept) VALUES (0007, 'Marsh', 'Charkton');
INSERT INTO DETAILS(empId) VALUES (0005);
INSERT INTO DETAILS(empId) VALUES (0006);
INSERT INTO DETAILS(empId,address) VALUES (0007,'Ballard');
INSERT INTO DETAILS(empId,address) VALUES (0008,'Hungary');