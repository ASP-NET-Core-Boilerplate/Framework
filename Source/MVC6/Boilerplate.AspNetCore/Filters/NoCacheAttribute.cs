﻿namespace Boilerplate.AspNetCore.Filters
{
    using System;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Represents an attribute that is used to mark an action method whose output will not be cached.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class NoCacheAttribute : ResponseCacheAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoCacheAttribute"/> class.
        /// </summary>
        public NoCacheAttribute()
        {
            // Duration = 0 by default.
            // VaryByParam = "*" by default.
            this.NoStore = true;
        }
    }
}
