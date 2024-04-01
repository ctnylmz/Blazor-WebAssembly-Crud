using Entities.Concrete;
using Shareds.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISocialMediaService
    {
        IResult Add(SocialMedia socialMedia);
        IResult Update(SocialMedia socialMedia);
        IResult Delete(SocialMedia socialMedia);
        IDataResult<List<SocialMedia>> GetList();
        IDataResult<SocialMedia> GetById(int id);
    }
}
