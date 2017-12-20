using UnityEngine;
using System.Collections;

public class lottoScript : MonoBehaviour {
    public Sprite[] btn;
    SpriteRenderer sr;
    private Vector2 pos;
    RaycastHit2D hit;
    private GameObject lottobtn;
    private uiManager um = null;
    private int randCoin;

    // Use this for initialization
    void Start()
    {
        um = GameObject.Find("TextUI").GetComponent<uiManager>();
        sr = GetComponent<SpriteRenderer>();
        lottobtn = GameObject.Find("lotto");
    }

    // Update is called once per frame
    void Update()
    {
        randCoin = Random.Range(-15, 30);
        pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hit = Physics2D.Raycast(pos, Vector2.zero, 0f);
        if (hit.collider != null)
        {
            if (hit.collider.gameObject == lottobtn)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    sr.sprite = btn[0];
                }

                if (Input.GetMouseButtonUp(0))
                {
                    sr.sprite = btn[1];
                    if (staticV.coin >= 10)
                    {
                        um.coinUp(-10);
                        um.coinUp(randCoin);
  
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
