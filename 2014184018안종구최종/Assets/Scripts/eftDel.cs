using UnityEngine;
using System.Collections;

public class eftDel : MonoBehaviour {

    public float timer = 0.3f;

    void Start()
    {
        Destroy(gameObject, timer);
    }
}
