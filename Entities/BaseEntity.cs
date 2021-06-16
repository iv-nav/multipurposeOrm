using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using multipurposeOrm.Interfaces;

namespace multipurposeOrm.Entities
{
    public class BaseEntity : IEntity
    {
        public bool ChangeTracking { get; set; }
        private Lazy<Dictionary<string, object>> _changes = new Lazy<Dictionary<string, object>>(() => new Dictionary<string, object>());
        protected void SetProperty<T>(ref T oldVal, T newVal, [CallerMemberName]string prop = "")
        {
            if (oldVal == null && newVal == null)
                return;

            oldVal = newVal;

            if (ChangeTracking)
                _changes.Value[prop] = newVal;
        }

    }
}
