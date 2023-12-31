﻿using LiteDB;

namespace grapio_common;

/// <summary>
/// Represents a generic feature flag of type <code>T</code>.
/// </summary>
/// <typeparam name="T">Type of the feature flag value</typeparam>
public abstract class FeatureFlagBase<T>
{
    [BsonId]
    public ObjectId Id { get; set; }
    
    /// <summary>
    /// The unique identifier for this feature flag.
    /// </summary>
    public string FlagKey { get; set; }
    
    /// <summary>
    /// The value for this feature flag.
    /// </summary>
    public T Value { get; set; }

    /// <summary>
    /// Creates a new instance of a feature flag that's used for testing. 
    /// </summary>
    protected FeatureFlagBase()
    {
        Id = default!;
        FlagKey = string.Empty;
        Value = default!;
    }
    
    /// <summary>
    /// Creates an instance of a feature flag.
    /// </summary>
    /// <param name="flagKey">The unique identifier for this feature flag</param>
    /// <param name="value">The value returned for this feature flag</param>
    public FeatureFlagBase(string flagKey, T value)
    {
        if (string.IsNullOrEmpty(flagKey))
            throw new ArgumentNullException(nameof(flagKey));
        
        FlagKey = flagKey;
        Value = value;
    }
}