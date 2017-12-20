using UnityEngine;
using System.Collections;

public class PetBullet : MonoBehaviour {
    public GameObject bullet;
    private float selfTimer = 0.0f;
    
    // Use this for initialization
    void Start () {
        selfTimer = Time.time + 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if(staticV.pet1 == false)
        {
            GameObject.Find("myChar").transform.FindChild("Pet1").gameObject.SetActive(false);
        }
        else if(staticV.pet1 == true)
        {
            GameObject.Find("myChar").transform.FindChild("Pet1").gameObject.SetActive(true);
        }

        if (selfTimer < Time.time)
        {
            bullet.transform.position = this.transform.position;
            Instantiate<Object>(bullet);
            selfTimer = Time.time + 0.1f;
        }
    }
}
