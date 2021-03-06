// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*============================================================
**
** 
** 
**
**
** Purpose: Represents a Class to the ILGenerator class.
**
** 
===========================================================*/

using System;
using System.Reflection;
using System.Threading;

namespace System.Reflection.Emit
{
    public struct TypeToken
    {
        public static readonly TypeToken Empty = new TypeToken();

        internal int m_class;


        internal TypeToken(int str)
        {
            m_class = str;
        }

        public int Token
        {
            get { return m_class; }
        }

        public override int GetHashCode()
        {
            return m_class;
        }

        public override bool Equals(object obj)
        {
            if (obj is TypeToken)
                return Equals((TypeToken)obj);
            else
                return false;
        }

        public bool Equals(TypeToken obj)
        {
            return obj.m_class == m_class;
        }

        public static bool operator ==(TypeToken a, TypeToken b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(TypeToken a, TypeToken b)
        {
            return !(a == b);
        }
    }
}

