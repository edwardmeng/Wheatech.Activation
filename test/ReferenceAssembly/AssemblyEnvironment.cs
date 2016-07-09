﻿using System;
using System.Reflection;

namespace ReferenceAssembly
{
    public static class AssemblyEnvironment
    {
        public static string Environment { get; set; }

        public static string ApplicationName { get; set; }

        public static Version ApplicationVersion { get; set; }

        public static string UserName { get; set; }

        public static Assembly[] Assemblies { get; set; }
    }
}
