using Fractalis.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractalis.Domain.Base
{
    public class BaseApplication : IApplication
    {
        public string StartupPath { get; set; }
    }
}
