using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileCalculator : MonoBehaviour
{
    [SerializeField] private Text seam;
    [SerializeField] private Text corner;
    [SerializeField] private Text offset;
    [SerializeField] private Text square;


    void Start()
    {
        
    }

    void Update()
    {
        seam.text = Input.inputString;

        corner.text = Input.inputString;

        offset.text = Input.inputString;
    }
}
