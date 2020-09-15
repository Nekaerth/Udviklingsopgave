using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleLibrary
{
    public class InstanceService
    {
        public IEnumerable<T> GetInstances<T>()
        {
            return GetSubTypes<T>()
                .Select(GetTypeInstance<T>)
                .Where(x => x != null);
        }

        private IEnumerable<Type> GetSubTypes<T>()
        {
            var type = typeof(T);
            return type.Assembly.GetTypes()
                .Where(x => x.IsSubclassOf(type));
        }

        private T GetTypeInstance<T>(Type type)
        {
            var constructor = type.GetConstructor(new Type[0]);
            return (T)constructor?.Invoke(new object[0]);
        }
    }
}
