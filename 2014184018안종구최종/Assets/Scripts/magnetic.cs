using UnityEngine;
using System.Collections;

public class magnetic : MonoBehaviour {
    Transform tr;
    Vector3 velocity = Vector3.zero;
    // Use this for initialization
    void Start () {
        tr = GameObject.Find("myChar").GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 force = tr.transform.position - gameObject.transform.position;
        float r = force.magnitude;
        force.Normalize();
        force *= 600; // 적당한 힘(자력의 세기)
        force /= r * r;
        Vector3 acc = force / 1.5f;
        velocity += acc * Time.deltaTime;
        if(staticV.magnetic == true)
            transform.position += velocity * Time.deltaTime;
    }
}
