using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchToggle : MonoBehaviour
{
    [SerializeField] RectTransform uirect;
    Toggle toggle;
    Vector2 hP;
    static bool state = true;


    void Awake()
    {
        toggle = GetComponent<Toggle>();
        hP = uirect.anchoredPosition;
        toggle.onValueChanged.AddListener(OnSwitch);

        toggle.isOn = state;

        if (toggle.isOn)
            OnSwitch(true);
        
    }
    void OnSwitch(bool on)
    {
        if (on) 
        {
            uirect.anchoredPosition = hP;
            AudioListener.volume = 1;
            state = true;
        }
        else 
        {
            uirect.anchoredPosition = hP * -1;
            AudioListener.volume = 0;
            state = false;
        }
    }

}
