using OriginalCircuit.Eda.Primitives;

namespace OriginalCircuit.Eda.Rendering;

/// <summary>
/// Options for rendering a component or document.
/// </summary>
public sealed record RenderOptions
{
    /// <summary>
    /// Output width in pixels (for raster) or units (for vector).
    /// </summary>
    public int Width { get; init; } = 1024;

    /// <summary>
    /// Output height in pixels (for raster) or units (for vector).
    /// </summary>
    public int Height { get; init; } = 768;

    /// <summary>
    /// Background color.
    /// </summary>
    public EdaColor BackgroundColor { get; init; } = EdaColor.White;

    /// <summary>
    /// Whether to automatically zoom to fit the component.
    /// </summary>
    public bool AutoZoom { get; init; } = true;

    /// <summary>
    /// Scale factor (1.0 = 100%).
    /// </summary>
    public double Scale { get; init; } = 1.0;
}
