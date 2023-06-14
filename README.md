# Simple WEB with .NET (c#)

A simple Sales Inventory Application (Administrator) built using _**Vue.js**_ as the frontend and _**Node.js**_ as the backend.
 <p align="center">
  <img src="https://github.com/AriWiraSaputra/Inventory-app-vue-node.js/blob/main/Img/vue.gif" width="280">
  <img src="https://github.com/AriWiraSaputra/Inventory-app-vue-node.js/blob/main/Img/nodejs.gif" width="280">
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

### 1. Item Module
   The Item Module is a module used to manage item data in the Sales Inventory application. The module consists of the following fields or attributes:
    
   - `item_name`: The name or title of the item.
   - `unit`: The unit of measurement for the item, such as kilograms (kg) or pieces (pcs).
   - `stock`: The quantity of the item in stock.
   - `unit_price`: The price per unit of the item.
   - `item_image`: The image or photo of the item.

   With the Item Module, users can manage information about items, including their name, unit, stock, unit price, and image.
   
  <p align="center">
    <img src="https://github.com/AriWiraSaputra/Inventory-app-vue-node.js/blob/main/Img/fromItem.png">
    <img src="https://github.com/AriWiraSaputra/Inventory-app-vue-node.js/blob/main/Img/inventory-gif.gif">
    <img src="https://github.com/AriWiraSaputra/Inventory-app-vue-node.js/blob/main/Img/fromItem2.png">
  </p>


### 2. Customer Module
   The Customer Module consists of several fields used to manage customer data. Here is a brief explanation of the fields found in the Customer Module:
   
   - `Name`: Field to store the customer's name.
   - `Contact`: Field to store contact information for the customer, such as a phone number.
   - `Email`: Field to store the customer's email address.
   - `Address`: Field to store the customer's complete address.
   - `Discount`: Field to store information about the discount given to the customer.
   - `Discount` Type: Field to determine the type of discount used. There are two types of discounts available:
     - a. `Percentage`: The discount is expressed as a percentage of the price.
     - b. `Fixed Discount`: The discount is expressed as a fixed amount subtracted from the price.
   
   Additionally, there is a field called KTP (identification image) used to store the customer's identification image.
   With the Customer Module, you can manage customer data including their name, contact information, email, address, discount details, discount type, and KTP image.

  <p align="center">
      <img src="https://github.com/AriWiraSaputra/Inventory-app-vue-node.js/blob/main/Img/fromCustomers1.png">
      <img src="https://github.com/AriWiraSaputra/Inventory-app-vue-node.js/blob/main/Img/inventory-app-Customer_gif.gif">   
      <img src="https://github.com/AriWiraSaputra/Inventory-app-vue-node.js/blob/main/Img/fromCustomers.png">
  </p>

### 3. Sales Module
   The Sales Module consists of several fields used to manage sales data. Here are the details of the fields in the Sales Module:
   
   - `Code Transaksi`: Field to store the transaction code.
   - `Tanggal Transaksi`: Field to store the transaction date.
   - `Customer`: Field to store the customer associated with the sale.
   - `Item (Multiple)`: Field to store multiple items included in the sale.
   - `Qty`: Field to store the quantity of each item.
   - `Total Diskon (Auto Fill)`: Field to automatically calculate the total discount applied.
   - `Total Harga (Auto Fill)`: Field to automatically calculate the total price.
   - `Total Bayar`: Field to store the total payment amount.

   <p align="center">
       <img src="https://github.com/AriWiraSaputra/Inventory-app-vue-node.js/blob/main/Img/fromsales2.png">
       <img src="https://github.com/AriWiraSaputra/Inventory-app-vue-node.js/blob/main/Img/inventory-app-sales-gif.gif">  
       <img src="https://github.com/AriWiraSaputra/Inventory-app-vue-node.js/blob/main/Img/fromsales.png">
   </p>   
   
   Additional Notes:
   - The calculation of the total price is adjusted based on the discount applied in the Customer Module (if applicable).
   - The quantity of items purchased should not exceed the available stock.
   - The stock is reduced when a purchase is made.

   With the Sales Module, you can manage sales transactions by recording the transaction code, date, associated customer, items purchased, quantity, total discount, total price, and payment amount. The module ensures accurate calculations and stock management during sales transactions.

<!-- LICENSE -->
## 📋 License

Distributed under the MIT License. See `LICENSE.txt` for more information.






