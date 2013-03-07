﻿namespace ExpressionReflect
{
	using System;
	using System.Linq;
	using System.Runtime.CompilerServices;

	internal static class TypeExtensions
	{
		internal static bool IsCompilerGenerated(this Type type)
		{
			bool isCompilerGenerated = type.GetCustomAttributes(typeof(CompilerGeneratedAttribute), false).Any();
			return isCompilerGenerated;
		}

		internal static bool IsExtensionMethod(this Type type)
		{
			bool isExtensionMethod = type.GetCustomAttributes(typeof(ExtensionAttribute), false).Any();
			return isExtensionMethod;
		}
	}
}