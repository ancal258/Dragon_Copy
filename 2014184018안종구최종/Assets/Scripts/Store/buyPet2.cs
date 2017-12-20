using UnityEngine;
using System.Collections;

public class buyPet2 : MonoBehaviour {
    public Sprite[] btn;
    SpriteRenderer sr;
    private Vector2 pos;
    RaycastHit2D hit;
    private GameObject pet2btn;
    private uiManager um = null;

    // Use this for initialization
    void Start()
    {
        um = GameObject.Find("TextUI").GetComponent<uiManager>();
        sr = GetComponent<SpriteRenderer>();
        pet2btn = GameObject.Find("redBaby");
    }

    // Update is called once per frame
    void Update()
    {
        pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hit = Physics2D.Raycast(pos, Vector2.zero, 0f);
        if (hit.collider != null)
        {
            if (hit.collider.gameObject == pet2btn)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    sr.sprite = btn[0];
                }

                if (Input.GetMouseButtonUp(0))
                {
                    sr.sprite = btn[1];
                    if (staticV.coin >= 100)
                    {
                        um.coinUp(-100);
                        staticV.pet2 = true;
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
