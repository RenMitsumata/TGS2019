using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   // [SerializeField]
   //private GameObject gameObject;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
        //gameObject.GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("pass");
        if (Input.GetButtonDown("A"))
        {
            Debug.Log("Aボタンが押されました");
        }
    }


}
