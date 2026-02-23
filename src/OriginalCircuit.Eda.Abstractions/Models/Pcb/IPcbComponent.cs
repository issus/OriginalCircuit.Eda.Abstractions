using OriginalCircuit.Eda.Primitives;

namespace OriginalCircuit.Eda.Models.Pcb;

/// <summary>
/// Represents a PCB footprint/component containing pads, tracks, and other primitives.
/// </summary>
public interface IPcbComponent : IComponent
{
    /// <summary>
    /// The component height (for 3D clearance calculations).
    /// </summary>
    Coord Height { get; set; }

    /// <summary>
    /// The layer the component is placed on.
    /// </summary>
    int Layer { get; }

    /// <summary>
    /// All pads belonging to this component.
    /// </summary>
    IReadOnlyList<IPcbPad> Pads { get; }

    /// <summary>
    /// All tracks belonging to this component.
    /// </summary>
    IReadOnlyList<IPcbTrack> Tracks { get; }

    /// <summary>
    /// All vias belonging to this component.
    /// </summary>
    IReadOnlyList<IPcbVia> Vias { get; }

    /// <summary>
    /// All arcs belonging to this component.
    /// </summary>
    IReadOnlyList<IPcbArc> Arcs { get; }

    /// <summary>
    /// All text objects belonging to this component.
    /// </summary>
    IReadOnlyList<IPcbText> Texts { get; }

    /// <summary>
    /// All regions belonging to this component.
    /// </summary>
    IReadOnlyList<IPcbRegion> Regions { get; }
}
