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

    SpriteRenderer sr;
    Color clr;
    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        clr = sr.color;
    }

    private void Update()
    {
        if (Input.GetKeyDown(key) || Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Pressed());
        }

        if ((Input.GetKeyDown(key) || Input.GetMouseButtonDown(0)) && act)
        {
            Destroy(btn);
            StartCoroutine(Pressed());
        }

        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && act)
        //{
        //    if (Input.mousePosition == bn.transform.position)
        //    {
        //        Destroy(btn);
        //    }
        //}
    }

    //void Update()
    //{
    //    if ((Input.GetKeyDown(key) ||  Input.GetMouseButtonDown(0)) && act)//((Input.touchCount > 0) && (Input.touches[0].phase == TouchPhase.Began))) && act)
    //    {
    //        Ray ray = rayCamera.ScreenPointToRay(Input.mousePosition);

    //        if (Physics.Raycast(ray, out RaycastHit hit))
    //        {
    //            Destroy(btn);
    //        }
    //    }

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

    IEnumerator Pressed()
    {
        sr.color = new Color(0, 0, 0);
        yield return new WaitForSeconds(0.05f);
        sr.color = clr;
    }
}
