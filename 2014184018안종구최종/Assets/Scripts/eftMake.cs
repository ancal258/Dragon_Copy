using UnityEngine;
using System.Collections;

public class eftMake : MonoBehaviour {
    public GameObject flare;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "monster")
        Instantiate(flare, transform.position, Quaternion.identity);
    }
}
