using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MeshGenerator))]
public class MeshReloadEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        MeshGenerator mesh_generator = (MeshGenerator)target;
        if(GUILayout.Button("Reload Mesh"))
        {
            mesh_generator.UpdateMesh();
        }
    }
}
