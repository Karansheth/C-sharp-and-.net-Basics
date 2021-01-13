# C-sharp Basics

Project is made user friendly.

## Initially preference is asked to the user among -
1) Electricity Bill Calculator
2) Working of Generics in C#
3) Working of Linq in C#
4) Working of Extension Method

In the first preference, electricity bill calculator is made where customer id, customer name and total units consumed is asked.
On entering the above information, object of ElectricityBill class is created and electricity_bill_calculator method is called which will calculate the amount to be paid by the given customer.
If the units entered is less than zero then Invalid input message would be shown and program will terminate using Environment.Exit(0) method. Otherwise, the total amount will be calculated on the basis of charge per unit and adding surcharge of 15% if the amount is greater than Rs. 400.

In the second preference, Generics class is made. Inside Generics class add_or_concatenate method is created which will add two numbers if int inputs are passed and it will concatenate two strings if string inputs are passed.

In the third preference, user will be asked to enter n number of strings which he/she wants to concatenate. After taking strings from the user, using linq strings are sorted in ascending order in final_list list.

In the fourth preference, extension method GetValueOrDefault is used where if the boolean variable is defined as null then default value will be printed and if boolean variable is assigned true or false then default value will be hidden and original value will be printed.

