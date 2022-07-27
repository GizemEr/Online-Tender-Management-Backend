using System;
using System.Collections.Generic;
using TenderSystem.Business.Abstract;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.DataAccess.Abstract;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.Business.Concrete
{
    public class BidManager : IBidService
    {
        private IBidDal _bidDal;
        private ITenderDal _tenderDal;

            public BidManager(IBidDal bidDal, ITenderDal tenderDal)
            {
                _bidDal = bidDal;
                _tenderDal = tenderDal;
            }

        public Result GetAll()
        {
            try
            {
                var data = _bidDal.GetList();
                return new SuccessResult(data, "Bids listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Bids could NOT listed." + exception.Message);
            }

            
        }

        public Result GetById(int bidId)
        {
            try
            {
                var data = _bidDal.Get(a => a.Id == bidId);
                if (data == null)
                {
                    return new ErrorResult("There is no Bid has this Id.");
                }

                return new SuccessResult(data, "Bid listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Bid could NOT listed." + exception.Message);
            }

            
        }

        public Result GetByTenderId(int tenderId)
        {
            try
            {
                var data = _bidDal.GetList(b => b.TenderId == tenderId);
                if (data == null)
                {
                    return new ErrorResult("There are no bids registered to this tender id.");
                }

                return new SuccessResult(data, "Bids listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Bids could NOT listed." + exception.Message);
            }

            
        }

        public Result GetByClientId(int clientId)
        {
            try
            {
                var data = _bidDal.GetList(b => b.ClientId == clientId);
                if (data == null)
                {
                    return new ErrorResult("There are no bids registered to this client id.");
                }

                return new SuccessResult(data, "Bids listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Bids could NOT listed." + exception.Message);
            }
        }

        public Result Add(Bid bid)
        {
            try
            {
                var tender = _tenderDal.Get(t => t.Id == bid.TenderId);
                var bids = _bidDal.GetList(t=>t.TenderId == tender.Id);

                if (bids == null)
                {
                    tender.WinnerClientId = bid.ClientId;
                    
                    _bidDal.Add(bid);
                    return new SuccessResult("Bid added.");
                }
                else
                {
                    var highestBid = _bidDal.Get(t => t.TenderId == tender.Id
                                                  && t.ClientId == tender.WinnerClientId);

                    if (bid.BidPrice > highestBid.BidPrice)
                    {
                        tender.WinnerClientId = bid.ClientId;
                        
                        _bidDal.Add(bid);
                        return new SuccessResult("Bid added.");
                    }
                    else
                    {
                        return new ErrorResult("Please give a higher bid.");
                    }
                }
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Bid could NOT added" + exception.Message);
            }

            
        }

        public Result Update(Bid bid)
        {
            try
            {
                var tender = _tenderDal.Get(t => t.Id == bid.TenderId);
                var bids = _bidDal.GetList(t => t.TenderId == tender.Id);

                if (bids == null)
                {
                    tender.WinnerClientId = bid.ClientId;

                    _bidDal.Update(bid);
                    return new SuccessResult("Bid updated.");

                }
                else
                {
                    var highestBid = _bidDal.Get(t => t.TenderId == tender.Id
                                                      && t.ClientId == tender.WinnerClientId);

                    if (bid.BidPrice > highestBid.BidPrice)
                    {
                        tender.WinnerClientId = bid.ClientId;

                        _bidDal.Update(bid);
                        return new SuccessResult("Bid updated.");

                    }
                    else
                    {
                        return new ErrorResult("Please give a higher bid.");
                    }
                }
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Bid could NOT updated." + exception.Message);
            }

            
        }

        public Result Delete(int bidId)
        {
            try
            {
                var data = _bidDal.Get(a => a.Id == bidId);
                if (data == null)
                {
                    return new ErrorResult("Bid id could not found.");
                }

                _bidDal.Delete(data);
                return new SuccessResult("Bid deleted.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Bid could not deleted."+exception.Message);
            }

            
        }
    }
}