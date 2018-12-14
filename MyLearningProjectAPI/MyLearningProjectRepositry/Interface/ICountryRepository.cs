using MyLearningProject.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearningProjectRepositry.Interface
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        Country GetById(int id);
    }
}
