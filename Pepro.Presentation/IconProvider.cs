using Svg;

namespace Pepro.Presentation;

public static class IconProvider {
    private static readonly string _iconFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "Icons");
    private static readonly Dictionary<string, SvgDocument> _cache = [];

    private static void ProcessNodes(
        IEnumerable<SvgElement> nodes,
        SvgPaintServer colorServer
    ) {
        foreach (SvgElement node in nodes) {
            if (node.Fill != SvgPaintServer.None) {
                node.Fill = colorServer;
            }

            if (node.Color != SvgPaintServer.None) {
                node.Color = colorServer;
            }

            if (node.Stroke != SvgPaintServer.None) {
                node.Stroke = colorServer;
            }

            ProcessNodes(node.Descendants(), colorServer);
        }
    }

    public static Image GetIcon(
        string name,
        string style = "Linear",
        SvgPaintServer? colorServer = null,
        int size = 24
    ) {
        string iconName = $"{name}-{style}-24px.svg";
        string iconPath = Path.Combine(_iconFolderPath, iconName);

        if (!File.Exists(iconPath)) {
            throw new FileNotFoundException($"Icon not found: {iconPath}");
        }

        string iconId = $"{colorServer}-{iconPath}";

        if (!_cache.TryGetValue(iconId, out SvgDocument? svgDoc)) {
            svgDoc = SvgDocument.Open<SvgDocument>(iconPath);

            if (colorServer != null) {
                ProcessNodes(svgDoc.Descendants(), colorServer);
            }

            _cache[iconId] = svgDoc;
        }

        svgDoc.Width = size;
        svgDoc.Height = size;

        return svgDoc.Draw();
    }
}
