using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace GeneralNamespace
{
    public class UiInput : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private Text inputText;



        void Start()
        {
            inputText.text = ("Write value");
        }



        void Update()
        {
            if ((!(inputText.text == "Write value")) || (Input.GetMouseButton(1)))
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
}
