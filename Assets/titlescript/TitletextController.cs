using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitletextController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //�X�y�[�X�L�[�������ꂽ�Ƃ��j������
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }
}
