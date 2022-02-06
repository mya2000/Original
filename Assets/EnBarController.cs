using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnBarController : MonoBehaviour
{
    public GameObject EnbarPrefab;

    public Canvas Canvas;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 50; i++)
        {
            GameObject Enbar = Instantiate(EnbarPrefab);

            Enbar.transform.SetParent(this.Canvas.transform, false);

            Enbar.transform.position = new Vector3(-895 + (i * 15), 450, 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
