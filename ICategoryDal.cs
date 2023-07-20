using System;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
	public interface ICategoryDal
	{
		//CRUD
		//Type Name();
		List<Category> List();

		void Insert(Category p); //Crud metodları 

		void Uptade(Category p);

		void Delete(Category p);
	}
}

