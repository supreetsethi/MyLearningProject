﻿using MyLearningProject.Model.Model;
using MyLearningProjectRepositry.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLearningProjectRepositry.Class
{
    public class PersonRepository : GenericRepository<Person>, IPersonRepository
    {
        public PersonRepository(DbContext context)
            : base(context)
        {

        }

        public override IEnumerable<Person> GetAll()
        {
            return _entities.Set<Person>().Include(x => x.Country).AsEnumerable();
        }

        public Person GetById(long id)
        {
            return _dbset.Include(x => x.Country).Where(x => x.Id == id).FirstOrDefault();            
        }
    }
}
