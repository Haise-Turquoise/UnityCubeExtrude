using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Add(5, 10));
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    [DllImport("cube.dll")]
    private static extern int Add(int a, int b);
}
