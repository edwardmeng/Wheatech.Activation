﻿using System;

namespace Wheatech.Activation
{
    /// <summary>
    /// Provides information about the hosting environment an application is running in.
    /// </summary>
    public interface IActivatingEnvironment
    {
        /// <summary>
        /// Gets or sets the environment variable by using the specified name.
        /// </summary>
        /// <param name="name">The environment variable name.</param>
        /// <returns>The value of the environment variable.</returns>
        object this[string name] { get; set; }

        /// <summary>
        /// Gets or sets the name of the environment. This property is automatically set by the host to the value of the "ASPNETCORE_ENVIRONMENT" environment variable. 
        /// </summary>
        string Environment { get; set; }

        /// <summary>
        /// Gets or sets the name of the application. This property is automatically set by the host to the assembly containing the application entry point. 
        /// </summary>
        string ApplicationName { get; set; }

        /// <summary>
        /// Gets or sets the version of the application. This property is automatically set by the host to the assembly containing the application entry point. 
        /// </summary>
        Version ApplicationVersion { get; set; }

        /// <summary>
        /// Specify the component to be used by the hosting application.
        /// </summary>
        /// <param name="serviceType">The requested type of the component.</param>
        /// <param name="instance">The instance of the component.</param>
        /// <returns>The <see cref="IActivatingEnvironment"/>.</returns>
        IActivatingEnvironment Use(Type serviceType, object instance);
    }
}
