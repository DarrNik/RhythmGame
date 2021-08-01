using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Active : MonoBehaviour
{
    [SerializeField] KeyCode key;
    [SerializeField] Camera rayCamera;
    bool act = false;
    GameObject btn;
    private bool _mouse = false;
    public Ray ray;
    [SerializeField] GameObject bn;

    void Start()
    {
        
    }

    //private void Update()
    //{
    //    //if ((Input.GetKeyDown(key) || Input.GetMouseButtonDown(0)) && act)
    //    //{
    //    //    Destroy(btn);
    //    //}

    //    if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && act)
    //    {
    //            if (Input.mousePosition == bn.transform.position)
    //            {
    //                Destroy(btn);
    //            }
    //    }
    //}

    void Update()
    {
        if ((Input.GetKeyDown(key) ||  Input.GetMouseButtonDown(0)) && act)//((Input.touchCount > 0) && (Input.touches[0].phase == TouchPhase.Began))) && act)
        {
            Ray ray = rayCamera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                Destroy(btn);
            }
        }

    }

    //private void OnMouseDown()
    //{
    //    _mouse = true;
    //}
    //private void OnMouseUp()
    //{
    //    _mouse = false;
    //}


    void OnTriggerEnter2D(Collider2D c)
    {
        act = true;
        if (c.gameObject.tag == "Btn")
        {
            btn = c.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D c)
    {
        act = false;
    }
}
