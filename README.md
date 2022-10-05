# BudgetTracker

### An ASP.Net Core Web App MVC Project using Razor pages

The code first SQL database was implemented using the following NuGet packages:
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

CRUD implementation for the Transaction model with client side validation and Razor pages.

The transaction has a currency dropdown as an input, so the user can not create or update transactions unless there is at least one currency, and the "Add New Transaction" button is replaced with "Add new Currency".

The currency controller and view has been generated automatically, and left unchanged, to show that they have been implemented through scaffolding.

The Bootswatch Solar theme was used to give the project a consistent look
