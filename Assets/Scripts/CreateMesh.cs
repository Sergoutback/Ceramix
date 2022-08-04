using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMesh : MonoBehaviour
{
    [SerializeField] private float width = 100f;
    [SerializeField] private float height = 100f;

    void Start()
    {
        MeshFilter m_f = GetComponent<MeshFilter>();
        Mesh mesh = new Mesh();
        m_f.mesh = mesh;


        //verteces
        Vector3[] vert = new Vector3[4]
        {
            new Vector3(0, 0, 0), new Vector3(width, 0, 0), new Vector3(0, height, 0), new Vector3(width, height, 0)
        };


        //triangles
        int[] tri = new int[6];

        tri[0] = 0;
        tri[1] = 2;
        tri[2] = 1;

        tri[3] = 2;
        tri[4] = 3;
        tri[5] = 1;


        //uv textures
        Vector2[] uv = new Vector2[4]
        {
            new Vector2(0, 0), new Vector2(1, 0), new Vector2(0, 1), new Vector2(1, 1)
        };
        
        
        mesh.vertices = vert;
        mesh.triangles = tri;
        mesh.uv = uv;
    }

   

}
