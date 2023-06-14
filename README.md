# Simple WEB with .NET (c#)

 <p align="center">
  <img src="https://github.com/AriWiraSaputra/.netProgram/blob/main/img/index-home.gif" >
 </p>

 To create a website that with .NET (c#), following are the steps:

## 🚩 Install Visual Studio 2019 Community Edition

1. Download and install Visual Studio 2019 Community Edition from the official Microsoft website.
2. Follow the installation steps provided by the installer.

## 💡 Create an ASP.NET Core MVC Project:

1. Open Visual Studio 2019.
2. Select `Create a new project`.
3. Choose `ASP.NET Core Web Application` from the project options.
4. Provide a name for your project and specify the storage location.
5. Select `ASP.NET Core 6.0` as the target version.
6. Choose the `Web Application (Model-View-Controller)` template.
7. Click `Create` to create the project.

## 🔖 Configure Connection to SQL Server Database:

1. Open the appsettings.json file in your project.
2. Edit the `DefaultConnection` section according to the SQL Server database connection information you are using.

## ⚙️ Create Data Models 👇

1. Create a `Models` folder in your project.
2. Create a model class for the `Agent` entity with appropriate properties such as RegDate, RegStatus, Name, etc.

## Create Controller and Views for Agent Registration Page

1. Create a `Controllers` folder in your project.
2. Create a controller named "AgentsController" using the "MVC Controller - Empty" template.
3. Implement the "Create" action to handle the agent registration page.
4. Create a "Views/Agents" folder in your project.
5. Create a "Create.cshtml" view inside the "Views/Agents" folder to display the agent registration form.
6. Use the HTML code you provided earlier to build the form view.

## Create Controller and Views for List of Registration Results Page:

1. Create a controller named "RegistrationController" using the "MVC Controller - Empty" template.
2. Implement the "Index" action to display the list of registration results.
3. Create an "Index.cshtml" view inside the "Views/Registration" folder to display the list of registrations.

## Create Controller and Views for View Registration Details Page:

1. Create a controller named "DetailController" using the "MVC Controller - Empty" template.
2. Implement the "View" action to display the registration details.
3. Create a "View.cshtml" view inside the "Views/Detail" folder to display the registration details.

## Add Routes for Each Controller and View:

1. Open the Startup.cs file in your project.
2. Add the appropriate routes in the Configure method using endpoints.MapControllerRoute().


## Migrate and Synchronize the Database:

1. Open the Package Manager Console in Visual Studio.
2. Run the command Add-Migration InitialCreate to create the initial migration.
3. Run the command Update-Database to apply the migration to the SQL Server database.


## Add an Attractive UI Design:

1. Use CSS, Bootstrap, or other UI libraries to enhance the visual appearance of your pages.
2. Customize the layout, colors, and other design elements to your preference.
3. Use relevant images and icons to improve the user experience.


## Test and Debug:

1. Run your project to test the functionality and appearance of each page.
2. Fix and debug any errors or issues that arise.
3. These are the general steps to create a website that meets your criteria using C# .NET Core 3.1 and SQL Server database. You can customize and further develop this project according to your needs and preferences.
    
## 💞 Image and Video 

The agent registration page is used to register new agents in the system. Then navigate to the "Index" feature. This page includes the following features:

  <p align="center">
     <img src="https://github.com/AriWiraSaputra/.netProgram/blob/main/img/Index.png" >
 </p>

 1. Create Agent: Allows users to create a new entry for an agent by filling out an agent registration form.
  
    <p align="center">
     <img src="https://github.com/AriWiraSaputra/.netProgram/blob/main/img/Creat%20agen.png" >
     <img src="https://github.com/AriWiraSaputra/.netProgram/blob/main/img/index-creat.gif">
    </p>
  
 2. Agent Detail: Displays detailed information about a specific agent, including data such as name, address, date of birth, and more.

    <p align="center">
       <img src="https://github.com/AriWiraSaputra/.netProgram/blob/main/img/Details.png" >
       <img src="https://github.com/AriWiraSaputra/.netProgram/blob/main/img/Index%20-%20Detail.gif">
    </p>
 
 3. Edit Agent: Enables users to edit the information of a previously registered agent. Users can modify or update data such as address, phone number, or other information.

    <p align="center">
       <img src="https://github.com/AriWiraSaputra/.netProgram/blob/main/img/edit.png" >
       <img src="https://github.com/AriWiraSaputra/.netProgram/blob/main/img/Index%20-%20edit.gif">
    </p>
 
 4. Delete Agent: Provides an option to remove a specific agent entry from the system if needed.

   <p align="center">
       <img src="https://github.com/AriWiraSaputra/.netProgram/blob/main/img/delete.png" >
       <img src="https://github.com/AriWiraSaputra/.netProgram/blob/main/img/Hasil%20Deleted.png" >
       <img src="https://github.com/AriWiraSaputra/.netProgram/blob/main/img/Index%20-%20delete.gif">
    </p>

The agent registration page serves as a central control for agent data management, allowing users to perform actions such as creating, viewing details, editing, and deleting agent data. It facilitates efficient management and maintenance of agent information for users.


  

<!-- LICENSE -->
## 📋 License

Distributed under the MIT License. See `LICENSE.txt` for more information.






