using UnityEngine;
using System.Collections;
using System.IO;

public class coin : MonoBehaviour {
    bool coinCheck;
    private uiManager um = null;


    // Use this for initialization
    void Start () {
       
        coinCheck = false;
        um = GameObject.Find("TextUI").GetComponent<uiManager>();
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            um.coinUp(1);
            coinCheck = true;
        }
    }
    // Update is called once per frame
    void Update () {
        
        

        if (coinCheck == true)
            Destroy(gameObject);

        if (transform.position.y < -6)
            Destroy(gameObject);
	}
}
