using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNN.Daos
{
    internal interface IDb
    {
        public void OpenConnection();
        
        public void CloseConnection();  

    }
}
