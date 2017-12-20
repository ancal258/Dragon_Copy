using UnityEngine;
using System.Collections;

public class startScript : MonoBehaviour {
    public Sprite[] btn;
    SpriteRenderer sr;
    private Vector2 pos;
    RaycastHit2D hit;
    private GameObject startbtn;
    // Use this for initialization
    void Start () {
        sr = GetComponent<SpriteRenderer>();
        startbtn = GameObject.Find("startButton");
	}

	
	// Update is called once per frame
	void Update () {


        pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        hit = Physics2D.Raycast(pos, Vector2.zero, 0f);
        if(hit.collider != null)
        {
            if (hit.collider.gameObject==startbtn)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    sr.sprite = btn[0];
                }


                if (Input.GetMouseButtonUp(0))
                {
                    if(staticV.stageCheck == 0)
                        Application.LoadLevel("Stage1");
                    else if(staticV.stageCheck == 1)
                        Application.LoadLevel("Stage2");
                    else if(staticV.stageCheck == 2)
                        Application.LoadLevel("Stage3");

                }
            }
        }
        else
        {
            sr.sprite = btn[1];
        }

    }
}
