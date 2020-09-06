using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Extension
{
    public static class Extension
    {
        public static T Changer<T>(this object source)
        {
            T target = Activator.CreateInstance<T>();
            Type src = source.GetType();

            PropertyInfo[] propTarget = typeof(T).GetProperties();
            PropertyInfo[] propSrc = src.GetProperties();

            foreach (PropertyInfo item in propSrc)
            {
                object val = item.GetValue(source);
                PropertyInfo hp = propTarget.FirstOrDefault(x => x.Name == item.Name);
                if (hp != null)
                {
                    hp.SetValue(target, val);
                }

            }

            return target;
        }
    }
}
