using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// 单例模式
    /// </summary>
    /// <typeparam name="T">要创建的类型</typeparam>
    public class Singleton<T> where T : class//指定 T必须是引用类型  new() 指定必须有一个公有的无参构造函数  strcut 指定必须是继承 ValueType
    {

        private static readonly Lazy<T> current = new Lazy<T>(() => Activator.CreateInstance<T>(), true);

        public static object Current { get { return current.Value; } }
    }
}
