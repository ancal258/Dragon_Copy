using UnityEngine;
using System.Collections;

public class rock : MonoBehaviour {
    Transform tr;
    public float speed = 7;

    // Use this for initialization
    void Start () {
        tr = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update () {
        tr.transform.Translate(0, -speed * Time.deltaTime * 0.85f, 0);
        if (tr.transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
}
