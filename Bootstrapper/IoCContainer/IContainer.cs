using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootstrapper.IoCContainer
{
    public interface IContainer
    {
        void Register<TAbstract, TConcrete>();
        TAbstract Resolve<TAbstract>();
        // TODO switch out with lifestyle type
    }
}