using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService

    {
        ICategoryDal _categoryDal;
       
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public IDataResult<List<Category>> GetAll()
        {
            //Is kodlari
            return new SuccessDataResult<List<Category>>( _categoryDal.GetAll());
        }

        public IDataResult<Category> GetByCategory(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
        }
        private IResult CheckIfCategoryNumberMoreThanFiveteen(int categoryId)
        {
            var result = _categoryDal.GetAll(c => c.CategoryId == categoryId).Count;
            if (result>=15)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
        
    }
}
