using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class bulletManager : MonoBehaviour {
    public Text coinText = null;
    // Use this for initialization
    void Start()
    {
        coinText.text = staticV.bulletCoin.ToString();
    }
    public void bulletUp()
    {
        if (staticV.bulletCoin != 125)
            coinText.text = staticV.bulletCoin.ToString();
        else
            coinText.text = "MAX";
    }
    // Update is called once per frame
    void Update()
    {

    }
}
