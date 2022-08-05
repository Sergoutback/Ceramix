using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeneralNamespace;
using System;

public class TailCalculator : MonoBehaviour
{
    [SerializeField] private float square = new float();

    private float area;


    void Start()
    {
        Mesh mesh = GetComponent<MeshFilter>().sharedMesh;
        area = AreaOfMesh(mesh);
        Debug.Log("The area of the mesh is " + area + " square units.");
    }

    public float AreaOfTriangle(Vector3 p1, Vector3 p2, Vector3 p3)
    {
        float a = Vector3.Distance(p1, p2);
        float b = Vector3.Distance(p2, p3);
        float c = Vector3.Distance(p3, p1);
        float p = 0.5f * (a + b + c);
        float s = Mathf.Sqrt(p * (p - a) * (p - b) * (p - c));
        return s;
    }

    public float AreaOfMesh(Mesh mesh)
    {
        float area = 0f;

        Vector3[] vertices = mesh.vertices;
        int[] triangles = mesh.triangles;

        for (int i = 0; i < mesh.triangles.Length; i += 3)
        {
            Vector3 p1 = vertices[triangles[i + 0]];
            Vector3 p2 = vertices[triangles[i + 1]];
            Vector3 p3 = vertices[triangles[i + 2]];
            area += AreaOfTriangle(p1, p2, p3);
        }

        return area;
    }


    void Update()
    {
        CalculateSquare();
    }

    public void CalculateSquare()
    {
        square = area * FillSquareByTiles.tailCount;
        Debug.Log("The area of the mesh is " + square + " square units.");
    }
}
