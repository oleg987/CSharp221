using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_6
{
    internal class Publisher
    {
        private string _Publisher_Name;
        private int _Year_Of_Publishing;
        private string _Country;
        public Publisher(string Publisher_Name, int Year_Of_Publishing, string Country)
        {
            _Publisher_Name = Publisher_Name;
            _Year_Of_Publishing = Year_Of_Publishing;
            _Country = Country;

        }
    }
}
