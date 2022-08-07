using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace GeneralNamespace
{
    public class TailCalculator : MonoBehaviour
    {
        //public RaycastHit raycast;

        public static float square;

        //[SerializeField] private GameObject bigSquare;

        [SerializeField] private GameObject tail;

        private float area;


        void Start()
        {
            Mesh mesh = tail.GetComponent<MeshFilter>().sharedMesh;
            area = AreaOfMesh(mesh);
            Debug.Log("One tail " + area + " square units.");
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
            //float area = 0f;

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

            RaycastSquare();
        }

        public void CalculateSquare()
        {
            square = area * FillSquareByTiles.tailCount;
            Debug.Log("Tails area " + square + " square units.");
        }

        public void RaycastSquare()
        {
            //Vector3 direction = new Vector3(0f, 0f, 50f);

            RaycastHit[] hit = Physics.RaycastAll(transform.position, transform.forward, 50f, 2);

            Debug.Log("RaycastHit[] hit"+ hit);
        }

    }
}
