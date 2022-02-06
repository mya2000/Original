using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    //Player�̃I�u�W�F�N�g
    private GameObject player;
    //Player�ƃJ�����̋���
    private float difference;
    public float limit;

    // Use this for initialization
    void Start()
    {
        //Player�̃I�u�W�F�N�g���擾
        this.player = GameObject.Find("player");
        //Player�ƃJ�����̈ʒu�ix���W�j�̍������߂�
        this.difference = player.transform.position.x - this.transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Mathf.Abs(difference) > limit)
        {
            //Player�̈ʒu�ɍ��킹�ăJ�����̈ʒu���ړ�
            this.transform.position = new Vector3(this.player.transform.position.x - difference*0.995f,
                this.transform.position.y, -10);
        }
        this.difference = player.transform.position.x - this.transform.position.x;
    }
}
