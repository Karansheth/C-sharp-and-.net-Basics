Whole Assignment is done following coding guidelines of TR.

Model with class name Employee is made having data Id, Name, Age, and Role of an Employee.

Custom route path is set to "api/employee/{controller}/{id}" in WebApiConfig.cs file.

As in this assignment we donot have to deal with database, I made list consisting information of
five employees.

In the employee Controller following methods are implemented,

1) GetAll method to get information of all employees in a list named as "emp".
2) Get method to get information of any one particular employee by passing his id.
3) Post method to add new employee in the list and then returning the updated list of employees 
working in the company.
4) Put method to update information of any one particular employee and returning the updated 
information of employees working in the company.
5) Delete to delete one employee from the employee list of the company by passing his employee id.
