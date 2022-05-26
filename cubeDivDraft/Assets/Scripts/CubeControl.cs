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
            OnEditor();
        });
    }
    private void OnEditor()
    {
        Mesh mesh = this.GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices;
        Vector3[] normals = mesh.normals;
        for(int i = 0;i < vertices.Length;i++)
        {
            vertices[i] += normals[i] * 0.01f;
        }
        mesh.SetVertices(vertices);
    }
    [DllImport("cube.dll")]
    private static extern int Add(int a, int b);
}
