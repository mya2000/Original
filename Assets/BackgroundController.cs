using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    private GameObject camera;
    // Start is called before the first frame update
    void Start()
    {
        this.camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "background") 
        { 
            this.transform.position = new Vector3(camera.transform.position.x, 0, 0); 
        }
        if (this.gameObject.tag == "middleground")
        {
            this.transform.position = new Vector3(camera.transform.position.x * 0.75f, 0, 0);
        }
    }
}
