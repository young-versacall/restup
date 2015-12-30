﻿using System;

namespace Devkoes.Restup.WebServer.Attributes
{
    /// <summary>
    /// This class is only used as a marker
    /// </summary>
    [System.AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = false)]
    public sealed class FromBodyAttribute : Attribute
    {
    }
}
