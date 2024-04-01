using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using Shareds.DataAcces.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repository
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, QrKitchenContext>, ICategoryDal
    {

    }
}
