using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace GeneralNamespace
{
    public class UiInput : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] private GameObject inputGO;

        [SerializeField] private Text inputTextValue;

        [SerializeField] private Toggle toggleText;



        public void Start()
        {
            WriteValue();
        }

        public void Update()
        {
            InputString();
            BackGroung();
        }


        public void WriteValue()
        {
            inputTextValue.text = "Write value";

            toggleText.isOn = false;
        }

        public string InputString()
        {
            if ((!(inputTextValue.text == "Write value")) && (toggleText.isOn))

                if ((inputTextValue.text == "0") && Input.anyKeyDown)
                {
                    inputTextValue.text = "";

                    inputTextValue.text += Input.inputString;
                }

                else

                    inputTextValue.text += Input.inputString;

            return inputTextValue.text;
        }

        public void DefaultZero()
        {
            inputTextValue.text = "0";

        }

        public void BackGroung()
        {
            if (!toggleText.isOn)
                inputGO.GetComponent<Image>().color = new Color(255 / 255.0f, 0 / 255.0f, 0 / 255.0f);
            else
                inputGO.GetComponent<Image>().color = new Color(0 / 255.0f, 255 / 255.0f, 0 / 255.0f);
        }


        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.pointerId == -1)

                DefaultZero();
        }
    }
}
