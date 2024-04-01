using Entities.Concrete;
using Shareds.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IDiscountService
    {
        IResult Add(Discount discount);
        IResult Update(Discount discount);
        IResult Delete(Discount discount);
        IDataResult<List<Discount>> GetList();
        IDataResult<Discount> GetById(int id);
    }
}
