using Shareds.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Feature : IEntity
    {
        public int Id { get; set; }
        public int Title { get; set; }
        public int Description { get; set; }
    }
}
