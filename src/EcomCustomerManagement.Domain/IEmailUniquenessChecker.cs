﻿namespace EcomCustomerManagement.Domain;

/// <summary>
/// Domain service for checking email uniqueness
/// </summary>
public interface IEmailUniquenessChecker
{
    bool IsUnique(string customerEmail);
}