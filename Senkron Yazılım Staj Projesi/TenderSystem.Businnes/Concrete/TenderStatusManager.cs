using System;
using System.Collections.Generic;
using System.Text;
using TenderSystem.Business.Abstract;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.DataAccess.Abstract;
using TenderSystem.DataAccess.Concrete.EntityFramework;

namespace TenderSystem.Business.Concrete
{
    public class TenderStatusManager : ITenderStatusService
    {
            private ITenderStatusDal _tenderStatusDal;

            public TenderStatusManager(ITenderStatusDal tenderStatusDal)
            {
                _tenderStatusDal = tenderStatusDal;
            }
        
        public Result GetAll()
        {
            try
            {
                var data = _tenderStatusDal.GetList();
                return new SuccessResult(data, "Tender statuses listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Tender statuses could NOT listed." + exception.Message);
            }

            
        }

        public Result GetById(int tenderStatusId)
        {
            try
            {
                var data = _tenderStatusDal.Get(a => a.Id == tenderStatusId);
                if (data == null)
                {
                    return new ErrorResult("There is no tender status has this Id.");
                }

                return new SuccessResult(data, "Tender status listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Tender status could NOT listed." + exception.Message);
            }

            
        }
    }
}
