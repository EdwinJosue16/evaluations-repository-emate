CREATE TABLE Student(
	id NVARCHAR(MAX) NOT NULL,
	firstName NVARCHAR(MAX) NOT NULL,
	lastName NVARCHAR(MAX) NOT NULL,
	secondLastName NVARCHAR(MAX) NOT NULL
)

CREATE TABLE SetOfEvaluations1(
	id NVARCHAR(MAX) NOT NULL,
	examIGrade REAL NOT NULL,
	examIIGrade REAL NOT NULL,
	examIIIGrade REAL NOT NULL,
	homeworkGrade REAL NOT NULL
)



INSERT INTO Student (firstName,lastName,secondLastName,id) VALUES ('Luis Felipe', 'Mora', 'Solis','B95221')
INSERT INTO SetOfEvaluations1 (id,examIGrade,examIIGrade,examIIIGrade,homeworkGrade) VALUES ('B95221',7.8,8.2,9.0,8.7)

delete 
from SetOfEvaluations1
where id='B95221'