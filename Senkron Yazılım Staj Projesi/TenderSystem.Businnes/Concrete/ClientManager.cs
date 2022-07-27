using System;
using System.Collections.Generic;
using TenderSystem.Business.Abstract;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.DataAccess.Abstract;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.Business.Concrete
{
    public class ClientManager : IClientService
    {
            private IClientDal _clientDal;

            public ClientManager(IClientDal clientDal)
            {
                _clientDal = clientDal;
            }

        public Result GetAll()
        {
            try
            {
                var data = _clientDal.GetList();
                return new SuccessResult(data, "Clients listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("Error: Clients could NOT listed." + exception.Message);
            }

            
        }

        public Result GetById(int userId)
        {
            try
            {
                var data = _clientDal.Get(c => c.UserId == userId);
                if (data == null)
                {
                    return new ErrorResult("Client Id could not found.");
                }

                return new SuccessResult(data, "Client listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("Error: Client could NOT listed." + exception.Message);
            }

           
        }

        public Result GetByUserName(string userName)
        {
            try
            {
                var data = _clientDal.Get(c => c.UserName == userName);
                if (data == null)
                {
                    return new ErrorResult("User name could not found.");
                }

                return new SuccessResult(data, "Client listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("Error: Client could NOT listed." + exception.Message);
            }

            
        }

        public Result Add(Client client)
        {
            try
            {
                var data = _clientDal.Get(a => a.Email == client.Email);
                if (data != null)
                {
                    return new ErrorResult("Email is already in use.");
                }

                data = _clientDal.Get(a => a.IdentityNumber == client.IdentityNumber);
                if (data != null)
                {
                    return new ErrorResult("Identity number is already in use.");
                }

                data = _clientDal.Get(a => a.UserName == client.UserName);
                if (data != null)
                {
                    return new ErrorResult("User name is already in use.");
                }

                _clientDal.Add(client);
                return new SuccessResult("Client added.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Client could NOT added" + exception.Message);
            }

            
        }

        public Result Update(Client client)
        {
            try
            {
                var data = _clientDal.Get(a => a.Email == client.Email);
                if (data != null)
                {
                    return new ErrorResult("Email is already in use.");
                }

                data = _clientDal.Get(a => a.IdentityNumber == client.IdentityNumber);
                if (data != null)
                {
                    return new ErrorResult("Identity number is already in use.");
                }

                data = _clientDal.Get(a => a.UserName == client.UserName);
                if (data != null)
                {
                    return new ErrorResult("User name is already in use.");
                }

                _clientDal.Update(client);
                return new SuccessResult("Client updated.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Client could NOT updated." + exception.Message);
            }

            
        }

        public Result Delete(int clientId)
        {
            try
            {
                var data = _clientDal.Get(a => a.UserId == clientId);
                if (data == null)
                {
                    return new ErrorResult("Client id could not found.");
                }

                _clientDal.Delete(data);
                return new SuccessResult("Client deleted.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Client could not deleted." + exception.Message);
            }

            
        }
    }
}