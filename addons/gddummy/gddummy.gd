@tool
extends EditorPlugin


func _enter_tree():
	var uidPath = "uid://dr1hds7vve78t";
	var resPath = "res://resource.tres";
	var uidResource = ResourceLoader.load(uidPath);
	
	if uidResource == null:
		printerr("Resource is null, meaning it couldn't be loaded by uid:// path.")
	else:
		print("Resource could be loaded by uid:// path.")

	var resResource = ResourceLoader.load(resPath);

	if resResource == null:
		printerr("Resource is null, meaning it couldn't be loaded by res:// path.")
	else:
		print("Resource could be loaded by res:// path.")
