using UnityEngine;
using System.Collections;

public class Boss3 : MonoBehaviour {
    public float speed = 6;
    int hpCount = 0;
    public GameObject HP;
    public Sprite[] hp;


    Transform tr;
    SpriteRenderer sr;

    // 보스 총알
    public GameObject bossBullet;
    public GameObject bossBullet2;

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
        else if (col.tag == "bullet2")
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

            bossBullet2.transform.position = this.transform.position;
            bossBullet2.transform.Translate(0.5f, 0, 0);
            Instantiate<Object>(bossBullet2);
            selfTimer = Time.time + 0.1f;

            bossBullet.transform.position = this.transform.position;
            bossBullet2.transform.Translate(-0.5f, 0, 0);

            Instantiate<Object>(bossBullet);
            selfTimer = Time.time + 0.1f;
        }

        if (tr.transform.position.y > 4)
        {
            tr.transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        if (hpCount == 0)
            sr.sprite = hp[0];
        else if (hpCount == 5)
            sr.sprite = hp[1];
        else if (hpCount == 10)
            sr.sprite = hp[2];
        else if (hpCount == 15)
            sr.sprite = hp[3];
        else if (hpCount == 22)
            sr.sprite = hp[4];
        else if (hpCount == 27)
            sr.sprite = hp[5];
        else if (hpCount == 32)
            sr.sprite = hp[6];
        else if (hpCount == 37)
            sr.sprite = hp[7];
        else if (hpCount == 42)
            sr.sprite = hp[8];
        else if (hpCount == 47)
            sr.sprite = hp[9];
        else if (hpCount == 53)
            sr.sprite = hp[10];
        else if (hpCount == 59)
            sr.sprite = hp[11];
        else if (hpCount == 63)
            sr.sprite = hp[12];
        else if (hpCount == 68)
            sr.sprite = hp[13];
        else if (hpCount == 73)
            sr.sprite = hp[14];
        else if (hpCount > 80)
        {
            staticV.boss3Check++;
            Destroy(gameObject);
        }
    }
}
