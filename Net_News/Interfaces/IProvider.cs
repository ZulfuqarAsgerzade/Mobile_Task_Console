using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_News.Interfaces
{
    public interface IProvider
    {
        void showBorrowCodes();
        int borrowBalance(int borrowCode);
    }
}
