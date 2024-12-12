A Management System for a Coffee Shop in C# (clean, well-maintainable code)
FEATURES:
-a robust and efficient C# application using a SQL database.
-Implemented functionalities for adding, editing, and deleting data about each aspect of the program.
-Incorporated search, sort, and filter functionalities.
-Designed and developed in an intuitive user interface for ease of use.

**Customer**
**Customer Entity** Entity: Represents the structure of your Customer data.
**DbContext**: Updated to include a DbSet<Customer>.
**Customer Form**: Designed with a UI to input and display customer data.
**Code Behind**: Logic for adding and loading customers using Entity Framework.

**Product**
**Product Entity**: Represents the structure of your Product data.
**DbContext**: Updated to include a DbSet<Product>.
**Product Form**: Designed with UI elements to input and display product data.
**Code Behind**: Logic for adding and loading products using Entity Framework.

**Orders**
**Order Entity**: Represents the structure of your order data.
**OrderItem Entity**: Represents the structure of order items linked to orders.
**DbContext**: Updated to include DbSet<Order> and DbSet<OrderItem>.
**Order Form**: Designed with UI elements to input and display order data.
**Code Behind**: Logic for adding and loading orders using Entity Framework.

**OrderItems**
**OrderItem Entity**: Represents the structure of your order item data.
**DbContext**: Already includes DbSet<OrderItem>.
**OrderItem Form**: Designed with UI elements to input and display order item data.
**Code Behind**: Logic for adding order items to orders and loading items for display.
