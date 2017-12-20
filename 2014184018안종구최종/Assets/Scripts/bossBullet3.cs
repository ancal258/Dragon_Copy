using UnityEngine;
using System.Collections;

public class bossBullet3 : MonoBehaviour {

    private Transform tr;
    public GameObject myChar;
    private float x, y; // 탄환의 좌표
    private float vx, vy; // 탄환의 속도 벡터
    public float speed = 6; 
    private float theta; // 속도와 각도

    // Use this for initialization
    void Start()
    {
        theta = staticV.bossBullet2;
        if (staticV.bossBullet2 > 360)
            staticV.bossBulletCheck = true;
        if (staticV.bossBullet2 < 180)
            staticV.bossBulletCheck = false;

        if (staticV.bossBulletCheck == false)
            staticV.bossBullet2 += 7.5f;
        if (staticV.bossBulletCheck == true)
            staticV.bossBullet2 -= 7.5f;
        tr = GetComponent<Transform>();
        vx = Mathf.Cos(Mathf.PI / 180 * theta) * speed / 40 * Time.deltaTime;
        vy = Mathf.Sin(Mathf.PI / 180 * theta) * speed / 40 * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        x += vx;
        y += vy;
        tr.transform.Translate(x, y * 0.5f, 0);

        //if (tr.transform.position.y < -6
        //    || tr.transform.position.x > 4.5
        //    || tr.transform.position.x < -4.5)
        //{
        //    Destroy(gameObject);
        //}
    }

}
