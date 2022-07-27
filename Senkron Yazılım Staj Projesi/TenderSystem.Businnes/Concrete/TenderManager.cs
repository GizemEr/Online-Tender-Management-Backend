using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Update;
using TenderSystem.Business.Abstract;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.DataAccess.Abstract;
using TenderSystem.DataAccess.Concrete.EntityFramework;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.Business.Concrete
{
    public class TenderManager : ITenderService
    {
            private ITenderDal _tenderDal;
            private IBidDal _bidDal;

            public TenderManager(ITenderDal tenderDal, IBidDal bidDal)
            {
                _tenderDal = tenderDal;
                _bidDal = bidDal;
            }
        
        public Result GetAll()
        {
            try
            {
                var data = _tenderDal.GetList();
                return new SuccessResult(data, "Tenders listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Tenders could NOT listed." + exception.Message);
            }

            
        }

        public Result GetById(int tenderId)
        {
            try
            {
                var data = _tenderDal.Get(a => a.Id == tenderId);
                if (data == null)
                {
                    return new ErrorResult("There is no tender has this Id.");
                }

                return new SuccessResult(data, "Tender listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Tender could NOT listed." + exception.Message);
            }

            
        }

        public Result GetByTenderNo(int tenderNo)
        {
            try
            {
                var data = _tenderDal.Get(a => a.TenderNo == tenderNo);
                if (data == null)
                {
                    return new ErrorResult("There is no tender has this tender no.");
                }

                return new SuccessResult(data, "Tender listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Tender could NOT listed." + exception.Message);
            }

            
        }

        public Result GetByAdminId(int adminId)
        {
            try
            {
                var data = _tenderDal.GetList(b => b.AdminId == adminId);
                if (data == null)
                {
                    return new ErrorResult("There are no tenders registered to this admin id.");
                }

                return new SuccessResult(data, "Tenders listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Tenders could NOT listed." + exception.Message);
            }

            
        }

        public Result GetByCategoryId(int categoryId)
        {
            try
            {
                var data = _tenderDal.GetList(b => b.CategoryId == categoryId);
                if (data == null)
                {
                    return new ErrorResult("There are no tenders registered to this client id.");
                }

                return new SuccessResult(data, "Tenders listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Tenders could NOT listed." + exception.Message);
            }

            
        }

        public Result GetByStatusId(int statusId)
        {
            try
            {
                var data = _tenderDal.GetList(b => b.TenderStatusId == statusId);
                if (data == null)
                {
                    return new ErrorResult("There are no tenders has this status.");
                }

                return new SuccessResult(data, "Tenders listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Tenders could NOT listed." + exception.Message);
            }

            
        }

        public Result GetByStartPrice(decimal min, decimal max)
        {
            try
            {
                var data = _tenderDal.GetList(b => b.StartPrice >= min && b.StartPrice <= max);
                if (data == null)
                {
                    return new ErrorResult("There is no tender with a starting price in this range.");
                }

                return new SuccessResult(data, "Tenders listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Tenders could NOT listed." + exception.Message);
            }

            
        }

        public Result GetByWinnerClientId(int winnerClientId)
        {
            try
            {
                var data = _tenderDal.GetList(b => b.WinnerClientId == winnerClientId);
                if (data == null)
                {
                    return new ErrorResult("There are no tenders has this client id as winner.");
                }

                return new SuccessResult(data, "Tenders listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Tenders could NOT listed." + exception.Message);
            }

            
        }


        public Result GetByClientId(int clientId)
        {
            try
            {
                var data = _bidDal.GetList(b => b.ClientId == clientId);
                if (data == null)
                {
                    return new ErrorResult("There are no tenders registered to this client id.");
                }

                return new SuccessResult(_tenderDal.GetListByClientId(clientId), "Tenders listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Tenders could NOT listed." + exception.Message);
            }
        }

        public Result GetByStatusAndCategoryId(int statusId, int categoryId)
        {
            try
            {
                var data = _tenderDal.GetList(b => b.TenderStatusId == statusId 
                                                        && b.CategoryId == categoryId);
                if (data == null)
                {
                    return new ErrorResult("There are no tenders has this status and category id.");
                }

                return new SuccessResult(data, "Tenders listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Tenders could NOT listed." + exception.Message);
            }
        }

        public Result Add(Tender tender)
        {
            try
            {
                _tenderDal.Add(tender);
                return new SuccessResult("Tender added.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("Error: Tender could NOT added." + exception.Message);
            }
        }

        public Result Update(Tender tender)
        {
            try
            {
                _tenderDal.Update(tender);
                return new SuccessResult("Tender updated.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("Error: Tender could NOT updated." + exception.Message);
            }

            
        }

        public Result Delete(int tenderId)
        {
            try
            {
                var data = _tenderDal.Get(a => a.Id == tenderId);
                if (data == null)
                {
                    return new ErrorResult("Tender id could not found.");
                }

                _tenderDal.Delete(data);
                return new SuccessResult("Tender deleted.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Tender could not deleted." + exception.Message);
            }

            
        }
    }
}
