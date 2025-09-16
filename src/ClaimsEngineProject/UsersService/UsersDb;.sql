--Create Database UsersDb;
GO
USE UsersDb;
GO
--Create Table Users
/*
drop table if exists Users;
CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    CreatedAt DATETIME NOT NULL DEFAULT GETDATE()
);
GO
-- Insert sample data
INSERT INTO Users (Username, Email) VALUES
('Nizam Khan', 'mail2nizamkhan@gmail.com')
*/
GO
Select * from Users;