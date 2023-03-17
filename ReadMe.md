# CC3D Challenge API (C# ASP.Net)
Welcome to the API documentation for the CC3D Challenge.  My submission is a simple Trivia display with Full-CRUD capabilities.  I wanted to do it this way to showcase not just a simple feature, but read/write capabilities in a persistent manner.

## Quick Description
One Piece is my most recent obsession, to the point where I am creating a Theory / Fan channel about the topic.  There is a ton of awesome trivia to the series, and it's generally fun stuff.  So to showcase my love, I have created for you a basic full-CRUD application that showcases some of that very information.

## Quick Setup Guide
* Inside Visual Studio, go to Tools-> NuGet Package Manager -> Package Manager Console
* In the Package Manager Console, run the following:
```
  dotnet build

   dotnet ef database update 
  // dotnet ef database update should create the database after the project is built

```
* This should also seed the database with the existing information, using negative keys (to identify seed vs non-seed data)
* Once ready, hit the Start / Play button in Visual Studio to start the application and get that info rendering!

If there are any missing package dependencies, install the following:
* Node for Node Package Manager (NPM)
* SQLServer
* Entity Framework Core

### RESTful
A single API call is great, and that's used to display the inforamtion.  But that said, data is not typically static like that, it may need to be changed at some point, or even deleted.  While not a part of the frontend at the moment, this API is already prepared for such an action to take place upon request!

With the current RESTful setup, we have 5 key RESTful routes for Trivia:
* Index (Get)
* Show (Get)
* Create (Create)
* Update (Patch)
* Delete (Delete)

However, I should note that for this current project, there are 2 in-use routes (accessible in the companion React UI)
* Index
* ShowRandom

## Models
Since this is meant to be a simple API, there is only one model that we are using here, Trivia.


### Trivia
Trivia is the main piece of information here.  It has only 2 fields, and only one relevant for displaying.  Since data needs to be seeded, all seed data has a unique negative (non-zero) Id

* Id (standard databse Id)
* Text, which is the string element for a single piece of trivia


## Controllers
There is only one core controller to this part of the application, that being the TriviaController.  Due to the full-CRUD nature of this application, the controller contains 5 basic actions.  While the frontend at the moment does not have access to the full-CRUD, the built-in Swagger UI that appears once the server runs does have this capability (as well as renderable JSON-shaped responses)

## Entity Framework Setup
Since this was a blank API project, many of the features were added manually.  The Entity framework core had the following setup:

### appsettings.json
* in the appsettings.json file, a key of ConnectionStrings has been added, which has a key of DefaultConnection
* That "DefaultConnection" key is used by our application to connect to a database, so that data is persisted

```

  "ConnectionStrings": {
    "DefaultConnection": "server=localhost\\sqlexpress;database=triviadb;trusted_connection=true;encrypt=false;"
  },

```
* encrypt=false; has been added to allow for untrusted authorities, firebase authentication will take care of much of that for the time being.
* In a production environment, a sleaker and cleaner solution would likely need to be implemented for the sake of security

### Program.cs
* Program.cs is the file responsible for running the API application
* The original projectname.Data package (OPTriviaAPI.Data) has been made global, so that the package is not needed to be added manually places
* The Microsoft.entityFrameworkCore has been added as well globally
* Under the AddControllers, a new bbuilder service method has been added to create the data context using the express SQL server
* Data/DataContext.cs is the main configuration file for the database itself

### Migrations
Migrations were not created manually, rather they were generated using the Package Manager Console which has access to various dotnet methods.

* The dotnet ef commands were used to both install the Entity Framework (post-initial install), and to generate the Migrations.
* Migrations should not be created manually, since creating them through the terminal will give them not only formatting and builerplate, but to also give a timestamp to keep migrations in the order in which they are created (at the point of development)
* When these migrations run, it will create the specififed table or run any table/column changes based on migration parameters
* Also, when creating the initial migration, a follder named /Migrations will be auto-generated with the appropriate files inside
* It is best to create a model before the migration, since creating the migration afterward will automatically setup the column-data for the models based on the class properties
* They will also set the primary key (for looking up data) to the Id field set by the class manually.  This can be overriden on request, but is there for the sake of simplicity
* After being run, the SQL database will be able to use the generated Schema to search for data (which is normally done in controller or model actions, depending on the context)

### Seeding
Since the main bit of this application only involves rendering the Trivia, which has only a single field.  All of these are stored in a single array of strings, which is then iterated over using a simple loop to create the actual database entries.  I made a simple array of strings which is iterated over to generate individual Trivia objects as entries in our local DB.  Seeding should take place during the setup phase of the application

### CORS
Core is currently setup to only take localhost:3000 and 3001 (which sometimes runs if something is taking up port 3000).  This service uses https://localhost/7047 rather than a standard http, for this current setup.

Cors has also been setup in Program.Cs using the MyOrigins variable to ensure the consistency of string-key values as arguments.


### EFC in Program.Cs
The EFC is enabled in Program.Cs under the builder.services.AddDBContext method, which connects the EFC to the DefaultConnection key setup in appsettings.json.  This method connects to the built-in SQLServer.


## I do hope you like what you see
If you have any problems setting up this application, please let me know so I can help with any confusion.  This obviously works on my machine perfectly, but as with any technology, that may not be the case on yours.  I can't wait to talk to you guys again, your company rocks!  3D printing is the future.