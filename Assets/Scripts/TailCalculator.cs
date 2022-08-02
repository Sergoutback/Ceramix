using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TailCalculator : MonoBehaviour
{
    [SerializeField] private GameObject parent;

    [SerializeField] private GameObject tail;

    //private Vector3 tailPosition;



    void Start()
    {
        FillSquare();
    }


    private void FillSquare()
    {

        Vector3 tailPosition = new Vector3();

        tailPosition = new Vector3(tail.transform.localPosition.x, tail.transform.localPosition.y, 0f);

        for (int h = 0; h < 5; ++h)
        {
            for (int w = 0; w < 5; ++w)
            {
                //Vector3 tailPosition = new Vector3();

                //tailPosition = new Vector3(tail.transform.localPosition.x, tail.transform.localPosition.y, 0f);

                GameObject newTail = Instantiate(tail, tailPosition, Quaternion.identity) as GameObject;

                newTail.transform.SetParent(parent.transform, false);

                newTail.transform.localScale = new Vector3(1, 1, 1);

                //for (tailPosition.y = -450f; tailPosition.y < 50; ++tailPosition.y)

                    tailPosition.y += 100f;

                //for (tailPosition.x = -250f; tailPosition.x < 250; ++tailPosition.x)

                    tailPosition.x += 100f;

                

                newTail.transform.localPosition = tailPosition;
            }
        }


    }

                //    if (tailPosition.y > -450f || tailPosition.y< 50f)

                //    tailPosition.y += 100f;
                //else
                //    tailPosition.y = -450f;


                //if (tailPosition.x > -250f || tailPosition.x< 250f)

                //    tailPosition.x += 100f;
                //else
                //    tailPosition.x = -250f;


    //private void TailClone()
    //{

    //    tailPosition = new Vector3(this.tail.transform.position.x, this.tail.transform.position.y, this.tail.transform.position.z);

    //    GameObject tail = Instantiate(this.tail, tailPosition, Quaternion.identity) as GameObject;

    //    tail.transform.parent = transform;


        //_newTail = Instantiate(tail, tailPosition, Quaternion.identity);

        //newTail.transform.localPosition = new Vector3(tailPosition.x + 10f, tailPosition.y, tailPosition.z);

        //tail.transform.localPosition = new Vector3(tailPosition.x, tailPosition.y, tailPosition.z);

        //Debug.Log("newTail = " + tail.transform.localPosition);


        //Transform tailPosition = prefabTail.GetComponent<Transform>();

    //private void InstantiateTail()
    //{
    //    Tail = Instantiate(Tail, new Vector3(-240, -440, 0), Quaternion.identity);


    //}

    //private void TailPosition()
    //{
    //    this._newTail.transform.localPosition = new Vector3(tailPos.x + 10f, tailPos.y, tailPos.z);
    //    Debug.Log("newTail = " + _newTail.transform.position);
    //}

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

    //TailPosition();

    //Transform TailInstanceTransformPosition = TailInstance.GetComponent<Transform>();

    //TailInstance.transform.position = new Vector3(TailInstanceTransformPosition.position.x + 100f, TailInstanceTransformPosition.position.y, TailInstanceTransformPosition.position.z);

    //Debug.Log("prefabInstance.transform.position= " + TailInstance.transform.position);

    //GameObject instanceThroughReference = GameObject.Instantiate(aReferenceToAnInstantiableObject) as GameObject;

    //GameObject Tail = new GameObject("Tail");
    //}

}