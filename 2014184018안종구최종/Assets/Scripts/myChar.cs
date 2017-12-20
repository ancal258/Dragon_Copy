using UnityEngine;
using System.Collections;
using System.IO;

public class myChar : MonoBehaviour {
    public float speed = 5;
    public GameObject bullet;
    public GameObject bullet_;

    public GameObject bullet2;
    public GameObject bullet2_;

    public GameObject bullet3;
    public GameObject bullet3_;
    public GameObject bullet4;
    public GameObject bullet4_;
    public bool deathCheck = false;
    private float selfTimer = 0.0f;
    private uiManager um = null;



    // Use this for initialization
    void Start () {
        um = GameObject.Find("TextUI").GetComponent<uiManager>();

        selfTimer = Time.time + 0.1f;
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "monster" || col.tag == "bossBullet")
        {
            deathCheck = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
        // 총알 발사
        if (selfTimer < Time.time){
            if (staticV.bulletCount == 0)
            {
                if (staticV.doubleShot == false)
                {
                    bullet.transform.position = this.transform.position;
                    Instantiate<Object>(bullet);
                    selfTimer = Time.time + 0.1f;
                }
                else
                {
                    bullet.transform.position = this.transform.position;
                    bullet.transform.Translate(0.5f, 0.2f, 0);
                    Instantiate<Object>(bullet);
                    selfTimer = Time.time + 0.1f;

                    bullet_.transform.position = this.transform.position;
                    bullet_.transform.Translate(-0.5f, 0.2f, 0);

                    Instantiate<Object>(bullet_);
                    selfTimer = Time.time + 0.1f;
                }
            }
            else if (staticV.bulletCount == 1)
            {
                if (staticV.doubleShot == false)
                {
                    bullet2.transform.position = this.transform.position;
                    Instantiate<Object>(bullet2);
                    selfTimer = Time.time + 0.1f;
                }
                else
                {
                    bullet2.transform.position = this.transform.position;
                    bullet2.transform.Translate(0.5f, 0.2f, 0);
                    Instantiate<Object>(bullet2);
                    selfTimer = Time.time + 0.1f;

                    bullet2_.transform.position = this.transform.position;
                    bullet2_.transform.Translate(-0.5f, 0.2f, 0);

                    Instantiate<Object>(bullet2_);
                    selfTimer = Time.time + 0.1f;
                }
            }
            else if (staticV.bulletCount == 2)
            {
                if (staticV.doubleShot == false)
                {
                    bullet3.transform.position = this.transform.position;
                    Instantiate<Object>(bullet3);
                    selfTimer = Time.time + 0.1f;
                }
                else
                {
                    bullet3.transform.position = this.transform.position;
                    bullet3.transform.Translate(0.5f, 0.2f, 0);
                    Instantiate<Object>(bullet3);
                    selfTimer = Time.time + 0.1f;

                    bullet3_.transform.position = this.transform.position;
                    bullet3_.transform.Translate(-0.5f, 0.2f, 0);

                    Instantiate<Object>(bullet3_);
                    selfTimer = Time.time + 0.1f;
                }
            }
            else if (staticV.bulletCount == 3)
            {
                if (staticV.doubleShot == false)
                {
                    bullet4.transform.position = this.transform.position;
                    Instantiate<Object>(bullet4);
                    selfTimer = Time.time + 0.1f;
                }
                else
                {
                    bullet4.transform.position = this.transform.position;
                    bullet4.transform.Translate(0.5f, 0.2f, 0);
                    Instantiate<Object>(bullet4);
                    selfTimer = Time.time + 0.1f;

                    bullet4_.transform.position = this.transform.position;
                    bullet4_.transform.Translate(-0.5f, 0.2f, 0);

                    Instantiate<Object>(bullet4_);
                    selfTimer = Time.time + 0.1f;
                }
            }

        }
        if (staticV.doubleShot == true)
        {
            if (Time.time - staticV.doubleTimer > 5.0f)
            {
                staticV.doubleShot = false;
            }
        }

        if (staticV.magnetic == true)
        {
            if (Time.time - staticV.magTimer > 5.0f)
            {
                staticV.magnetic = false;
            }
        }

        // 양 끝 이동 불가
        if (transform.position.x < -3.55)
            transform.position = new Vector3((float)-3.55, this.transform.position.y, this.transform.position.z);
        if (transform.position.x > 3.55)
            transform.position = new Vector3((float)3.55, this.transform.position.y, this.transform.position.z);

        // 죽으면
        if (deathCheck)
        {
            staticV.doubleShot = false;
            staticV.magnetic = false;
            Application.LoadLevel("store");
        }
        if(staticV.boss3Check==2)
            Application.LoadLevel("Stage4");

    }

}
