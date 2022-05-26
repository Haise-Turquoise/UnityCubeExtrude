using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class CubeControl : MonoBehaviour
{
    [SerializeField]
    private Button extrudeButton;
    // Start is called before the first frame update
    void Start()
    {
        extrudeButton.onClick.AddListener(() =>
        {
            OnExtrude();
        });
    }
    private void OnExtrude()
    {
        Mesh mesh = this.GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector3[] normals = mesh.normals;
        GCHandle verticesGCHandle = GCHandle.Alloc(vertices, GCHandleType.Pinned);
        IntPtr rawVertices = verticesGCHandle.AddrOfPinnedObject();
        GCHandle normalsGCHandle = GCHandle.Alloc(normals, GCHandleType.Pinned);
        Extrude(ref rawVertices, normalsGCHandle.AddrOfPinnedObject(), (UInt64)vertices.Length);
        mesh.SetVertices(vertices);
    }
    [DllImport("cube.dll")]
    private static extern void Extrude(ref IntPtr rawVertices, IntPtr rawNormals, UInt64 verticesCount);
}
