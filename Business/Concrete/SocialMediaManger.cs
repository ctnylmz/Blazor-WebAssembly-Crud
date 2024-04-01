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
    public class SocialMediaManger : ISocialMediaService
    {
        ISocialMediaDal _socialMediaDal;

        public SocialMediaManger(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }

        public IResult Add(SocialMedia socialMedia)
        {
            _socialMediaDal.Add(socialMedia);
            return new SuccessResult("Başarıyla Eklendi");
        }

        public IResult Delete(SocialMedia socialMedia)
        {
            _socialMediaDal.Delete(socialMedia);
            return new SuccessResult("Başarıyla Silindi");
        }

        public IDataResult<SocialMedia> GetById(int id)
        {
            return new SuccessDataResult<SocialMedia>(_socialMediaDal.Get(c => c.Id == id));
        }

        public IDataResult<List<SocialMedia>> GetList()
        {
            return new SuccessDataResult<List<SocialMedia>>(_socialMediaDal.GetList().ToList(), "Başarıyla Veriler Geldi");
        }

        public IResult Update(SocialMedia socialMedia)
        {
            _socialMediaDal.Update(socialMedia);
            return new SuccessResult("Başarıyla Güncellendi");
        }
    }
}
