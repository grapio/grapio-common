namespace grapio_common;

/// <summary>
/// Represents a <see cref="System.Boolean"/> feature flag.
/// </summary>
public class BooleanFeatureFlag : FeatureFlagBase<bool>
{
    /// <inheritdoc />
    public BooleanFeatureFlag(string flagKey, bool value) : base(flagKey, value)
    {
    }
}
