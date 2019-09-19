using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmailCore.Lib
{
    public interface ISenderFactory
    {
        ISender GetSender();
    }
}
