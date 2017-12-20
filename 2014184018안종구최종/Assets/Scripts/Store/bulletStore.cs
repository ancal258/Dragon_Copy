using UnityEngine;
using System.Collections;

public class bulletStore : MonoBehaviour {
    public Sprite[] btn;
    SpriteRenderer sr;
    private Vector2 pos;
    RaycastHit2D hit;
    private GameObject bulletbtn;
    private uiManager um = null;
    private bulletManager bm = null;
    // Use this for initialization
    void Start () {
        um = GameObject.Find("TextUI").GetComponent<uiManager>();
        bm = GameObject.Find("bulletUI").GetComponent<bulletManager>();

        sr = GetComponent<SpriteRenderer>();
        bulletbtn = GameObject.Find("bulletUp");
    }

    // Update is called once per frame
    void Update () {
        pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hit = Physics2D.Raycast(pos, Vector2.zero, 0f);
        if (hit.collider != null)
        {
            if (hit.collider.gameObject == bulletbtn)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    sr.sprite = btn[0];
                }

                if (Input.GetMouseButtonUp(0))
                {
                        sr.sprite = btn[1];
                    if (staticV.bulletCount < 3)
                    {
                        if (staticV.bulletCount == 0)
                        {
                            if (staticV.coin >= staticV.bulletCoin)
                            {
                                um.coinUp(-staticV.bulletCoin);
                                staticV.bulletCoin = 75;
                                bm.bulletUp();
                                staticV.bulletCount += 1;
                            }
                        }
                        if (staticV.bulletCount == 1)
                        {
                            if (staticV.coin >= staticV.bulletCoin)
                            {
                                um.coinUp(-staticV.bulletCoin);
                                staticV.bulletCoin = 100;
                                bm.bulletUp();
                                staticV.bulletCount += 1;
                            }
                        }
                        if (staticV.bulletCount == 2)
                        {
                            if (staticV.coin >= staticV.bulletCoin)
                            {
                                um.coinUp(-staticV.bulletCoin);
                                staticV.bulletCoin = 125;
                                bm.bulletUp();
                                staticV.bulletCount += 1;
                            }
                        }
                    }
                }


            }
        }
        else
        {
            sr.sprite = btn[1];
        }
    }
}
