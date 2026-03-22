namespace OriginalCircuit.Eda.Models.Sch;

/// <summary>
/// Represents a schematic symbol/component containing pins and graphical primitives.
/// </summary>
public interface ISchComponent : IComponent
{
    /// <summary>
    /// Number of parts (units) in this component. Multi-part components have PartCount &gt; 1.
    /// </summary>
    int PartCount { get; }

    /// <summary>
    /// All pins belonging to this component.
    /// </summary>
    IReadOnlyList<ISchPin> Pins { get; }

    /// <summary>
    /// All line primitives belonging to this component.
    /// </summary>
    IReadOnlyList<ISchLine> Lines { get; }

    /// <summary>
    /// All rectangle primitives belonging to this component.
    /// </summary>
    IReadOnlyList<ISchRectangle> Rectangles { get; }

    /// <summary>
    /// All text label primitives belonging to this component.
    /// </summary>
    IReadOnlyList<ISchLabel> Labels { get; }

    /// <summary>
    /// All wire primitives belonging to this component.
    /// </summary>
    IReadOnlyList<ISchWire> Wires { get; }

    /// <summary>
    /// All polyline primitives belonging to this component.
    /// </summary>
    IReadOnlyList<ISchPolyline> Polylines { get; }

    /// <summary>
    /// All polygon primitives belonging to this component.
    /// </summary>
    IReadOnlyList<ISchPolygon> Polygons { get; }

    /// <summary>
    /// All arc primitives belonging to this component.
    /// </summary>
    IReadOnlyList<ISchArc> Arcs { get; }

    /// <summary>
    /// All circle primitives belonging to this component.
    /// </summary>
    IReadOnlyList<ISchCircle> Circles { get; }

    /// <summary>
    /// All bezier curve primitives belonging to this component.
    /// </summary>
    IReadOnlyList<ISchBezier> Beziers { get; }

    /// <summary>
    /// All net label primitives belonging to this component.
    /// </summary>
    IReadOnlyList<ISchNetLabel> NetLabels { get; }

    /// <summary>
    /// All junction primitives belonging to this component.
    /// </summary>
    IReadOnlyList<ISchJunction> Junctions { get; }

    /// <summary>
    /// All image primitives belonging to this component.
    /// </summary>
    IReadOnlyList<ISchImage> Images { get; }

    /// <summary>
    /// All parameter primitives belonging to this component.
    /// </summary>
    IReadOnlyList<ISchParameter> Parameters { get; }

    void AddPin(ISchPin pin);
    bool RemovePin(ISchPin pin);
    void AddLine(ISchLine line);
    bool RemoveLine(ISchLine line);
    void AddRectangle(ISchRectangle rectangle);
    bool RemoveRectangle(ISchRectangle rectangle);
    void AddLabel(ISchLabel label);
    bool RemoveLabel(ISchLabel label);
    void AddWire(ISchWire wire);
    bool RemoveWire(ISchWire wire);
    void AddPolyline(ISchPolyline polyline);
    bool RemovePolyline(ISchPolyline polyline);
    void AddPolygon(ISchPolygon polygon);
    bool RemovePolygon(ISchPolygon polygon);
    void AddArc(ISchArc arc);
    bool RemoveArc(ISchArc arc);
    void AddCircle(ISchCircle circle);
    bool RemoveCircle(ISchCircle circle);
    void AddBezier(ISchBezier bezier);
    bool RemoveBezier(ISchBezier bezier);
    void AddNetLabel(ISchNetLabel netLabel);
    bool RemoveNetLabel(ISchNetLabel netLabel);
    void AddJunction(ISchJunction junction);
    bool RemoveJunction(ISchJunction junction);
    void AddImage(ISchImage image);
    bool RemoveImage(ISchImage image);
    void AddParameter(ISchParameter parameter);
    bool RemoveParameter(ISchParameter parameter);
}
