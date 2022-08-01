using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TailCalculator : MonoBehaviour
{
    public GameObject tail;

    public Vector3 tailPosition;

    private GameObject _newTail;

    //[SerializeField] private GameObject BigSquare;
    //[SerializeField] private int width;
    //[SerializeField] private int height; 

    //private int[,] fillBigSquare;

    void Start()
    {
        FillSquare();

        //TailPosition();
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

                //TailCalculator tail = this.prefabTail.GetComponent<TailCalculator>();

                //tail.transform.position = new Vector3(250, 40, 100);
                //Tail.AddComponent<Transform>().Init();
                //var tail = new GameObject();

                //Tail.transform.position = Vector3.MoveTowards(Tail.transform.position, Vector3(250, 40, 100), 1f);
                //InstantiateTail();

                //tail.transform.position = Vector3.MoveTowards(Tail.transform.position, transform.position + Vector3.up, 1f);

                //Debug.Log("newTail.transform.position= " + this.Tail.transform.position);

                //GameObject TailInstance = GameObject.Instantiate(tail) as GameObject;

                TailClone();

                //TailPosition();





                //Transform TailInstanceTransformPosition = TailInstance.GetComponent<Transform>();

                //TailInstance.transform.position = new Vector3(TailInstanceTransformPosition.position.x + 100f, TailInstanceTransformPosition.position.y, TailInstanceTransformPosition.position.z);

                //Debug.Log("prefabInstance.transform.position= " + TailInstance.transform.position);

                //GameObject instanceThroughReference = GameObject.Instantiate(aReferenceToAnInstantiableObject) as GameObject;

                //GameObject Tail = new GameObject("Tail");
            }
        }
    }
    //private void InstantiateTail()
    //{
    //    Tail = Instantiate(Tail, new Vector3(-240, -440, 0), Quaternion.identity);


    //}
    private void TailClone()
    {

        Vector3 tailPos = new Vector3(tailPosition.x, tailPosition.y, tailPosition.z);
        
        var _newTail = Instantiate(tail, tailPos, Quaternion.identity);

        //newTail.transform.localPosition = new Vector3(tailPosition.x + 10f, tailPosition.y, tailPosition.z);

        _newTail.transform.localPosition = new Vector3(tailPos.x + 10f, tailPos.y, tailPos.z);
        Debug.Log("newTail = " + _newTail.transform.position);


        //Transform tailPosition = prefabTail.GetComponent<Transform>();
    }

    //private void TailPosition()
    //{
    //    this._newTail.transform.localPosition = new Vector3(tailPos.x + 10f, tailPos.y, tailPos.z);
    //    Debug.Log("newTail = " + _newTail.transform.position);
    //}
}
