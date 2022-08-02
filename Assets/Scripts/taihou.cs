using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class taihou : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(new Vector3(0, 0, 1));
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(new Vector3(0, 0, -1));
        }

        }
    }
