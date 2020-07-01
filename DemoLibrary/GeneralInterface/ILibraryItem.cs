using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface ILibraryItem
    {
        // The following is common thing between Book,DVD,AudioBook, and ReferneceBook 
        string LibraryId { get; set; }
        string Title { get; set; }

        // The followin is not common things
        //string Author { get; set; }
        //int Pages { get; set; }
        //int CheckOutDurationInDays { get; set; }
        //string Borrower { get; set; }
        //DateTime BorrowDate { get; set; }

        //void CheckIn();
        //void CheckOut(string borrower);
        //DateTime GetDueDate();
    }
}
