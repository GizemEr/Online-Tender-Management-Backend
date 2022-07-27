using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using TenderSystem.Business.Abstract;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.DataAccess.Abstract;
using TenderSystem.DataAccess.Concrete.EntityFramework;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.Business.Concrete
{
    public class AdminManager : IAdminService
    {
            private IAdminDal _adminDal;


            public AdminManager(IAdminDal adminDal)
            {
                _adminDal = adminDal;
            }

        public Result GetAll()
        {
            try
            {
                var data = _adminDal.GetList();
                return new SuccessResult(data, "Admins listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Admins could NOT listed." + exception.Message);
            }

            
        }

        public Result GetById(int userId)
        {
            try
            {
                var data = _adminDal.Get(a => a.UserId == userId);
                if (data == null)
                {
                    return new ErrorResult("There is no Admin has this Id.");
                }

                return new SuccessResult(data, "Admin listed.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Admin could NOT listed." + exception.Message);
            }

            
        }

        public Result Add(Admin admin)
        {
            try
            {
                var data = _adminDal.Get(a => a.Email == admin.Email);
                if (data != null)
                {
                    return new ErrorResult("Email is already in use.");
                }

                data = _adminDal.Get(a => a.IdentityNumber == admin.IdentityNumber);
                if (data != null)
                {
                    return new ErrorResult("Identity number is already in use.");
                }

                _adminDal.Add(admin);
                return new SuccessResult("Admin added.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Admin could NOT added" + exception.Message);
            }

            
        }

        public Result Update(Admin admin)
        {
            try
            {
                var data = _adminDal.Get(a => a.Email == admin.Email);
                if (data != null)
                {
                    return new ErrorResult("Email is already in use.");
                }

                data = _adminDal.Get(a => a.IdentityNumber == admin.IdentityNumber);
                if (data != null)
                {
                    return new ErrorResult("Identity number is already in use.");
                }

                _adminDal.Update(admin);
                return new SuccessResult("Admin updated.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Admin could not updated." + exception.Message);
            }

            
        }

        public Result Delete(int adminId)
        {
            try
            {
                var data = _adminDal.Get(a => a.UserId == adminId);
                if (data == null)
                {
                    return new ErrorResult("Admin id could not found.");
                }

                _adminDal.Delete(data);
                return new SuccessResult("Admin deleted.");
            }
            catch (Exception exception)
            {
                return new ErrorResult("ERROR: Admin could not deleted." + exception.Message);
            }

           
        }
    }
}