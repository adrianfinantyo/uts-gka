using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMonitor : MonoBehaviour
{
    [SerializeField]
    public Material chairMaterial;

    // Variables
    float s = 0.5f;
    float tebal = 0.2f;
    float naik = 0.5f;
    float t = 4.0f;
    float det = 0.2f;

    // Start is called before the first frame update
    void Start()
    {
        // Declaring and initializing values for our mesh
        Mesh mesh = new Mesh();
        var vertices = new Vector3[39];
        var uvs = new Vector2[vertices.Length];

        // Titik-titik tangkai monitor
        vertices[0] = new Vector3(-s, naik, -s);
        vertices[1] = new Vector3(s, naik, -s);
        vertices[2] = new Vector3(-s + det, t + naik, -s + det);
        vertices[3] = new Vector3(s-det, t + naik, -s + det);
        vertices[4] = new Vector3(-s, naik, -s + tebal);
        vertices[5] = new Vector3(s, naik, -s + tebal);
        vertices[6] = new Vector3(-s + det, t + naik, -s + tebal + det);
        vertices[7] = new Vector3(s-det, t + naik, -s + tebal + det);
        vertices[8] = new Vector3(-s, naik, s);
        vertices[9] = new Vector3(-s + det, t + naik, s-det);
        vertices[10] = new Vector3(-s + tebal, naik, s);
        vertices[11] = new Vector3(-s + tebal + det, t + naik, s-det);
        vertices[12] = new Vector3(-s + tebal, naik, -s + tebal);
        vertices[13] = new Vector3(-s + tebal + det, t + naik, -s + tebal + det);

        // Titik-titik kaki monitor
        vertices[14] = new Vector3(-s + t, naik, -s);
        vertices[15] = new Vector3(-s + t, naik, s);
        vertices[16] = new Vector3(-s + t + det, 0, -s - 0.2f);
        vertices[17] = new Vector3(-s + t + det, 0, s + 0.2f);
        vertices[18] = new Vector3(-s, 0, -s);
        vertices[19] = new Vector3(-s, 0, s);
        vertices[20] = new Vector3(-s, naik, -s + t);
        vertices[21] = new Vector3(s, naik, -s + t);
        vertices[22] = new Vector3(-s - 0.2f, 0, -s + t + det);
        vertices[23] = new Vector3(s + 0.2f, 0, -s + t + det);
        vertices[24] = new Vector3(s, 0, -s);

        vertices[25] = new Vector3(-s, naik, -s);
        vertices[26] = new Vector3(s, naik, -s);
        vertices[27] = new Vector3(-s, naik, s);
        vertices[28] = new Vector3(-s + t, naik, -s);
        vertices[29] = new Vector3(-s + t, naik, s);
        vertices[30] = new Vector3(-s + t + det, 0, -s - 0.2f);
        vertices[31] = new Vector3(-s + t + det, 0, s + 0.2f);
        vertices[32] = new Vector3(-s, 0, -s);
        vertices[33] = new Vector3(-s, 0, s);
        vertices[34] = new Vector3(-s, naik, -s + t);
        vertices[35] = new Vector3(s, naik, -s + t);
        vertices[36] = new Vector3(-s - 0.2f, 0, -s + t + det);
        vertices[37] = new Vector3(s + 0.2f, 0, -s + t + det);
        vertices[38] = new Vector3(s, 0, -s);

        mesh.vertices = vertices;

        mesh.triangles = new int[] {
            // Segitiga untuk tangkai monitor
            0, 2, 1,
            2, 3, 1,
            0, 4, 6,
            0, 6, 2,
            5, 6, 4,
            5, 7, 6,
            1, 5, 4,
            1, 4, 0,
            6, 7, 3,
            2, 6, 3,
            3, 7, 5,
            3, 5, 1,

            0, 8, 9,
            2, 0, 9,
            10, 9, 8,
            11, 9, 10,
            13, 11, 10,
            10, 12, 13,
            12, 10, 8,
            4, 12, 8,
            9, 11, 13,
            9, 13, 6,

            // Segitiga kaki monitor
            0, 8, 14,
            15, 14, 8,
            16, 17, 18,
            18, 17, 19,
            14, 15, 16,
            17, 16, 15,
            32, 25, 28,
            28, 30, 32,
            29, 33, 31,
            33, 29, 27,

            20, 1, 0,
            1, 20, 21,
            23, 22, 18,
            24, 23, 18,
            22, 21, 20,
            21, 22, 23,
            32, 36, 34,
            34, 25, 32,
            35, 38, 26,
            37, 38, 35,
        };
        mesh.RecalculateNormals();
        
        uvs[0] = new Vector2(0, 0);
        uvs[1] = new Vector2(0, 1.0f);
        uvs[2] = new Vector2(1.0f, 0);
        uvs[3] = new Vector2(1.0f, 1.0f);
        uvs[4] = new Vector2(1.0f, 1.0f);
        uvs[5] = new Vector2(1.0f, 0);
        uvs[6] = new Vector2(0, 1.0f);
        uvs[7] = new Vector2(0, 0);
        uvs[8] = new Vector2(0, 1.0f);
        uvs[9] = new Vector2(1.0f, 1.0f);
        uvs[10] = new Vector2(1.0f, 1.0f);        
        uvs[11] = new Vector2(0, 1.0f);
        uvs[12] = new Vector2(1.0f, 0);
        uvs[13] = new Vector2(0, 0);

        // Titik-titik kaki monitor
        uvs[14] = new Vector2(1.0f, 0);
        uvs[15] = new Vector2(1.0f, 1.0f);
        uvs[16] = new Vector2(0, 0);
        uvs[17] = new Vector2(0, 1.0f);
        uvs[18] = new Vector2(1.0f, 0);
        uvs[19] = new Vector2(1.0f, 1.0f);
        uvs[20] = new Vector2(1.0f, 0);
        uvs[21] = new Vector2(1.0f, 1.0f);
        uvs[22] = new Vector2(0, 0f);
        uvs[23] = new Vector2(0, 1.0f);
        uvs[24] = new Vector2(1.0f, 1.0f);

        uvs[25] = new Vector2(1.0f, 0);
        uvs[26] = new Vector2(0, 1.0f);
        uvs[27] = new Vector2(0, 1.0f);
        uvs[28] = new Vector2(0, 0);
        uvs[29] = new Vector2(0, 0);
        uvs[30] = new Vector2(0, 1.0f);
        uvs[31] = new Vector2(1.0f, 0);
        uvs[32] = new Vector2(1.0f, 1.0f);
        uvs[33] = new Vector2(1.0f, 1.0f);
        uvs[34] = new Vector2(0, 0);
        uvs[35] = new Vector2(1.0f, 1.0f);
        uvs[36] = new Vector2(0, 1.0f);
        uvs[37] = new Vector2(1.0f, 0f);
        uvs[38] = new Vector2(0f, 0f);

        mesh.uv = uvs;
        GetComponent<MeshFilter>().mesh = mesh;

        GetComponent<MeshRenderer>().material = chairMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }  
}
