using UnityEngine;
using System.Collections;

public class MonsterGenerator : MonoBehaviour
{
    public GameObject[] monster;
    private int monsterNum;
    private int monsterNum2;
    private bool bossCheck;
    private float selfTimer = 0.0f;
    private float startTimer = 0.0f;
    // Use this for initialization
    void Start()
    {
        selfTimer = Time.time + 0.7f;
        startTimer = Time.time;
        bossCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        monsterNum = Random.Range(0, 2);
        monsterNum2 = Random.Range(0, 3);

        if (selfTimer - startTimer < 10)
        {
            if (selfTimer < Time.time)
            {
                monster[monsterNum].transform.position = this.transform.position;
                Instantiate<Object>(monster[monsterNum]);
                selfTimer = Time.time + 1.2f;
            }
        }
        else if (selfTimer - startTimer >= 10 &&
                 selfTimer - startTimer < 33)
        {
            if (selfTimer < Time.time)
            {
                monster[monsterNum2].transform.position = this.transform.position;
                Instantiate<Object>(monster[monsterNum2]);
                selfTimer = Time.time + 1.2f;
            }
        }
        else if (selfTimer - startTimer >= 33 &&
                 selfTimer - startTimer < 35)
        {
            if (selfTimer < Time.time)
            {
                selfTimer = Time.time + 1.2f;
            }

        }
        else if (selfTimer - startTimer > 35)
        {
            if (bossCheck == false)
            {
                bossCheck = true;
                monster[3].transform.position = this.transform.position;
                Instantiate<Object>(monster[3]);
                selfTimer = Time.time + 1.0f;
            }
        }
    }
}
