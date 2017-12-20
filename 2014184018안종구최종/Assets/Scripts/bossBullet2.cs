using UnityEngine;
using System.Collections;

public class bossBullet2 : MonoBehaviour {
    private Transform tr;
    public GameObject myChar;
    private float ex, ey; // 적기의 좌표
    private float x, y; // 탄환의 좌표
    private float vx, vy; // 탄환의 속도 벡터
    private float speed = 8;
    private float theta; // 속도와 각도

    // Use this for initialization
    void Start()
    {
        theta = Random.Range(180, 360);

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

        if (tr.transform.position.y < -6
            || tr.transform.position.x > 4.5
            || tr.transform.position.x < -4.5)
        {
            Destroy(gameObject);
        }
    }

}
