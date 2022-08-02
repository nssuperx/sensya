using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensya1 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        { //矢印キーの上のボタンを押したら
            this.transform.localPosition += transform.forward * 0.5f; //前に動く
        }
        if (Input.GetKey(KeyCode.DownArrow))
        { //矢印キーの下のボタンを押したら
            this.transform.localPosition += transform.forward * -0.5f; //後に動く
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        { //矢印キーの左のボタンを押したら
            this.transform.Rotate(new Vector3(0, -1, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        { //矢印キーの右のボタンを押したら
            this.transform.Rotate(new Vector3(0, 1, 0));

        }
    }
}
