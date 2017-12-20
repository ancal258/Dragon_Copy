using UnityEngine;
using System.Collections;

public class bulletAction : MonoBehaviour {
    public float speed = 10;
    Transform tr;
	// Use this for initialization
	void Start () {
        tr = GetComponent<Transform>();
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "monster")
            Destroy(gameObject);
    }
    // Update is called once per frame
    void Update () {
        tr.transform.Translate(0, speed * Time.deltaTime, 0);
        if(tr.transform.position.y > 6)
        {
            Destroy(gameObject);
        }
	}
}
