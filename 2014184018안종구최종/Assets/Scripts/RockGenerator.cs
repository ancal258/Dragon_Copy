using UnityEngine;
using System.Collections;

public class RockGenerator : MonoBehaviour {
    public GameObject rock;
    private int randRock;
    private float selfTimer = 0.0f;
    private float startTimer = 0.0f;
    // Use this for initialization
    void Start()
    {
        selfTimer = Time.time + 8.6f;
        startTimer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        randRock = Random.Range(0,200);
        if (selfTimer - startTimer < 30)
        {
            if (selfTimer < Time.time)
            {
                if (randRock == 2)
                {
                    rock.transform.position = this.transform.position;
                    Instantiate<Object>(rock);
                    selfTimer = Time.time + 8.6f;
                }
            }
        }
        else
            selfTimer = Time.time + 1.2f;

    }
}
