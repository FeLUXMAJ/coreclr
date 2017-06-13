// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

namespace System.Runtime.CompilerServices
{
    using System;

    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple=false, Inherited=false)]
    public sealed class DisablePrivateReflectionAttribute : Attribute
    {
        public DisablePrivateReflectionAttribute() {}
    }
}
