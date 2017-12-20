using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;


public class uiManager : MonoBehaviour {
    public int nowCoin = 0;
    public Text coinText = null;
    // Use this for initialization
    void Start () {
        coinText.text = staticV.coin.ToString();
	}
	public void coinUp(int co)
    {
        staticV.coin += co;
        if (staticV.coin < 0)
            staticV.coin = 0;
        coinText.text = staticV.coin.ToString();
    }
	// Update is called once per frame
	void Update () {
	
	}
}
