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

        [SerializeField] Rigidbody tailRigidbody;

        //[SerializeField] ContactFilter2D contactFilter;

        [SerializeField] private GameObject tail;

        [SerializeField] private GameObject BigSquare;

        [SerializeField] private LayerMask layerMask;

        private RaycastHit raycastHit;

        private bool hit;

        private int hitCount;

        private int [] hits;

        private Ray ray;

        private float area;

        private float areaOfArray;

        private int [,] squareArray = new int[5, 5];


        void Start()
        {
            Mesh mesh = tail.GetComponent<MeshFilter>().sharedMesh;
            area = AreaOfMesh(mesh);
            //Debug.Log("One tail " + area + " square units.");
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
            //Debug.Log("Tails area " + square + " square units.");
        }

        public int RaycastSquare()
        {
            // получаем маску, которая затрагивает только слой Player
            int layerMaskOnlyPlayer = 1 << 6;

            Debug.Log("layerMaskOnlyPlayer " + layerMaskOnlyPlayer);
            // получаем маску, которая затрагивает все слои, кроме слоя Player
            //int layerMaskWithoutPlayer = ~layerMaskOnlyPlayer;

           int i = 0;

            hitCount = 0;

            hits = new int[100];

            hit = Physics.Raycast(tail.transform.position, tail.transform.forward, 1000f, layerMaskOnlyPlayer);

            Debug.DrawRay(tail.transform.position, tail.transform.forward, Color.red, 1000f);
            
            for (hitCount = 0; hitCount < hits.Length; hitCount++)
            {
                if (hit)
                {
                    hits[i] = hitCount;

                    Debug.Log("Попал в " + hit);
                }

                else
                {
                    Debug.Log("Не попал ");
                }
            }

            Debug.Log("hitCount== " + hitCount);

            return hitCount;

            //if (hits.Length > 0)
            //{
            //    Debug.Log("RaycastHit[] hit" + hits.Length);
            //}

            //var collisionCount = tailRigidbody.collisionDetectionMode(hit);

            //for (int i = 0; i < hits.Length; i++)
            //{
            //    //RaycastHit hit = hits[i]; 

            //    Renderer rend = hit.transform.GetComponent<Renderer>();

            //    if (rend)
            //    {
            //        // Change the material of all hit colliders
            //        // to use a transparent shader.
            //        rend.material.shader = Shader.Find("Transparent/Diffuse");
            //        Color tempColor = rend.material.color;
            //        tempColor.a = 0.3F;
            //        rend.material.color = tempColor;
            //    }
            //}
        }
    }
}