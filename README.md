# ExRate
Small project using clean arch to show an integration with an API.

Project has six libraries, one console application and one test project. It basically show on the screen the exchange rate for:
-> EUR to USD
-> EUR to GBP
-> GBP to USD

1- Presentation layer:
  Console App:
  Interface to show rates to users.
  
  AppService Library:
  Orchestrate a call to an external service and filter data to return what is expected in the presentation layer
  
  ViewModels Library:
  Models used to move data end-to-end in the solutions
  obs.: As we are not persisting data (file, DB, etc.) I didn't create domain library and so there is not mapping from VM to Entities in this project.
  
2- Infra Layer
  - External
    DataFixer Integration:
    Added the integration with Data Fixer IO's API to get a list of rates to EUR.
  
  Bootstraper Library:
  Library to create the DI Container for the application(s).
  
  DI 
  Library to help coder to use IoC.
  
3- Test Application
  Unit Test:
  Application to test small pieces of the solution
  
4- Others
  Common library:
  Library to add common classes, enum, exception, middlewares, helpers and etc.
  
  
