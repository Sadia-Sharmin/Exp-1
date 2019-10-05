
CREATE TABLE Districts(ID INT PRIMARY KEY IDENTITY (1,1),District VARCHAR(20));

CREATE TABLE Customers(ID INT  PRIMARY KEY IDENTITY (1,1),
Code VARCHAR(20),Name VARCHAR(20),[Address] VARCHAR(50),
Contact VARCHAR(20),DistrictId INT REFERENCES Districts(ID));

DROP TABLE Districts;

INSERT INTO Districts VALUES('Bogra');

insert into Districts values('Naogaon')
insert into Districts values('Sirajgonj')
insert into Districts values('Natore')
insert into Districts values('Ishwardi')
insert into Districts values('Rajshahi')

select * FROM Districts;
DROP TABLE Districts;



DROP TABLE Customers;

insert into Customers values('0001','Alice','Naogaon Sadar','0301',2);
select * from Customers;

delete from Districts where id=1;

CREATE VIEW CustomerInfo AS
SELECT c.ID,Code,c.Name,[Address],Contact,d.District AS District FROM Customers AS c
LEFT JOIN Districts as d ON d.ID=c.DistrictId

SELECT * FROM CustomerInfo