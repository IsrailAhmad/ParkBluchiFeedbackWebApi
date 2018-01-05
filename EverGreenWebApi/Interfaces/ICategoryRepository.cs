using EverGreenWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EverGreenWebApi.Interfaces
{
    public interface ICategoryRepository:IDisposable
    {
        IEnumerable<CategoryModel> GetAllCategoryList(int menuid,int storeid);
        IEnumerable<CategoryModel> GetAllCategoryList();
        CategoryModel AddNewCategory(CategoryModel model);
    }
}