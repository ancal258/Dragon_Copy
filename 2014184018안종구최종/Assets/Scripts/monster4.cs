using UnityEngine;
using System.Collections;

public class monster4 : MonoBehaviour {
    public float speed = 7;
    int hpCount = 0;
    Transform tr;
    SpriteRenderer sr;
    private int randCoin;


    // 아이템 , HP바 
    public GameObject HP;
    public Sprite[] hp;
    public GameObject coin;
    public GameObject coin2;
    public GameObject doubleShot;
    public GameObject mag;
    // 총알
    public GameObject monsterBullet;


    private float selfTimer = 0.0f;


    // Use this for initialization
    void Start()
    {
        selfTimer = Time.time + 0.5f;

        randCoin = Random.Range(0, 23);

        //sr = GetComponent<SpriteRenderer>();
        tr = GetComponent<Transform>();
        sr = HP.GetComponent<SpriteRenderer>();
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
        // 몬스터 총알 발사
        if (selfTimer < Time.time)
        {
            monsterBullet.transform.position = this.transform.position;
            Instantiate<Object>(monsterBullet);
            selfTimer = Time.time + 1.5f;
        }

        tr.transform.Translate(0, -speed * Time.deltaTime * 0.85f, 0);
        if (tr.transform.position.y < -6)
        {
            Destroy(gameObject);
        }
        if (hpCount == 0)
            sr.sprite = hp[0];
        else if (hpCount == 2)
            sr.sprite = hp[1];
        else if (hpCount == 4)
            sr.sprite = hp[2];
        else if (hpCount == 6)
            sr.sprite = hp[2];
        else if (hpCount > 7)
        {
            if (randCoin <= 13)
            {
                coin.transform.position = this.transform.position;
                Instantiate<Object>(coin);
            }
            else if (randCoin > 13 && randCoin <= 16)
            {
                coin2.transform.position = this.transform.position;
                Instantiate<Object>(coin2);
            }
            else if (randCoin > 17 && randCoin <= 20)
            {
                doubleShot.transform.position = this.transform.position;
                Instantiate<Object>(doubleShot);
            }
            else if (randCoin > 20 && randCoin <= 22)
            {
                mag.transform.position = this.transform.position;
                Instantiate<Object>(mag);
            }
            Destroy(gameObject);
        }
    }
}
