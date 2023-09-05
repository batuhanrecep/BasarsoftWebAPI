using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class DoorService : IDoorService
    {

        private IDoorDal _doorDal;

        public DoorService(IDoorDal doorDal)
        {
            _doorDal = doorDal;
        }


        public IDataResult<Door> GetById(int doorId)
        {

            // EntityFramework'e bağımlı
            //EfDoorDal doorDal = new EfDoorDal();
            //return doorDal.Get(p => p.DoorId == doorId);


            // doorDal.Get yollamak yerine _doorDal.Get yollayarak dependency Injectıon Yaptık
            return new SuccessDataResult<Door>(_doorDal.Get(p => p.DoorId == doorId));
        }

        public IDataResult<List<Door>> GetList()
        {
            return new SuccessDataResult<List<Door>>(_doorDal.GetList().ToList());
        }


        public IResult Add(Door door)
        {

            //Business Codes
            //
            //

            _doorDal.Add(door);
            return new SuccessResult(Messages.DoorAdded);
        }

        public IResult Delete(Door door)
        {

            //Business Codes
            //
            //              

            _doorDal.Delete(door);
            return new SuccessResult(Messages.DoorDeleted);
        }

        public IResult Update(Door door)
        {
            _doorDal.Update(door);
            return new SuccessResult(Messages.DoorUpdated);
        }
    }
}
