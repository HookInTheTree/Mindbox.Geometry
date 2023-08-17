
Select 
	P.Name + ' - ' + isnull(C.Name, '') as Name
from ProductsCategories PC
Right Join Products P 
	on P.Id = PC.ProductId
Left join Categories C
	on C.Id = PC.CategoryId
