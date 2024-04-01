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
    public class FeatureManager : IFeatureService
    {
        IFeatureDal _featureDal;

        public FeatureManager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public IResult Add(Feature feature)
        {
            _featureDal.Add(feature);
            return new SuccessResult("Başarıyla Eklendi");
        }

        public IResult Delete(Feature feature)
        {
            _featureDal.Delete(feature);
            return new SuccessResult("Başarıyla Silindi");
        }

        public IDataResult<Feature> GetById(int id)
        {
            return new SuccessDataResult<Feature>(_featureDal.Get(c => c.Id == id));
        }

        public IDataResult<List<Feature>> GetList()
        {
            return new SuccessDataResult<List<Feature>>(_featureDal.GetList().ToList(), "Başarıyla Veriler Geldi");
        }

        public IResult Update(Feature feature)
        {
            _featureDal.Update(feature);
            return new SuccessResult("Başarıyla Güncellendi");
        }
    }
}
