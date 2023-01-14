# Pierre's Sweet and Savory Treats

#### Creates bakery shop that tracks treat and flavors relationships for authenticated users

#### By [Anton Ch](https://github.com/anton3ch)

## Technologies Used

- CSS
- HTML
- C#
- .NET 5.0
- ASP.Net
- Razor
- dotnet script REPL
- MySQL
- Workbench
- EF Core

## Description

Bakery shop tracks treat and flavor relationships for authenticated users.

## Setup/Installation Requirements

- Clone this repository to your Desktop:
  1. Your computer will need to have GIT installed. If you do not currently have GIT installed, follow [these](https://docs.github.com/en/get-started/quickstart/set-up-git) directions for installing and setting up GIT.
  2. Once GIT is installed, clone this repository by typing following commands in your command line:
     ```
     ~ $ cd Desktop
     ~/Desktop $ git clone https://github.com/anton3ch/Treats.Solution.git
     ~/Desktop $ cd Treats.Solution
     ```
- Install the [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- Install Packages for EF Core and a tool to update databases:
  ```
  ~/Desktop/Treats.Solution $ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
  ~/Desktop/Treats.Solution $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0-alpha.2
  ~/Desktop/Treats.Solution $ dotnet tool install --global dotnet-ef --version 6.0.1
  ```
- Create .gitignore file:
  ```
   ~/Desktop/Treats.Solution/ $ touch .gitignore
   ~/Desktop/Treats.Solution/ $ echo "*/obj/
   */bin/
   */appsettings.json" > .gitignore
  ```
- Create appsettings.json file:
  ```
   ~/Desktop/Treats.Solution $ cd Treats
   ~/Desktop/Treats.Solution/Treats $ touch appsettings.json
   ~/Desktop/Treats.Solution/Treats $ echo '{
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=anton_ch_bakery;uid=root;pwd=[PASSWORD];"
      }
    }' > appsettings.json
  ```
  [PASSWORD] is your password

  - Create MySQL database
  ```
    Open MySQLWorkbench, log in, and connect to your local server
    Go to the Administration tab, select Data Import/Restore
    Select Import from Self Contained File
    Select ../anton_ch_Treats.sql from the top level of the cloned repository, Treats.
    Select "New..." and set new schema name to anton_ch_Treats
    Select 'Start Import'
    Now you have a copy of the project database on your machine.
  ```

- Update Database:
  ```
  ~/Desktop/Treats.Solution/Treats $ dotnet ef database update
  ```
- Build the project:
  ```
   ~/Desktop/Treats.Solution/Treats $ dotnet build
  ```
- Run the project
  ```
   ~/Desktop/Treats.Solution/Treats $ dotnet run
  ```
- Visit [http://localhost:5000](http://localhost:5000) to try this application

## Known Bugs



## License

[ISC](https://opensource.org/licenses/ISC)

Permission to use, copy, modify, and/or distribute this software for any purpose with or without fee is hereby granted, provided that the above copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.

Copyright (c) 01/06/2023 Anton Ch