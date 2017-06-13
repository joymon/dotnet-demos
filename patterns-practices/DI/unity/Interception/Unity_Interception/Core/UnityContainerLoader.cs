using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity.InterceptionExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity_Interception
{
    /// <summary>
    /// Interface that represents Container loader for Different Instance creators like Unity solver, activator create etc
    /// </summary>
    public interface IContainerLoader
    {
        /// <summary>
        /// Resolves the specified instance type.
        /// </summary>
        /// <param name="instanceType">Type of the instance.</param>
        /// <returns></returns>
        object Resolve(Type instanceType);

        /// <summary>
        /// Resolves the specified instance type.
        /// </summary>
        /// <param name="instanceType">Type of the instance.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        object Resolve(Type instanceType, string name);

        /// <summary>
        /// Resolves the specified instance type.
        /// </summary>
        /// <param name="instanceType">Type of the instance.</param>
        /// <param name="dependencyCollection">The dependency collection.</param>
        /// <returns></returns>
        object Resolve(Type instanceType, Dictionary<string, object> dependencyCollection);

        /// <summary>
        /// Resolves the specified instance type.
        /// </summary>
        /// <param name="instanceType">Type of the instance.</param>
        /// <param name="name">The name.</param>
        /// <param name="dependencyCollection">The dependency collection.</param>
        /// <returns></returns>
        object Resolve(Type instanceType, string name, Dictionary<string, object> dependencyCollection);

        /// <summary>
        /// Resolves this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Resolve<T>();


        /// <summary>
        /// Resolves this instance.
        /// </summary>
        /// <typeparam name="TBase">The type of the t base.</typeparam>
        /// <typeparam name="TObject">The type of the t object.</typeparam>
        /// <returns>TBase.</returns>
        TBase Resolve<TBase, TObject>() where TObject : TBase;

        /// <summary>
        /// Resolves the specified name.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        T Resolve<T>(string name);

        /// <summary>
        /// Resolves the specified dependency collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dependencyCollection">The dependency collection.</param>
        /// <returns></returns>
        T Resolve<T>(Dictionary<string, object> dependencyCollection);

        /// <summary>
        /// Resolves the specified name.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <param name="dependencyCollection">The dependency collection.</param>
        /// <returns></returns>
        T Resolve<T>(string name, Dictionary<string, object> dependencyCollection);
    }
    /// <summary>
    /// Class represents to solve create instance
    /// </summary>
    internal class UnityContainerLoader : IContainerLoader, IDisposable
    {
        #region Static

        private static IUnityContainer unityContainer;
        private static readonly IContainerLoader singleton = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnityContainerLoader"/> class.
        /// </summary>
        public UnityContainerLoader()
        {
            //Default constructor for Unity to understand
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static IContainerLoader Instance
        {
            get
            {
                return singleton;
            }
        }

        /// <summary>
        /// Initializes the <see cref="UnityContainerLoader"/> class.
        /// </summary>
        static UnityContainerLoader()
        {
            unityContainer = new UnityContainer();
            unityContainer.LoadConfiguration();
            singleton = unityContainer.Resolve<IContainerLoader>();
        }

        #endregion

        /// <summary>
        /// Resolves the specified instance type.
        /// </summary>
        /// <param name="instanceType">Type of the instance.</param>
        /// <returns></returns>
        public object Resolve(Type instanceType)
        {
            if (!unityContainer.IsRegistered(instanceType))
                unityContainer.RegisterType(instanceType, new InjectionConstructor());
            return unityContainer.Resolve(instanceType);
            // return _unityContainer.Resolve(InstanceType, InstanceType.Name, null);
        }

        /// <summary>
        /// Resolves the specified instance type.
        /// </summary>
        /// <param name="instanceType">Type of the instance.</param>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public object Resolve(Type instanceType, string name)
        {
            return unityContainer.Resolve(instanceType, name, null);
        }

        /// <summary>
        /// Resolves the specified instance type.
        /// </summary>
        /// <param name="instanceType">Type of the instance.</param>
        /// <param name="dependencyCollection">The dependency collection.</param>
        /// <returns></returns>
        public object Resolve(Type instanceType, Dictionary<string, object> dependencyCollection)
        {
            return unityContainer.Resolve(instanceType, instanceType.Name, this.GetParameterOverrides(dependencyCollection));
        }

        /// <summary>
        /// Resolves the specified instance type.
        /// </summary>
        /// <param name="instanceType">Type of the instance.</param>
        /// <param name="name">The name.</param>
        /// <param name="dependencyCollection">The dependency collection.</param>
        /// <returns></returns>
        public object Resolve(Type instanceType, string name, Dictionary<string, object> dependencyCollection)
        {
            return unityContainer.Resolve(instanceType, name, this.GetParameterOverrides(dependencyCollection));
        }

        public T Resolve<T>()
        {
            if (!unityContainer.IsRegistered<T>())
                unityContainer.RegisterType<T>(new InjectionConstructor());
            return unityContainer.Resolve<T>();
        }

        public TBase Resolve<TBase, TObject>()
            where TObject : TBase
        {
            string name = typeof(TObject).Name;
            if (!unityContainer.IsRegistered<TObject>(name))
                unityContainer.RegisterType<TBase, TObject>(name, new Interceptor<TransparentProxyInterceptor>(),
                                                                  new InterceptionBehavior<PolicyInjectionBehavior>(),
                                                                  new InjectionConstructor());
            return unityContainer.Resolve<TBase>(name);
        }

        /// <summary>
        /// Resolves the specified name.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public T Resolve<T>(string name)
        {
            if (!unityContainer.IsRegistered<T>(name))
                unityContainer.RegisterType<T>(name, new InjectionConstructor());
            return unityContainer.Resolve<T>(name);
        }

        /// <summary>
        /// Resolves the specified dependency collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dependencyCollection">The dependency collection.</param>
        /// <returns></returns>
        public T Resolve<T>(Dictionary<string, object> dependencyCollection)
        {
            ParameterOverrides overrides = this.GetParameterOverrides(dependencyCollection);
            return unityContainer.Resolve<T>(overrides);
        }

        /// <summary>
        /// Resolves the specified name.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="name">The name.</param>
        /// <param name="dependencyCollection">The dependency collection.</param>
        /// <returns></returns>
        public T Resolve<T>(string name, Dictionary<string, object> dependencyCollection)//not working
        {
            return unityContainer.Resolve<T>(name, this.GetParameterOverrides(dependencyCollection));
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern. 
        private bool disposed = false;

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
                return;

            if (disposing)
            {
                if (unityContainer != null)
                    unityContainer.Dispose();
                unityContainer = null;
            }

            this.disposed = true;
        }

        /// <summary>
        /// Gets the parameter overrides.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns></returns>
        private ParameterOverrides GetParameterOverrides(Dictionary<string, object> parameters)
        {
            var dependencyOverrides = new ParameterOverrides();

            foreach (KeyValuePair<string, object> item in parameters)
                dependencyOverrides.Add(item.Key, item.Value);

            return dependencyOverrides;
        }
    }
}
