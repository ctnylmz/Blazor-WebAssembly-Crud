using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Shareds.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DiscountManager : IDiscountService
    {
        IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public IResult Add(Discount discount)
        {
            _discountDal.Add(discount);
            return new SuccessResult("Başarıyla Eklendi");
        }

        public IResult Delete(Discount discount)
        {
            _discountDal.Delete(discount);
            return new SuccessResult("Başarıyla Silindi");
        }

        public IDataResult<Discount> GetById(int id)
        {
            return new SuccessDataResult<Discount>(_discountDal.Get(c => c.Id == id));
        }

        public IDataResult<List<Discount>> GetList()
        {
            return new SuccessDataResult<List<Discount>>(_discountDal.GetList().ToList(), "Başarıyla Veriler Geldi");
        }

        public IResult Update(Discount discount)
        {
            _discountDal.Update(discount);
            return new SuccessResult("Başarıyla Güncellendi");
        }
    }
}
