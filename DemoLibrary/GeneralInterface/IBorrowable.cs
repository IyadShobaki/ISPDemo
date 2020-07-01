using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface IBorrowable
    {
        int CheckOutDurationInDays { get; set; }
        string Borrower { get; set; }
        DateTime BorrowDate { get; set; }

        void CheckIn();
        void CheckOut(string borrower);
        DateTime GetDueDate();
    }
}
