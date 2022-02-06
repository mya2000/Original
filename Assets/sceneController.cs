using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneController : MonoBehaviour
{
    bool bl = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && bl == true)
        {
            Invoke("ChangeScene", 0.5f);
            bl = false;
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("GameScene");
    }
}
