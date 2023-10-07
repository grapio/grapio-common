namespace grapio_common;

/// <summary>
/// Represents a <see cref="System.String"/> feature flag.
/// </summary>
public class StringFeatureFlag: FeatureFlagBase<string>
{
    /// <inheritdoc />
    public StringFeatureFlag(string flagKey, string value) : base(flagKey, value)
    {
    }
}