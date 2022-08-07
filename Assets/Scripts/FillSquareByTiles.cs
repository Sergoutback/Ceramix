using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GeneralNamespace
{
    public class FillSquareByTiles : MonoBehaviour
    {
        public static float tailCount;

        [SerializeField] private GameObject parent;

        [SerializeField] private GameObject tail;

        [SerializeField] private Text seam;

        [SerializeField] private Text corner;

        [SerializeField] private Text offset;

        private float seamFloat;

        private float cornerFloat;

        private float offsetFloat;

        private Quaternion parentRotation;



        //private Vector3 tailPosition;



        void Start()
        {
            FillSquare();
        }

        private void Update()
        {
            seamFloat = (float)Convert.ToDouble(seam.text);

            cornerFloat = (float)Convert.ToDouble(corner.text);

            offsetFloat = (float)Convert.ToDouble(offset.text);

            ParentRotation();
        }
        private void ParentRotation()
        {
            parent.transform.rotation = Quaternion.Euler(0f, 0f, -cornerFloat);
            
        }


        private void FillSquare()
        {

            Vector3 tailPosition = new Vector3();

            tailPosition = new Vector3(tail.transform.localPosition.x, tail.transform.localPosition.y, 0f);

            for (int h = 0; h < 5; ++h)
            {
                tailPosition.x = -340f + offsetFloat;

                tailPosition.y += 110f;

                for (int w = 0; w < 5; ++w)
                {
                    TailCount();

                    GameObject newTail = Instantiate(tail, tailPosition, Quaternion.identity) as GameObject;

                    newTail.transform.SetParent(parent.transform, false);

                    newTail.transform.localScale = new Vector3(1, 1, 1);

                    tailPosition.x += 110f;

                    newTail.transform.localPosition = tailPosition;
                }
            }
        }

        public void TailCount()
        {
            tailCount++;
        }
    }
}