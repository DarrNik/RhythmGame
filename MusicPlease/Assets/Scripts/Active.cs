using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class Active : MonoBehaviour
{
    [SerializeField] KeyCode key;
    [SerializeField] Camera rayCamera;
    bool act = false;
    [SerializeField] GameObject btn, gm;
    private bool _mouse = false;
    public Ray ray;
    [SerializeField] GameObject bn;

    [SerializeField] GameObject gObj;
    [SerializeField] bool cMode;

    SpriteRenderer sr, srLose;
    Color clr;

    [SerializeField] GameObject Right, Left; //—юда - кнопку ¬право

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {;
        clr = sr.color;
    }



    private void Update()
    {

        if (cMode)
        {
            if (Input.GetKeyDown(key) /*|| Input.GetMouseButtonDown(0)*/)
            {
                Instantiate(gObj, transform.position, Quaternion.identity);
            }
        }
        else
        {
            if (Input.GetKeyDown(key) /*|| Input.GetMouseButtonDown(0)*/)
            {
                StartCoroutine(Pressed());
            }

            if (Input.GetKeyDown(key)/* || Input.GetMouseButtonDown(0))*/ && act)
            {
                Destroy(btn);
                AddScore();
                act = false;
            }


        }
    }

    //void Update()
    //{
    //    if (cMode)
    //    {
    //        if (Input.GetKeyDown(key) || Input.GetMouseButtonDown(0))
    //        {
    //            Instantiate(gObj, transform.position, Quaternion.identity);
    //        }
    //    }
    //    else
    //    {
    //        if //((Input.GetKeyDown(key) || Input.GetMouseButtonDown(0)) && act)
    //        (Input.touchCount > 0)
    //        {
    //            Touch myTouch = Input.GetTouch(0);
    //            if (Input.touches[0].phase == TouchPhase.Began && act)
    //            {
    //                Ray ray = rayCamera.ScreenPointToRay(myTouch.position);
                    
    //                if (Physics.Raycast(ray, out RaycastHit hit))
    //                {
    //                    Destroy(btn);
    //                    AddScore();
    //                    act = false;
    //                }
    //            }
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

    void AddScore()
        {
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 5);
        }
        IEnumerator Pressed()
        {
            sr.color = new Color(0, 0, 0);
            yield return new WaitForSeconds(0.05f);
            sr.color = clr;
        }
}


