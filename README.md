# BethanysPieShop


### Setup Bethanys Pie Shop.

#### SQL db (creation. If you want your own)
- Create a sql server and database on azure and change the "DefaultConnection" in appsettings.json in the solution to the connection string.
- From the terminal in the solution folder run following migration commands:  
  - dotnet ef database update InitialMigration
  - dotnet ef database update CommentSectionAdded 
- Ensure that the ip is allowed in the sql server firewall

#### SQL db (connect)
- change the "DefaultConnection" in appsettings.json in the solution to the following connection string.
  - "DefaultConnection": "Server=tcp:bps-sql-server.database.windows.net,1433;Initial Catalog=BethanysPieShop;Persist Security Info=False;User ID=bethanyadmin;Password=Pa55w0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"


#### Image classification search
