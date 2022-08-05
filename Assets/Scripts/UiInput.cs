using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace GeneralNamespace
{
    public class UiInput : InputInstance
    {
        //[SerializeField] private GameObject inputSeam;

        //[SerializeField] private GameObject inputCorner;

        //[SerializeField] private GameObject inputOffset;

        //[SerializeField] private Text inputSeamText;

        //[SerializeField] private Text inputCornerText;

        //[SerializeField] private Text inputOffsetText;


        //[SerializeField] private Toggle toggleSeamText;

        //[SerializeField] private Toggle toggleCornerText;

        //[SerializeField] private Toggle toggleOffsetText;



        public void Start()
        {
            WriteValue();
        }

        public void Update()
        {
            InputString();

        }
    }



    public class InputInstance : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private GameObject inputGO;

        [SerializeField] private Text inputTextValue;

        [SerializeField] private Toggle toggleText;

        public void WriteValue()
        {
            inputTextValue.text = "Write value";

            toggleText.isOn = false;
        }

        public string InputString()
        {
            if ((!(inputTextValue.text == "Write value")) && (toggleText.isOn))
                inputTextValue.text += Input.inputString;
                return inputTextValue.text;
        }

        public void DefaultZero()
        {
            inputTextValue.text = ("0");

        }


        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.pointerId == -1)

                DefaultZero();
        }

    }
    
}
