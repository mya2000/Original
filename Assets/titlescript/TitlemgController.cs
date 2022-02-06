using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlemgController : MonoBehaviour
{
    // スクロール速度
    private float scrollSpeed = 1;
    // 背景終了位置
    private float deadLine = 19.3f;
    // 背景開始位置
    private float startLine = -19.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 背景を移動する
        transform.Translate(0, this.scrollSpeed * Time.deltaTime, 0);

        // 画面外に出たら、画面下端に移動する
        if (transform.position.y > this.deadLine)
        {
            transform.position = new Vector2(0, this.startLine);
        }
        //スペースキーが押されたとき破棄する
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}
