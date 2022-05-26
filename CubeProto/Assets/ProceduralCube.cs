using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]

public class ProceduralCube : MonoBehaviour
{
    Mesh mesh;
    List<Vector3> vertices;
    List<int> triangles;
    // Start is called before the first frame update
    void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;
    }

    // Update is called once per frame
    void Start()
    {
        MakeCube();
        UpdateMesh();
    }

    void MakeCube()
    {
        vertices = new List<Vector3>();
        triangles = new List<int>();

        for (int i = 0; i < 6; i++ )
        {
            MakeFace(i);
        }
    }

    void MakeFace(int dir)
    {
        vertices.AddRange(CubeMeshData.faceVertices(dir));
        triangles.Add(vertices.Count - 4 + 0);
        triangles.Add(vertices.Count - 4 + 1);
        triangles.Add(vertices.Count - 4 + 2);
        triangles.Add(vertices.Count - 4 + 0);
        triangles.Add(vertices.Count - 4 + 2);
        triangles.Add(vertices.Count - 4 + 3);
    }

    void UpdateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices.ToArray();
        mesh.triangles = triangles.ToArray();
        mesh.RecalculateNormals(); //???

    }
}
