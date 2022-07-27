using System.Collections.Generic;
using TenderSystem.Core.Utilities.Results;
using TenderSystem.Entities.Concrete;

namespace TenderSystem.Business.Abstract
{
    public interface ITenderService
    {
        Result GetAll();
        Result GetById(int tenderId);
        Result GetByTenderNo(int tenderNo);
        Result GetByAdminId(int adminId);
        Result GetByWinnerClientId(int winnerClientId);
        Result GetByCategoryId(int categoryId);
        Result GetByStatusId(int statusId);
        Result GetByStartPrice(decimal min, decimal max);
        Result GetByClientId(int clientId);
        Result GetByStatusAndCategoryId(int statusId, int categoryId);
        Result Add(Tender tender);
        Result Update(Tender tender);
        Result Delete(int tenderId);
    }
}
