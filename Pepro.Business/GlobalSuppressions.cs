﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage(
    "Performance",
    "CA1822:Mark members as static",
    Justification = "Methods in this type are intentionally instance methods due to Singleton-based design.",
    Scope = "type",
    Target = "~T:Pepro.Business.AccountBusiness"
)]

[assembly: SuppressMessage(
    "Performance",
    "CA1822:Mark members as static",
    Justification = "Methods in this type are intentionally instance methods due to Singleton-based design.",
    Scope = "type",
    Target = "~T:Pepro.Business.EmployeeBusiness"
)]
