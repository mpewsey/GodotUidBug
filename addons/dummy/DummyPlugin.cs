#if TOOLS
using Godot;

[Tool]
public partial class DummyPlugin : EditorPlugin
{
    public override void _EnterTree()
    {
        var uidPath = "uid://dr1hds7vve78t";
        var resPath = "res://resource.tres";
        var uidResource = ResourceLoader.Load<Resource>(uidPath);

        if (uidResource == null)
            GD.PrintErr("Resource is null, meaning it couldn't be loaded by uid:// path.");
        else
            GD.Print("Resource could be loaded by uid:// path.");

        var resResource = ResourceLoader.Load<Resource>(resPath);

        if (resResource == null)
            GD.PrintErr("Resource is null, meaning it couldn't be loaded by res:// path.");
        else
            GD.Print("Resource could be loaded by res:// path.");
    }
}
#endif
