using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchToggle : MonoBehaviour
{
    [SerializeField] RectTransform uirect;
    Toggle toggle;
    Vector2 hP;

    void Awake()
    {
        toggle = GetComponent<Toggle>();
        hP = uirect.anchoredPosition;
        toggle.onValueChanged.AddListener(OnSwitch);

        if (toggle.isOn)
            OnSwitch(true);
    }

    void OnSwitch(bool on)
    {
        if (on) 
        {
            uirect.anchoredPosition = hP * -1; 
        }
        else 
        {
            uirect.anchoredPosition = hP; 
        }
    }

}
