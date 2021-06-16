using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipurposeOrm
{
    interface IAdapter
    {
        JArray Get(ICommand getCommand);
        bool Insert(ICommand insertCommand);
        bool Update(ICommand updateCommand);
        bool Delete(ICommand deleteCommand);
    }
}
