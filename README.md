# GameHub Management System
### **Table of Contents**
1. [Project Overview](#project-overview)
2. [Features](#features)
3. [Technologies Used](#technologies-used)
4. [Setup and Installation](#setup-and-installation)
5. [How It Works](#how-it-works)
6. [Database Structure](#database-structure)
7. [Contributing](#contributing)
8. [License](#license)

---

## Project Overview

The **GameHub Management System** is a C# Windows Forms application, a comprehensive digital distribution platform and game server management software. It provides administrators with an interface to add, edit and delete games from the system and offers users a platform to download and view game details. The system is built to be a centralized hub where multiple games can be managed, with features for categorization, user management and detailed tracking of download history.

This a university-level project and a practical exercise in database management, form-based user interfaces. It is built with user-friendly controls and provides a smooth UI experience for both users and administrators.

---

## Features

### **Admin Panel**
- **Add, Update and Delete Games**: Administrators can manage games in the system database by CRUD operations.
- **Add and Delete Admin**: Administrator can add new admin to the system to operate and can remove the ex-admins.
- **User Database**: Admins can see the provided user informations from the database.
- **View Download History**: Admins can track user downloads, including timestamps and game details. [under development]
- **Game Categories**: Games are sorted into categories for easier management and user browsing. And if necessary admins can add new category, update category and even delete the irrelevent one.

### **User Panel**
- **Game List & Details**: Users can browse through the list of games and view detailed descriptions, including the game genre, release date and pricing.
- **Dynamic Loading**: The interface dynamically loads content from the database, enhancing scalability and performance.

### **Data Handling**
- **Database Connectivity**: SQL server management system is used to ensure data persistence for game details, users and admin actions.
- **CRUD Operations**: Built-in functionality for Create, Read, Update, Delete operations on the database tables.

### **User Account Management**
- **Sign Up & Login**: Users can create accounts and log in to manage their downloads and access exclusive games.
- **Admin Login**: A separate log in form is added for the admins to manage the system database.

---

## Technologies Used

- **Programming Language**: C# (.NET Framework v4.7.2)
- **Database**: SQL Server management system
- **UI Components**: Krypton.Toolkit, Bunifu.UI, CuoreUI for custom controls and enhanced UI experience
- **IDE**: Visual Studio
- **Version Control**: GitHub

---
