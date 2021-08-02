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

    SpriteRenderer sr;
    Color clr;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        //gm = GameObject.Find("TrapForBtn");
        clr = sr.color;
    }

    private void Update()
    {
        if (cMode)
        {
            if (Input.GetKeyDown(key) || Input.GetMouseButtonDown(0))
            {
                Instantiate(gObj, transform.position, Quaternion.identity);
            }
        }
        else
        {
            if (Input.GetKeyDown(key) || Input.GetMouseButtonDown(0))
            {
                StartCoroutine(Pressed());
            }

            if ((Input.GetKeyDown(key) || Input.GetMouseButtonDown(0)) && act)
            {
                Destroy(btn);
                AddScore();
                act = false;
            }
            //else 
            //{
            //    PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") - 2);

            //}
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

        //if (PlayerPrefs.GetInt("Score") >= 2)
        //{
        //    PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") - 2);
        //}
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

