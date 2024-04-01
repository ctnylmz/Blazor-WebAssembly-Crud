using Entities.Concrete;
using Shareds.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IFeatureService
    {
        IResult Add(Feature feature);
        IResult Update(Feature feature);
        IResult Delete(Feature feature);
        IDataResult<List<Feature>> GetList();
        IDataResult<Feature> GetById(int id);
    }
}
