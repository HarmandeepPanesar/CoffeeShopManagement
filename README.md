A Management System for a Coffee Shop in C# using WinForms (clean, well-maintainable code)
    
**FEATURES**:

--a robust and efficient C# application using a SQL database.

--Implemented functionalities for adding, editing, and deleting data about each aspect of the program.

--Incorporated search, sort, and filter functionalities.

--Designed and developed in an intuitive user interface for ease of use.

**Customer**

**Customer Entity**: Represents the structure of your Customer data. 

**DbContext**: Updated to include a DbSet<Customer>.

**Customer Form**: Designed with a UI to input and display customer data.

**Code Behind**: Logic for adding and loading customers using Entity Framework.
![Screenshot 2024-12-13 145055](https://github.com/user-attachments/assets/b7ca71e2-d7a3-4735-82fa-3b2df5a19ffa)


**Product**

**Product Entity**: Represents the structure of your Product data.

**DbContext**: Updated to include a DbSet<Product>.

**Product Form**: Designed with UI elements to input and display product data.

**Code Behind**: Logic for adding and loading products using Entity Framework.
![Screenshot 2024-12-13 145633](https://github.com/user-attachments/assets/6b2597eb-ec25-4807-af22-10b329377326)

**Orders**

**Order Entity**: Represents the structure of your order data.

**OrderItem Entity**: Represents the structure of order items linked to orders.

**DbContext**: Updated to include DbSet<Order> and DbSet<OrderItem>.

**Order Form**: Designed with UI elements to input and display order data.

**Code Behind**: Logic for adding and loading orders using Entity Framework.
![Screenshot 2024-12-13 150408](https://github.com/user-attachments/assets/0c912e2b-c5d9-4f75-afcd-5d6ef7b7af56)


**OrderItems**

**OrderItem Entity**: Represents the structure of your order item data.

**DbContext**: Already includes DbSet<OrderItem>.

**OrderItem Form**: Designed with UI elements to input and display order item data.

**Code Behind**: Logic for adding order items to orders and loading items for display.
![Screenshot 2024-12-13 145600](https://github.com/user-attachments/assets/8ceb1569-e6d0-44aa-82ad-e8d53b0be1b3)
