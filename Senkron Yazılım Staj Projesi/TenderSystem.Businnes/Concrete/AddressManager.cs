using System;
using System.Collections.Generic;
using TenderSystem.Business.Abstract;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.DataAccess.Abstract;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.Business.Concrete
{
    public class AddressManager : IAddressService
    {
            private IAddressDal _addressDal; //Dependency Injection

            public AddressManager(IAddressDal addressDal)
            {
                _addressDal = addressDal;
            }

        public Result GetAll()
        {
            try
            {
                var data = _addressDal.GetList();
                return new SuccessResult(data, "Addreses listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Address could NOT listed." + exception.Message);
            }

            
        }

        public Result GetById(int addressId)
        {
            try
            {
                var data = _addressDal.Get(a => a.Id == addressId);
                if (data == null)
                {
                    return new ErrorResult("Address Id could not found.");
                }

                return new SuccessResult(data, "Addresses listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Address could NOT listed." + exception.Message);
            }

            
        }

        public Result GetByClientId(int clientId)
        {
            try
            {
                var data = _addressDal.Get(a => a.ClientId == clientId);
                if (data == null)
                {
                    return new ErrorResult("There is no address registered to this client id.");
                }

                return new SuccessResult(data, "Addresses listed by client id.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("Error: Address could NOT listed." + exception.Message);
            }

            
        }

        public Result Add(Address address)
        {
            try
            {
                _addressDal.Add(address);
                return new SuccessResult("Address added.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Address could NOT added" + exception.Message);
            }

            
        }

        public Result Update(Address address)
        {
            try
            {
                _addressDal.Update(address);
                return new SuccessResult("Address updated.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Address could not updated." + exception.Message);
            }

            
        }

        public Result Delete(int addressId)
        {
            try
            {
                var data = _addressDal.Get(a => a.Id == addressId);
                if (data == null)
                {
                    return new ErrorResult("Address id could not found.");
                }

                _addressDal.Delete(data);
                return new SuccessResult("Address deleted.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Address could not deleted."+exception.Message);
            }

            
        }
    }
}