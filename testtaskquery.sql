SELECT Product.Name, Category.Name
FROM Product
LEFT JOIN ProductCategories
	ON Product.id = ProductCategories.ProductId
LEFT JOIN Category
	ON ProductCategories.CategoryId = Category.id