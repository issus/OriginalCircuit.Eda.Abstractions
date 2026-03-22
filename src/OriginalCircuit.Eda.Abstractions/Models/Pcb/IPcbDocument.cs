using OriginalCircuit.Eda.Primitives;

namespace OriginalCircuit.Eda.Models.Pcb;

/// <summary>
/// Represents a PCB document containing placed components and board-level primitives.
/// </summary>
public interface IPcbDocument : IAsyncDisposable
{
    /// <summary>
    /// All placed component instances on the board.
    /// </summary>
    IReadOnlyList<IPcbComponent> Components { get; }

    /// <summary>
    /// All pads on the board.
    /// </summary>
    IReadOnlyList<IPcbPad> Pads { get; }

    /// <summary>
    /// All vias on the board.
    /// </summary>
    IReadOnlyList<IPcbVia> Vias { get; }

    /// <summary>
    /// All tracks on the board.
    /// </summary>
    IReadOnlyList<IPcbTrack> Tracks { get; }

    /// <summary>
    /// All arcs on the board.
    /// </summary>
    IReadOnlyList<IPcbArc> Arcs { get; }

    /// <summary>
    /// All text objects on the board.
    /// </summary>
    IReadOnlyList<IPcbText> Texts { get; }

    /// <summary>
    /// All regions on the board.
    /// </summary>
    IReadOnlyList<IPcbRegion> Regions { get; }

    /// <summary>
    /// Gets the bounding box encompassing all board primitives.
    /// </summary>
    CoordRect Bounds { get; }

    void AddComponent(IPcbComponent component);
    bool RemoveComponent(IPcbComponent component);
    void AddPad(IPcbPad pad);
    bool RemovePad(IPcbPad pad);
    void AddVia(IPcbVia via);
    bool RemoveVia(IPcbVia via);
    void AddTrack(IPcbTrack track);
    bool RemoveTrack(IPcbTrack track);
    void AddArc(IPcbArc arc);
    bool RemoveArc(IPcbArc arc);
    void AddText(IPcbText text);
    bool RemoveText(IPcbText text);
    void AddRegion(IPcbRegion region);
    bool RemoveRegion(IPcbRegion region);

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
