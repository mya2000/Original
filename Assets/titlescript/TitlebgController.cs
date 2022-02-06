using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitlebgController : MonoBehaviour
{
    // �X�N���[�����x
    private float scrollSpeed = -0.3f;
    // �w�i�I���ʒu
    private float deadLine = -38;
    // �w�i�J�n�ʒu
    private float startLine = 38;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �w�i���ړ�����
        transform.Translate(this.scrollSpeed * Time.deltaTime, 0, 0);

        // ��ʊO�ɏo����A��ʉE�[�Ɉړ�����
        if (transform.position.x < this.deadLine)
        {
            transform.position = new Vector2(this.startLine, 0);
        }
        //�X�y�[�X�L�[�������ꂽ�Ƃ��j������
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            Destroy(gameObject);
        }
    }
}
