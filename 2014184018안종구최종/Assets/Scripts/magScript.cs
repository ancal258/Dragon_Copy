using UnityEngine;
using System.Collections;

public class magScript : MonoBehaviour {
    bool magCheck;


    // Use this for initialization
    void Start()
    {
        magCheck = false;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            magCheck = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (magCheck == true)
        {
            staticV.magnetic = true;
            staticV.magTimer = Time.time;
            Destroy(gameObject);
        }

        if (transform.position.y < -6)
            Destroy(gameObject);
    }
}
