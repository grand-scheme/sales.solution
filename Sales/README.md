## _[ PIERRE'S SALE'S TRACKER ]_  

### _A C# MVC Application featuring RAZOR_

### _December 18th, 2020_  
----------------------
Description:
----------------------
This product is an MVC application where you play the part of Pierre the Parisian Boulangerie. Pierre needs help keeping tabs on all the other cafes and restaurants he supplies his pastries to, so this is his new tool of the trade. 

Through this application, you-as-Pierre can create different "Vendors" you sell to, write short biographies about each one, and determine when they get their usual delivery. Once you've gotten that set up, you can create a series of separate orders for those vendors, giving them handy titles to job your memory, a freeform text input in order to get all loaves in one basket, and set your own price for the total. 

----------------------
Project Criteria:  
----------------------

As referenced from the [Epicodus](https://epicodus.com) program's curriculum:  

> Pierre was so pleased with your console app for his bakery that he wants to hire you for a new project. This time, he would like you to build him an MVC application to help him track the `Vendor`s that purchase baked goods from him and the `Order`s belonging to those `Vendor`s.
>
> For example, Pierre might supply croissants to a `Vendor` called "Suzie's Cafe" once a week. Pierre may want to create a new `Vendor` to represent the cafe and add new `Order`s to it to help keep track of his expanding business relationships.
> 
>> Use Razor to display information on each page.
>
>> Create a `Vendor` class. 
>> This class should include properties for the `Vendor`'s name, a description of the `Vendor`, a `List` of `Order`s belonging to the `Vendor`, and any other properties you would like to include.
>
>> Create an `Order` class. 
>> This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.
>
>> The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a `Vendor`s page.
>
>> The `Vendor`s page should contain a link to a page presenting Pierre with a form he can fill out to create a new `Vendor`. 
>
>> After the form is submitted, the new `Vendor` object should be saved into a static `List` and Pierre should be routed back to the homepage.
>
>> Pierre should be able to click a `Vendor`'s name and go to a new page that will display all of that `Vendor`'s `Order`s.
>
>> Pierre should be provided with a link to a page presenting him with a form to create a new `Order` for a particular `Vendor`. Hint: The route for this page might look something like: "/`Vendor`s/1/`Order`s/new".

-------------------------------
Known Issues / Bugs:
----------------------
None currently known.

-------------------------------
Setup:
----------------------

 Prior to downloading:
> **Note:** You will need to have [.NET](https://dotnet.microsoft.com/download/dotnet-core/2.2) installed on your machine prior to downloading this project.\
 This project was coded using `.NET Version: 2.2.203`.\
 While you do not have to have this specific version installed locally, compatibility cannot be guaranteed with earlier or later releases of the .NET core. 

----------------------
To view locally on your machine:  
----------------------
1. Find the green **Code** button above the file list on this project's [main GitHub repository page](https://github.com/grand-scheme/Sales.Solution).
2. Select the button to open a drop-down menu. Select "Open with GitHub Desktop" or, if you do not have this program installed, download the compressed .zip file.
3. Extract the .zip file to your local machine.
4. Directions were accurate as of December 18th, 2020. If GitHub has since changed their protocol, please see [the GitHub help docs](https://docs.github.com/en) for up-to-date information.

----------------------
To clone this project to your machine: 
----------------------
> The following directions are based on Git Bash for a Windows machine; you may have to adjust terminology based on your local specs.
1. Launch your terminal of choice. 

2. Navigate to the containing directory into which you would like to clone this project.

3. Input:\
`$ git clone https://github.com/grand-scheme/Sales.Solution`

4. This will clone the project to a folder called "Sales.Solution." If you wish to clone it into a directory of a different name, append the new folder name to the end of the string, like so:\
`$ git clone https://github.com/grand-scheme/Sales.Solution NEW-FOLDER`\
where `NEW-FOLDER` is where you would type the name of the folder you would like to use.\
**Note:** It is highly recommended that your destination folder retains the name `Sales.Solution`.  

5. Directions were accurate as of Dec. 18th, 2020. If GitHub has since changed their protocol, please see [the GitHub help docs](https://docs.github.com/en) for up-to-date information.

----------------------
To run this project on your machine:
----------------------
1. Once you have the project locally stored, navigate to its main directory in your terminal of choice. By default, this is `Sales.Solution`. 

2. Navigate to the subfolder `Sales`.

3. In your command line, input\
`$ dotnet restore`\
`$ dotnet build`

4. Navigate to the subfolder `Sales.Tests`.\
From step 3, you can do that by entering the following into your command line:\
`cd ../Sales.Tests`

5. Input:\
`$ dotnet restore`\
`$ dotnet build`

6. Navigate back to subfolder `Sales`\
`cd ../Sales`\
`$ dotnet run`

7. At this point, the command terminal should inform you that a local host has been launched for this program at `http://localhost:5000`. Navigate to this url in your browser of choice. 
-------------------------------
To engage with the test suite:
-------------------------------
> Note: it is recommended to run the project and the previously-enumerated dotnet commands before engaging with the test suite.
1. Navigate to the main directory in your terminal of choice. By default, this is `Sales.Solution`.

2. Navigate to the subfolder `Sales.Tests`.

3. In your command line, input\
`$ dotnet test`

4. After a moment, the tests should execute.
-------------------------------
Technologies Used:  
-------------------------------
- Coded in Visual Studio Code.
- .NET Core SDK Version: 2.2.203
- Microsoft.AspNetCore.Razor.Design Version: 2.2.0
-------------------------------
License
-------------------------------
- _GNU AGPLv3_  
- Project copyright (c) 2020 **_Shannon Grantski_**  
- Project criteria quoted text copyright (c) 2020 Epicodus, Inc.