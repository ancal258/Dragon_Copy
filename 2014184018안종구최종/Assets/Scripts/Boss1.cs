using UnityEngine;
using System.Collections;

public class Boss1 : MonoBehaviour
{
    public float speed = 3;
    int hpCount = 0;
    public GameObject HP;
    public Sprite[] hp;


    Transform tr;
    SpriteRenderer sr;

    // 보스 총알
    public GameObject bossBullet;
    private float selfTimer = 0.0f;
    // Use this for initialization
    void Start()
    {
        tr = GetComponent<Transform>();
        sr = HP.GetComponent<SpriteRenderer>();

        selfTimer = Time.time + 1.0f;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "bullet")
        {
            hpCount++;
        }
        else if(col.tag == "bullet2")
        {
            hpCount += 2;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //보스 총알 발사
        if (selfTimer < Time.time)
        {
            bossBullet.transform.position = this.transform.position;
            Instantiate<Object>(bossBullet);
            selfTimer = Time.time + 0.1f;
        }

        if (tr.transform.position.y > 3)
        {
            tr.transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        if (hpCount == 0)
            sr.sprite = hp[0];
        else if (hpCount == 4)
            sr.sprite = hp[1];
        else if (hpCount == 8)
            sr.sprite = hp[2];
        else if (hpCount == 12)
            sr.sprite = hp[3];
        else if (hpCount == 15)
            sr.sprite = hp[4];
        else if (hpCount == 19)
            sr.sprite = hp[5];
        else if (hpCount == 21)
            sr.sprite = hp[6];
        else if (hpCount == 23)
            sr.sprite = hp[7];
        else if (hpCount == 27)
            sr.sprite = hp[8];
        else if (hpCount == 32)
            sr.sprite = hp[9];
        else if (hpCount == 36)
            sr.sprite = hp[10];
        else if (hpCount == 40)
            sr.sprite = hp[11];
        else if (hpCount == 44)
            sr.sprite = hp[12];
        else if (hpCount == 48)
            sr.sprite = hp[13];
        else if (hpCount == 53)
            sr.sprite = hp[14];
        else if (hpCount > 57)
        {
            Destroy(gameObject);
            staticV.stageCheck = 1;
            staticV.doubleShot = false;
            staticV.magnetic = false;
            Application.LoadLevel("Stage2");
        }
    }
}
