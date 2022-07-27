using System;
using System.Collections.Generic;
using System.Text;
using TenderSystem.Core.Utilities.Results;

namespace TenderSystem.Business.Abstract
{
    public interface ITenderStatusService
    {
        Result GetAll();
        Result GetById(int tenderStatusId);
    }
}
