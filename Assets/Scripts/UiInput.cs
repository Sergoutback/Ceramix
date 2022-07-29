using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UiInput : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Text inputText;



    void Start()
    {
        inputText.text = ("Write value");
    }

    

    void Update()
    {
        if(inputText.text != "Write value")
            
            inputText.text += Input.inputString;
    }

    private void DefaultZero()
    {
        inputText.text = ("0");
        
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.pointerId == -1)

            DefaultZero();
    }

    
}
