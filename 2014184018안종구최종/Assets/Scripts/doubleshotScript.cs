using UnityEngine;
using System.Collections;

public class doubleshotScript : MonoBehaviour {
    bool doubleCheck;


    // Use this for initialization
    void Start()
    {
        doubleCheck = false;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            doubleCheck = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (doubleCheck == true)
        {
            staticV.doubleShot = true;
            staticV.doubleTimer = Time.time;
            Destroy(gameObject);
        }

        if (transform.position.y < -6)
            Destroy(gameObject);
    }
}
