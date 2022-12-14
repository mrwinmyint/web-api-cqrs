using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Application.Interfaces.Persistence
{
    public interface IUnitOfWork
    {
        void Save();
    }
}
