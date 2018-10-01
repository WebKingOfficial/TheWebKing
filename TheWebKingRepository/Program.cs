using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheWebKingRepository.ADO;

namespace TheWebKingRepository
{
    class Program
    {
        public static void Main(string[] args)
        {
            ADOUserRepository adoUserRepository = new ADOUserRepository();
            adoUserRepository.GetUserDetails();
        }
    }
}
