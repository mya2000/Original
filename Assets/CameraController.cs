using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    //Playerのオブジェクト
    private GameObject player;
    //Playerとカメラの距離
    private float difference;
    public float limit;

    // Use this for initialization
    void Start()
    {
        //Playerのオブジェクトを取得
        this.player = GameObject.Find("player");
        //Playerとカメラの位置（x座標）の差を求める
        this.difference = player.transform.position.x - this.transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Mathf.Abs(difference) > limit)
        {
            //Playerの位置に合わせてカメラの位置を移動
            this.transform.position = new Vector3(this.player.transform.position.x - difference*0.995f,
                this.transform.position.y, -10);
        }
        this.difference = player.transform.position.x - this.transform.position.x;
    }
}
