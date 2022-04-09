using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractalis.Domain.Contracts
{
    public interface IApplication
    {
        string StartupPath { get; set; }
    }
}
