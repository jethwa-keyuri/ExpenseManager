-- Users Table: Stores login information for each user.
CREATE TABLE [dbo].[Users]
(
    [UserID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [Username] NVARCHAR(50) NOT NULL UNIQUE,
    [PasswordHash] NVARCHAR(256) NOT NULL
);

-- Categories Table: Stores user-defined expense and income categories.
CREATE TABLE [dbo].[Categories]
(
    [CategoryID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [UserID] INT NOT NULL,
    [CategoryName] NVARCHAR(100) NOT NULL,
    [CategoryType] NVARCHAR(10) NOT NULL, -- 'Expense' or 'Income'
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE
);

-- Transactions Table: Stores all income and expense records.
CREATE TABLE [dbo].[Transactions]
(
    [TransactionID] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [UserID] INT NOT NULL,
    [Title] NVARCHAR(100) NOT NULL,
    [Amount] DECIMAL(18, 2) NOT NULL,
    [TransactionType] NVARCHAR(10) NOT NULL, -- 'Expense' or 'Income'
    [CategoryID] INT NOT NULL,
    [TransactionDate] DATE NOT NULL,
    FOREIGN KEY (UserID) REFERENCES Users(UserID) ON DELETE CASCADE,
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);
