using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Interception
{
    /// <summary>
    /// Collection class to represent the conctructor paramers for Unity solver
    /// </summary>
    public class ConstructorParameterCollection : Dictionary<string, object>
    {
    }
    public static class UnityFactory
    {
        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <typeparam name="T">The type of the class.</typeparam>
        /// <returns></returns>
        public static T CreateInstance<T>()
            where T : class
        {
            return UnityContainerLoader.Instance.Resolve<T>();
        }

        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <typeparam name="TInterface">The type of the t interface.</typeparam>
        /// <typeparam name="TObject">The type of the t object.</typeparam>
        /// <returns>TInterface.</returns>
        public static TInterface CreateInstance<TInterface, TObject>()
            where TObject : TInterface
        {
            return UnityContainerLoader.Instance.Resolve<TInterface, TObject>();
        }


        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <typeparam name="T">The type of the class.</typeparam>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static T CreateInstance<T>(string name)
            where T : class
        {
            return UnityContainerLoader.Instance.Resolve<T>(name);
        }

        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <typeparam name="T">The type of the class.</typeparam>
        /// <param name="name">The name.</param>
        /// <param name="dependencyCollection">The dependency collection.</param>
        /// <returns></returns>
        public static T CreateInstance<T>(string name, ConstructorParameterCollection dependencyCollection)
            where T : class
        {
            return UnityContainerLoader.Instance.Resolve<T>(name, dependencyCollection as Dictionary<string, object>);
        }

        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <typeparam name="T">The type of the class.</typeparam>
        /// <param name="dependencyCollection">The dependency collection.</param>
        /// <returns></returns>
        public static T CreateInstance<T>(ConstructorParameterCollection dependencyCollection)
            where T : class
        {
            return UnityContainerLoader.Instance.Resolve<T>(dependencyCollection as Dictionary<string, object>);
        }

        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <param name="InstanceType">Type of the instance.</param>
        /// <returns></returns>
        public static object CreateInstance(Type InstanceType)
        {
            return UnityContainerLoader.Instance.Resolve(InstanceType);
        }

        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <param name="instanceType">Type of the instance.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public static object CreateInstance(Type instanceType, string name)
        {
            return UnityContainerLoader.Instance.Resolve(instanceType, name);
        }

        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <param name="instanceType">Type of the instance.</param>
        /// <param name="name">The name.</param>
        /// <param name="dependencyCollection">The dependency collection.</param>
        /// <returns></returns>
        public static object CreateInstance(Type instanceType, string name, ConstructorParameterCollection dependencyCollection)
        {
            return UnityContainerLoader.Instance.Resolve(instanceType, name, dependencyCollection as Dictionary<string, object>);
        }

        /// <summary>
        /// Creates the instance.
        /// </summary>
        /// <param name="instanceType">Type of the instance.</param>
        /// <param name="dependencyCollection">The dependency collection.</param>
        /// <returns></returns>
        public static object CreateInstance(Type instanceType, ConstructorParameterCollection dependencyCollection)
        {
            return UnityContainerLoader.Instance.Resolve(instanceType, dependencyCollection as Dictionary<string, object>);
        }
    }
}
