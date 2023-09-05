using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.Extensions.Configuration;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfDoorDal:EfEntityRepositoryBase<Door, BasarsoftDbContext>, IDoorDal
    {

    }
}
