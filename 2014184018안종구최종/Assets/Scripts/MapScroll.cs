using UnityEngine;
using System.Collections;

public class MapScroll : MonoBehaviour {

    public float speed;
    Transform tr;
	// Use this for initialization
	void Start () {
        tr = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        tr.transform.Translate(0, -Time.deltaTime * speed, 0);
        if (tr.transform.position.y < -10)
            tr.transform.Translate(0, 30, 0);
    }
}
