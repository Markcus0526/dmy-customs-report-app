# Customs Report Application (海关报关系统)

A Windows desktop application for customs declaration and reporting, built with C# WinForms and MySQL database.

## Overview

This is a Chinese customs declaration system (海关报关系统) that enables users to manage import/export declarations, maintain base data (companies, countries, currencies, goods classification), and generate customs reports.

## Technology Stack

- **Framework**: .NET Framework 4.0 (Visual Studio 2010)
- **UI**: Windows Forms (WinForms)
- **Database**: MySQL
- **Components**: ComponentOne Studio (C1 controls for reporting and grids)
- **Language**: C#

## Project Structure

```
dmy-customs-report-app/
├── CustsSystem/
│   ├── Component/                    # Third-party DLLs
│   │   ├── C1.C1Report.2.dll       # ComponentOne Report
│   │   ├── C1.Win.C1Input.2.dll     # ComponentOne Input
│   │   ├── C1.Win.C1TrueDBGrid.2.dll # ComponentOne Grid
│   │   └── MySql.Data.dll           # MySQL Connector
│   └── CustsSystem/
│       ├── CustomsMain.cs           # Application Entry Point
│       ├── FrmMDIMain.cs            # Main MDI Form
│       ├── FrmLogon.cs              # Login Form
│       ├── FrmEnvSet.cs             # Environment Settings
│       ├── FrmInDocEdit.cs          # Import Declaration Form
│       ├── FrmOutDocEdit.cs         # Export Declaration Form
│       ├── FrmOutDocPrint.cs        # Report Print Form
│       ├── FrmBaseDataEdit.cs       # Base Data Edit Form
│       ├── FrmBaseGoodsEdit.cs      # Goods Classification Edit
│       ├── FrmUserMan.cs            # User Management
│       ├── DBProvider.cs             # Database Provider
│       ├── ComMisc.cs                # Common Utilities
│       └── Common.cs                 # Common Functions
├── Database/
│   └── custsdb 20120509.sql         # MySQL Database Schema
└── README.md
```

## Database Schema

The application uses a MySQL database with the following main tables:

### Base Data Tables
- `base_company` - Company information (进出口公司)
- `base_country` - Country codes (国家代码)
- `base_currency` - Currency codes (货币代码)
- `base_custs` - Customs office codes (海关代码)
- `base_domestic` - Domestic region codes (国内地区)
- `base_goods1` - HS Code classification (商品编码)
- `base_boxkind` - Box type (箱型)
- `base_certkind` - Certificate type (征免税性质)
- `base_dockind` - Document type (单证类型)
- `base_doctype` - Declaration type (报关单类型)
- `base_enclosekind` - Attachment license type (随附单证)
- `base_exsettle` - Settlement method (结算方式)

### Main Data Tables
- `custs_head` - Declaration header (报关单表头)
- `custs_cont` - Declaration content (报关单商品项)
- `custs_box` - Container information (箱信息)
- `custs_enclose` - Attachments (随附单证)

### System Tables
- `system_user` - User accounts (系统用户)
- `system_log` - Operation logs (操作日志)

## Features

### Declaration Management
- Import declaration (进口报关)
- Export declaration (出口报关)
- Declaration editing and modification
- Declaration printing and preview
- Batch processing

### Base Data Management
- Company management
- Country/Region codes
- Currency codes
- HS Code classification
- Customs office codes

### System Management
- User management
- Role-based access control
- Environment settings
- Database connection configuration
- Operation logging

## Installation & Setup

### Prerequisites
1. .NET Framework 4.0
2. MySQL Server 5.1+
3. Visual Studio 2010 (for development)

### Database Setup
1. Create a MySQL database named `custsdb`
2. Import the SQL file:
   ```bash
   mysql -u root -p custsdb < Database/custsdb\ 20120509.sql
   ```

### Configuration
1. Open the application
2. Configure database connection (server address, username, password)
3. Set up initial user accounts

## Usage

### Login
1. Launch the application
2. Enter username and password
3. Select customs office and company

### Import Declaration
1. Click "进口报关" menu
2. Fill in declaration details
3. Add goods items
4. Save and submit

### Export Declaration
1. Click "出口报关" menu
2. Fill in declaration details
3. Add goods items
4. Save and submit

### Report Printing
1. Select declaration
2. Click print button
3. Preview and print

## Key Modules

### DBProvider
Handles all database connections and operations:
- `ConnectServer()` - Connect to MySQL server
- `GetAutoLogon()` - Get auto-login setting
- `SetLogonState()` - Manage login state

### FrmMDIMain
Main MDI container form with menu:
- Declaration management
- Base data management
- System settings
- Reports

### FrmInDocEdit / FrmOutDocEdit
Declaration entry forms with:
- Header information
- Goods list
- Container information
- Attachments

## License

This project is for educational/reference purposes.

## Notes

- The database schema contains reference data for Chinese customs declarations
- HS codes follow the Chinese Import/Export Commodity Classification System
- Currency and country codes follow international standards

