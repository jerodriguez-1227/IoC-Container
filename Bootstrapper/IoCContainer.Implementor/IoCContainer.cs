using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootstrapper.IoCContainer.Implementor
{
    public class IoCContainer : IContainer
    {
        private readonly Dictionary<Type, object> typeInstances = new Dictionary<Type, object>();

        /// <summary>
        /// Associates an abstraction with it's concrete implementation.
        /// </summary>
        /// <typeparam name="TAbstract">The abstraction type.</typeparam>
        /// <typeparam name="TConcrete">The concrete implementation to associate.</typeparam>
        public void Register<TAbstract, TConcrete>()
        {
            typeInstances[typeof(TAbstract)] = typeof(TConcrete);
        }

        /// <summary>
        /// Retrieves the concrete implementation of the specified abstraction.
        /// </summary>
        /// <typeparam name="TAbstract">The abstraction type.</typeparam>
        /// <returns>The concrete implementation as the abstraction.</returns>
        public TAbstract Resolve<TAbstract>()
        {
            // Here we grab the concrete implementation that has been registered to this type. If it does not exist, we throw an exception.
            TAbstract regObject = (TAbstract)typeInstances[typeof(TAbstract)];
            if (regObject == null)
                throw new Exception(string.Format("This type could not be found within the registered list: {0}", typeof(TAbstract)));
            return regObject;
        }
    }
}