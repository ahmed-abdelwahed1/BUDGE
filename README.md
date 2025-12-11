# BUDGE - Expense Tracker Application

![BUDGE Logo](Designs/Logo.svg)

## 📋 Project Overview

**BUDGE** is a simple Windows desktop application for tracking personal income and expenses. The application was developed as a graduation project for the **Advanced Programming** course taught by **Dr. Amani Al-Jamal**.

The name "BUDGE" was inspired by a parrot icon, chosen for its sound similarity to the word "budget."

## 🎯 Features

- **Dashboard Overview**: View total income, expenses, and balance at a glance
- **Transaction Management**: Add and track financial transactions with dates and descriptions
- **Category Management**: Create and organize custom categories for income and expenses
- **Transaction History**: View the latest 10 transactions in a detailed table
- **Splash Screen**: Professional application startup experience

## 🛠️ Technology Stack

- **Framework**: .NET 8.0 Windows Forms
- **Programming Language**: Visual Basic .NET (VB.NET)
- **Database**: Microsoft Access (`.accdb` format)
- **Database Provider**: System.Data.OleDb

## 📁 Project Structure

```
BUDGE/
├── Designs/              # Application design assets
│   ├── Logo.svg         # Application logo
│   ├── icon.ico         # Application icon
│   └── ...
├── Screens/              # Application screenshots
│   ├── 01 - Splash Screen.png
│   ├── 02 - DashBoard.png
│   ├── 03 - Categories.png
│   └── 04 - Add Transactions.png
├── frmSplash.vb         # Splash screen form
├── frmDashboard.vb      # Main dashboard form
├── frmCategories.vb     # Category management form
├── frmAddTransaction.vb # Add transaction form
├── DbHelper.vb          # Database helper module
└── BudgeDB.accdb        # Microsoft Access database
```

## 🖼️ Application Screens

### 1. Splash Screen

![Splash Screen](Screens/01%20-%20Splash%20Screen.png)

The application starts with a splash screen that displays for 3 seconds before loading the main dashboard.

### 2. Dashboard

![Dashboard](Screens/02%20-%20DashBoard.png)

The main dashboard provides:

- **Income Summary**: Total income from all income categories
- **Expense Summary**: Total expenses from all expense categories
- **Balance**: Net balance (Income - Expenses)
- **Recent Transactions**: Table showing the latest 10 transactions with details

### 3. Categories Management

![Categories](Screens/03%20-%20Categories.png)

Manage your financial categories:

- Create new categories
- Categorize as Income or Expense
- View all existing categories in a table

### 4. Add Transaction

![Add Transaction](Screens/04%20-%20Add%20Transactions.png)

Add new financial transactions:

- Select a category from the dropdown
- Enter transaction amount
- Set transaction date
- Add optional description

## 🚀 Getting Started

### Prerequisites

- **.NET 8.0 SDK** or later
- **Microsoft Access Database Engine** (for OleDb support)
- **Visual Studio 2022** or **Visual Studio Code** with VB.NET support

### Installation

1. Clone or download this repository
2. Open `BUDGE.sln` in Visual Studio
3. Restore NuGet packages (if needed)
4. Build the solution (Ctrl+Shift+B)
5. Run the application (F5)

### Database Setup

The application uses a Microsoft Access database (`BudgeDB.accdb`) located in the `bin/Debug/net8.0-windows/` folder. The database is automatically created when you first build the project.

**Database Schema:**

- **Categories Table**: `CategoryID`, `CategoryName`, `CatType`
- **Transactions Table**: `TransactionID`, `Amount`, `TransDate`, `Description`, `CategoryID`

## 📖 Usage

1. **Launch the Application**: Run the executable to see the splash screen
2. **View Dashboard**: The main dashboard shows your financial summary
3. **Add Categories**: Click "Categories" to create income/expense categories
4. **Add Transactions**: Click "Add" to record new financial transactions
5. **Refresh Data**: Use the "Refresh" button to update the dashboard

## 👨‍🏫 Course Information

- **Course**: Advanced Programming
- **Instructor**: Dr. Amani Al-Jamal
- **Project Type**: Graduation Project
- **Academic Level**: Level 03 - First Semester

## 📝 Code Structure

### Key Components

- **DbHelper.vb**: Centralized database operations module
  - `GetData()`: Execute SELECT queries
  - `ExecuteQuery()`: Execute INSERT, UPDATE, DELETE queries

- **frmDashboard.vb**: Main application window
  - Displays financial summaries
  - Shows recent transactions
  - Navigation to other forms

- **frmCategories.vb**: Category management
  - Create and view categories
  - Filter by Income/Expense type

- **frmAddTransaction.vb**: Transaction entry form
  - Form validation
  - Category selection
  - Date and amount input

- **frmSplash.vb**: Application startup screen
  - Code page encoding registration
  - Automatic navigation to dashboard

## 🔧 Development Notes

- The application uses `System.Text.CodePagesEncodingProvider` to ensure proper encoding support for Access databases in .NET 8.0
- Database connection string uses `|DataDirectory|` placeholder for flexible deployment
- All SQL queries are executed through the centralized `DbHelper` module

## 📄 License

This project is developed as an academic project for educational purposes.

## 👥 Developed By

- Ahmed Shehata Said Abdelwahed
- Aya Magdy Abdallah Aboramadan
- Ahmed Tamer Elsayed Mohamed
- Esraa Salah Mohamed Mohamed
- Sarah Essam Eldin Mahmoud Elsayed
- Manar Mansour Mohamed Abdelwahed

---

**Note**: This application requires Microsoft Access Database Engine to be installed on the target machine for database connectivity.
