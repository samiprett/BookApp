using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.Models
{
    public class EFPurchaseRepository : IPurchaseRespository
    {
        private Bookstore1Context context;
        public EFPurchaseRepository (Bookstore1Context temp)
        {
            context = temp;
        }
        public IQueryable<Pay> Purchases => context.Pay.Include(x => x.Lines).ThenInclude(x => x.Book);
        public new void SavePayment(Pay payment)
        {
            context.AttachRange(payment.Lines.Select(x => x.Book));

            if (payment.PayId == 0)
            {
                context.Pay.Add(payment);
            }

            context.SaveChanges();
        }
    }
}
