# ClassLibrary1Mindbox
Code is answer for question 2 

SQL request is answer for question 3

SELECT Product.Name, Categories.Name
FROM 
Product LEFT OUTER JOIN Categories
ON Product.ProductID = Categories.ProductID
