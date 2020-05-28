# BethanysPieShop


### Setup Bethanys Pie Shop.

#### SQL db
- Create a sql server and database on azure and change the "DefaultConnection" in appsettings.json in the solution to the connection string.
- From the terminal in the solution folder run following migration commands:  
  - dotnet ef database update InitialMigration
  - dotnet ef database update CommentSectionAdded 

