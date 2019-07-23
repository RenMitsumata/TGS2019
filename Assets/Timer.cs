using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float startTime = 180.0f;
    private bool once = false;
    Text textTime;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        startTime -= Time.deltaTime;
        textTime = GetComponent<Text>();
        textTime.text = "Time:" + startTime.ToString("F2");
        if(startTime < 10.0f && !once)
        {
            textTime.color = new Color(1.0f, 0.0f, 0.0f);
            once = true;
        }
        if(startTime <= 0.0f)
        {
            SceneManager.LoadScene("Title");
        }
    }
}
