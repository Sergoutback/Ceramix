using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TailCalculator : MonoBehaviour
{
    public GameObject Tail;

    //[SerializeField] private GameObject BigSquare;
    //[SerializeField] private int width;
    //[SerializeField] private int height; 

    //private int[,] fillBigSquare;

    void Start()
    {
        FillSquare();

        TailPosition();
    }


    private void FillSquare()
    {
        //fillBigSquare = new int [width, height];
        //Tail.SetActive(true);

        for (int h = 0; h < 5; ++h)
        {
            for (int w = 0; w < 5; ++w)
            {
                //Tail.AddComponent<TailCalculator>();
                TailCalculator tail = Tail.GetComponent<TailCalculator>();
                //tail.transform.position = new Vector3(250, 40, 100);
                //Tail.AddComponent<Transform>().Init();
                //var tail = new GameObject();

                //Tail.transform.position = Vector3.MoveTowards(Tail.transform.position, Vector3(250, 40, 100), 1f);
                //InstantiateTail();

                //tail.transform.position = Vector3.MoveTowards(Tail.transform.position, transform.position + Vector3.up, 1f);

                Debug.Log("newTail.transform.position= " + tail.transform.position);
            }
        }
    }
    //private void InstantiateTail()
    //{
    //    Tail = Instantiate(Tail, new Vector3(-240, -440, 0), Quaternion.identity);

        
    //}
    private void TailPosition()
    {
        Transform tailPosition = Tail.GetComponent<Transform>();
    }
}
