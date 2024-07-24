using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFCategoryRepository : GenericRepository<Category> , ICategoryDal
    {
        public EFCategoryRepository(Context context) : base(context)
        {

        }

        //Buraya  public DbSet<Category> Categories { get; set; } gelebilir 

    }
}
