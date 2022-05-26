using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CubeMeshData
{
    public static Vector3[] vertices =
    {   
        new Vector3(-1,-1,-1), // 0
        new Vector3(1,-1,-1), // 1
        new Vector3(1,-1,1), // 2
        new Vector3(-1,-1,1), // 3
        new Vector3(1,1,-1), // 4
        new Vector3(1,1,1), // 5
        new Vector3(-1,1,1), // 6
        new Vector3(-1,1,-1) // 7
        
    };

    public static int[][] faceTriangles = 
    {     
        new int[] {5,6,3,2},
        new int[] {4,5,2,1},
        new int[] {7,4,1,0},
        new int[] {6,7,0,3},
        new int[] {4,7,6,5},
        new int[] {2,3,0,1}
        
    };

    public static Vector3[] faceVertices(int dir)
    {
        Vector3[] fv = new Vector3[4];
        for (int i = 0; i < fv.Length; i++)
        {
            fv[i] = vertices[faceTriangles[dir][i]];
        }
        return fv;
    }
}
