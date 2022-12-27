using Net_News.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_News.Models.Provider
{
    public class Bakcell : IProvider
    {
        Dictionary<string, int> borrowBalanceCodes;

        public Bakcell()
        {
            this.borrowBalanceCodes = new Dictionary<string, int>();
            borrowBalanceCodes.Add("*050*1#", 1);
            borrowBalanceCodes.Add("*050*3#", 3);
            borrowBalanceCodes.Add("*050*5#", 5);
        }

        public int borrowBalance(int borrowCode)
        {
            var data = this.borrowBalanceCodes.ElementAt(borrowCode - 1);

            return data.Value;
        }

        public void showBorrowCodes()
        {
            int counter = 1;

            foreach (var code in this.borrowBalanceCodes)
            {
                Console.WriteLine(
                    "ID: " + (counter++) +
                    "\nCode: " + code.Key +
                    "\nAmount: " + code.Value +
                    "\n" + new String('-', 50));
            }
        }
    }
}
