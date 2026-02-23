using OriginalCircuit.Eda.Primitives;

namespace OriginalCircuit.Eda.Models.Sch;

/// <summary>
/// Represents a schematic document containing placed components and top-level primitives.
/// </summary>
public interface ISchDocument : IAsyncDisposable
{
    /// <summary>
    /// All components placed in this document.
    /// </summary>
    IReadOnlyList<ISchComponent> Components { get; }

    /// <summary>
    /// All wires in this document (top-level, not owned by components).
    /// </summary>
    IReadOnlyList<ISchWire> Wires { get; }

    /// <summary>
    /// All net labels in this document (top-level).
    /// </summary>
    IReadOnlyList<ISchNetLabel> NetLabels { get; }

    /// <summary>
    /// All junctions in this document (top-level).
    /// </summary>
    IReadOnlyList<ISchJunction> Junctions { get; }

    /// <summary>
    /// All power objects in this document (top-level).
    /// </summary>
    IReadOnlyList<ISchPowerObject> PowerObjects { get; }

    /// <summary>
    /// All labels in this document (top-level).
    /// </summary>
    IReadOnlyList<ISchLabel> Labels { get; }

    /// <summary>
    /// All no-connect markers in this document (top-level).
    /// </summary>
    IReadOnlyList<ISchNoConnect> NoConnects { get; }

    /// <summary>
    /// All buses in this document (top-level).
    /// </summary>
    IReadOnlyList<ISchBus> Buses { get; }

    /// <summary>
    /// All bus entries in this document (top-level).
    /// </summary>
    IReadOnlyList<ISchBusEntry> BusEntries { get; }

    /// <summary>
    /// Gets the bounding box encompassing all primitives.
    /// </summary>
    CoordRect Bounds { get; }

    /// <summary>
    /// Saves the document to a file.
    /// </summary>
    /// <param name="path">The file path to save to.</param>
    /// <param name="options">Optional save options.</param>
    /// <param name="ct">Cancellation token.</param>
    ValueTask SaveAsync(string path, SaveOptions? options = null, CancellationToken ct = default);

    /// <summary>
    /// Saves the document to a stream.
    /// </summary>
    /// <param name="stream">The stream to save to.</param>
    /// <param name="options">Optional save options.</param>
    /// <param name="ct">Cancellation token.</param>
    ValueTask SaveAsync(Stream stream, SaveOptions? options = null, CancellationToken ct = default);
}
