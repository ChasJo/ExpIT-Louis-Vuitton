INSERT INTO Mentors
SELECT FirstName, LastName, Email, PhoneNumber FROM AspNetUsers
WHERE Role = 'mentor';

Insert INTO Students
Select LastAssignmentCompleted, FirstName, LastName, Email  FROM AspNetUsers
WHERE Role = 'student';

