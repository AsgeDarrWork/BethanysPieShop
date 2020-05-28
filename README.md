# BethanysPieShop


### Setup Bethanys Pie Shop.

#### SQL db (Creating a new db - optional)
- Create a sql server and database on azure and change the "DefaultConnection" in appsettings.json in the solution to the connection string.
- From the terminal in the solution folder run following migration commands:  
  - dotnet ef database update InitialMigration
  - dotnet ef database update CommentSectionAdded 
- Ensure that the ip is allowed in the sql server firewall

#### SQL db (Connecting to the existing db)
- leave the connection string "DefaultConnection" as it is.


#### Image classification search
- Nothing needed but for information is the connection string in the appsettings.json file and the Prediction-Key is in the FileUploadController.cs

#### Cognitive search
- Create a storage account
- Create a container named 'data'
- Upload all files in the folder blobstorage to the data container
- Create an Azure Cognitive Search
- After deployment go to the resource and click import data and create an indexer
  - Set the Data Source to 'Azure Blob Storage'
  - Name the datasource 
  - Click 'Choose an existing connection' and find the container data in the storage account
  - Add wanted cognitive skills under 'Add cognitive skills'
  - Last create the indexer by clicking submit under 'Create indexer'
- The indexer will now index all the data which takes a few moments.
- Use the 'Search Explorer' to search in the files or use the URL to create posts.


#### Storage prediction
- Nothing needed but for information is the connection string in the StorageRepository.cs file


