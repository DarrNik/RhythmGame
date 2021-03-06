using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarOfTime : MonoBehaviour
{
    [SerializeField] Image bar;
    [SerializeField] float fill;
    [SerializeField] AudioSource music;
    [SerializeField] GameObject star;
    float l;

    [SerializeField] static int scr;

    void Start()
    {
        
        fill = 0f;
        l = Mathf.Abs(star.transform.localPosition.x)*2;
        Debug.Log(l);
    }

    // Update is called once per frame
    void Update()
    {
        if (fill <= 1)
        {
            star.transform.position += new Vector3(Time.deltaTime / music.clip.length * l, 0);
            fill += Time.deltaTime / music.clip.length;
            bar.fillAmount = fill;

        }
        else
        {
            scr = PlayerPrefs.GetInt("Score");
            SceneManager.LoadScene("End");
            //SetScore.Start();
        }
    }
}
