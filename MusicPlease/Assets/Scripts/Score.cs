using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] string name;
    
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = PlayerPrefs.GetInt(name) + "";
    }
}
