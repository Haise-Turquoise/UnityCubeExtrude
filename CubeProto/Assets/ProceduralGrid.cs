using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]

public class ProceduralGrid : MonoBehaviour
{

    Mesh mesh;
    Vector3[] vertices;
    int[] triangles;

    public float cellSize = 1;
    public Vector3 gridOffset;
    int gridSize;
    


    void Awake()
    {
        mesh = GetComponent<MeshFilter>().mesh;
    }

    // Update is called once per frame
    void Start()
    {
        MakeProceduralGrid();
        UpdateMesh();
    }

    void MakeProceduralGrid()
    {
        vertices = new Vector3[4];
        triangles = new int[6];
        float vertexOffset = cellSize * 0.5f;
        vertices[0] = new Vector3(-vertexOffset, 0, -vertexOffset)+gridOffset;
        vertices[1] = new Vector3(-vertexOffset, 0, vertexOffset) + gridOffset;
        vertices[2] = new Vector3(vertexOffset, 0, -vertexOffset) + gridOffset;
        vertices[3] = new Vector3(vertexOffset, 0, vertexOffset) + gridOffset;

        triangles[0] = 0;
        triangles[1] = 1;
        triangles[2] = 2;
        triangles[3] = 2;
        triangles[4] = 1;
        triangles[5] = 3;
    }

    void UpdateMesh()
    {
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.RecalculateNormals();
    }
}    
