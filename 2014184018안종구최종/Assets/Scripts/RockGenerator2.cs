using UnityEngine;
using System.Collections;

public class RockGenerator2 : MonoBehaviour {
    public GameObject rock;
    private int randRock;
    private float selfTimer = 0.0f;
    private float startTimer = 0.0f;
    // Use this for initialization
    void Start()
    {
        selfTimer = Time.time + 7.6f;
        startTimer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (selfTimer - startTimer < 30)
        {
            if (selfTimer < Time.time)
            {
                randRock = Random.Range(0, 150);
                if (randRock == 2)
                {
                    rock.transform.position = this.transform.position;
                    Instantiate<Object>(rock);
                    selfTimer = Time.time + 7.6f;
                }
            }
        }
        else
            selfTimer = Time.time + 1.2f;

    }
}
