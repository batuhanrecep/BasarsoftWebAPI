using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDoorService
    {
        IDataResult<Door> GetById(int productId);
        IDataResult<List<Door>> GetList();
        IResult Add(Door door);
        IResult Delete(Door door);
        IResult Update(Door door);

    }
}
