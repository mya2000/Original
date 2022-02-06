using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBarController : MonoBehaviour
{
    public GameObject HpbarPrefab;

    public Canvas Canvas;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            GameObject Hpbar = Instantiate(HpbarPrefab,this.transform.position,
            Quaternion.identity);
            Hpbar.transform.SetParent(this.transform);

            Hpbar.transform.SetParent(this.Canvas.transform, false);
            Hpbar.transform.localScale = new Vector3(0.3f, 0.18f, 1);

            Hpbar.transform.position = new Vector3(-895 + (i*15), 500, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
