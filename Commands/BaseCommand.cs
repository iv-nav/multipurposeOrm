using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipurposeOrm.Commands
{
    abstract class BaseCommand
    {
        private Type _entityType;

        protected BaseCommand(Type entityType)
        {
            _entityType = entityType;
        }
    }
}
