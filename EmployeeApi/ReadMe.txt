# Web Api Exercise

Created webapi project and EmployeeController. Added various action methods to support GetAll, Get, Post, Put and Delete Employee operations.  

Created Employee class under Models folder which have data like Id, Name, Age and Role.  

Data is stored as static field in EmployeeController. 

Api endpoints are called from postman for testing and export those requests.

Custom route path is set to "api/employee/{controller}/{id}" in WebApiConfig.cs file.

In the employee Controller following methods are implemented,

1) GetAll method to get information of all employees in a list named as "emp".
2) Get method to get information of any one particular employee by passing his id.
3) Post method to add new employee in the list and then returning the updated list of employees 
working in the company.
4) Put method to update information of any one particular employee and returning the updated 
information of employees working in the company.
5) Delete to delete one employee from the employee list of the company by passing his employee id.
