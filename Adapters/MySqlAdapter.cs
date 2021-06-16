using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;

namespace multipurposeOrm.Adapters
{
    class MySqlAdapter : IAdapter
    {
        private string _connectionString;
        private bool _needReconnect;
        private MySqlConnection _connection;
        private Dictionary<Type, string> _tablesMap;

        public MySqlAdapter()
        {
            _tablesMap = new();
        }

        public JArray Get(ICommand getCommand)
        {
            return new JArray();
        }

        public bool Insert(ICommand insertCommand)
        {
            return true;
        }

        public bool Update(ICommand updateCommand)
        {
            return true;
        }

        public bool Delete(ICommand deleteCommand)
        {
            return true;
        }

    }
}
