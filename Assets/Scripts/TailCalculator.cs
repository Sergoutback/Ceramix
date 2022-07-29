using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TailCalculator : MonoBehaviour
{
    [SerializeField] private GameObject BigSquare;

    public GameObject Tail;

    private int[,] fillBigSquare;

    void Start()
    {
        FillSquare();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FillSquare()
    {
        fillBigSquare = new int [5, 5];

        for (int w = 0; w < 5; ++w)
        {
            for (int h = 0; h < 5; ++h)
            {
                this.Tail = new GameObject();

                Tail.transform.position = Vector3.right;

                Tail.transform.position = Vector3.up;

                Debug.Log("Tail.transform.position= "+ Tail.transform.position);
            }
        }
    }
}
