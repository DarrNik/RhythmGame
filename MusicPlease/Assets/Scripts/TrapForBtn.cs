using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapForBtn : MonoBehaviour
{
    [SerializeField] GameObject plane, space;

    void Start()
    {
        PlayerPrefs.SetInt("Score", 0);

    }


    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Btn")
        {
            Destroy(c.gameObject);
            if (PlayerPrefs.GetInt("Score") >= 2)
            {
                PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") - 2);
            }
        }
    }

}
