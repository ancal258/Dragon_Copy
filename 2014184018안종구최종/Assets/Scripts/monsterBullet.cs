using UnityEngine;
using System.Collections;

public class monsterBullet : MonoBehaviour {


    // 메인 캐릭터
    public GameObject mc;
    private Transform myChar;

    // 총알
    private Transform tr;

    //탄환 설정
    private float
        mx, my, // 메인 캐릭터
        bulletSpeed = 6, // 탄환의 속도
        ex = 0, ey = 0, // 적기의 좌표 (0,0 고정)
        x, y, // 탄환의 좌표
        vx, vy, // 탄환의 속도벡터
        d; // 거리


    public float speed = 6, theta; // 속도와 각도

    // Use this for initialization
    void Start () {
        
        myChar = mc.GetComponent<Transform>();
        mx = myChar.transform.position.x;
        my = myChar.transform.position.y;
        Debug.Log("mx = " + mx);
        Debug.Log("my = " + my);

        x = ex;
        y = ey;
        d = Mathf.Sqrt((mx - ex) * (mx - ex) + (my - ey) * (mx - ey));

        theta = Random.Range(180, 360);

        vx = Mathf.Cos(Mathf.PI / 180 * theta) * speed / 40 * Time.deltaTime;
        vy = Mathf.Sin(Mathf.PI / 180 * theta) * speed / 40 * Time.deltaTime;


        tr = GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update () {
        x += vx;
        y += vy;

        Debug.Log("X = " + x);
        Debug.Log("Y = " + y);
        tr.transform.Translate(x*0.5f, y * 0.5f, 0);

        if (tr.transform.position.y < -6
            || tr.transform.position.x > 4.5
            || tr.transform.position.x < -4.5
            || tr.transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}
