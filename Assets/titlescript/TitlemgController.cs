using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlemgController : MonoBehaviour
{
    // �X�N���[�����x
    private float scrollSpeed = 1;
    // �w�i�I���ʒu
    private float deadLine = 19.3f;
    // �w�i�J�n�ʒu
    private float startLine = -19.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �w�i���ړ�����
        transform.Translate(0, this.scrollSpeed * Time.deltaTime, 0);

        // ��ʊO�ɏo����A��ʉ��[�Ɉړ�����
        if (transform.position.y > this.deadLine)
        {
            transform.position = new Vector2(0, this.startLine);
        }
        //�X�y�[�X�L�[�������ꂽ�Ƃ��j������
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}
