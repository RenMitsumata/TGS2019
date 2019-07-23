using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawner : MonoBehaviour
{
    public GameObject enemy;
    int Cnt;
    // Start is called before the first frame update
    void Start()
    {
        Cnt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Cnt++;
        if (Cnt > 300)
        {
            Vector3 vec = new Vector3(Random.Range(-10.0f,10.0f),2.0f, Random.Range(-10.0f, 10.0f));
            Instantiate(enemy,vec, Quaternion.identity);
            Cnt = 0;
        }
    }
}
