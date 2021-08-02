using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetScore : MonoBehaviour
{
    [SerializeField] string n;

    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt(n) + ""; 
       
    }

    void Update()
    {
        
    }
}
