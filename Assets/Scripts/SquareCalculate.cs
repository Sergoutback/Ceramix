using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GeneralNamespace
{

    public class SquareCalculate : MonoBehaviour
    {
        public Text squareText;

        [SerializeField] private GameObject goBigSquareMesh;

        //[SerializeField] private GameObject goTailMesh;

        private static float bigSquare;
        
        //private static float tailsSquare;

        private static float totalSquare;


        // Update is called once per frame
        void Update()
        {
            squareText.text = Convert.ToString(totalSquare);
        }

        public void TotalSquare()
        {
            totalSquare = bigSquare - TailCalculator.square;
        }

        public void BigSquare()
        {
            Mesh bigSquareMesh = goBigSquareMesh.GetComponent<MeshFilter>().sharedMesh;
            bigSquare = AreaOfMesh(bigSquareMesh);
            Debug.Log("bigSquare " + bigSquare + " square units.");
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
                bigSquare += AreaOfTriangle(p1, p2, p3);
            }

            return bigSquare;
        }
    }
}
