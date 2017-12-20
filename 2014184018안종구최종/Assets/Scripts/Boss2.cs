using UnityEngine;
using System.Collections;

public class Boss2 : MonoBehaviour {
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
        else if (hpCount == 5)
            sr.sprite = hp[1];
        else if (hpCount == 10)
            sr.sprite = hp[2];
        else if (hpCount == 15)
            sr.sprite = hp[3];
        else if (hpCount == 20)
            sr.sprite = hp[4];
        else if (hpCount == 25)
            sr.sprite = hp[5];
        else if (hpCount == 30)
            sr.sprite = hp[6];
        else if (hpCount == 35)
            sr.sprite = hp[7];
        else if (hpCount == 40)
            sr.sprite = hp[8];
        else if (hpCount == 45)
            sr.sprite = hp[9];
        else if (hpCount == 50)
            sr.sprite = hp[10];
        else if (hpCount == 55)
            sr.sprite = hp[11];
        else if (hpCount == 60)
            sr.sprite = hp[12];
        else if (hpCount == 65)
            sr.sprite = hp[13];
        else if (hpCount == 70)
            sr.sprite = hp[14];
        else if (hpCount > 74)
        {
            Destroy(gameObject);
            staticV.stageCheck = 2;
            staticV.doubleShot = false;
            staticV.magnetic = false;
            Application.LoadLevel("Stage3");
        }
    }
}
