using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiteUpDownControll : MonoBehaviour
{
    public GameObject kite;
    public float moveSpeed = 1;
    Vector3 moveVelo = Vector3.zero;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void upButtonClick(){
        moveVelo = new Vector3(0,-0.1f,0);
        kite.transform.position += moveVelo*moveSpeed;
    }
    public void downButtonClick(){
        moveVelo = new Vector3(0,+0.1f,0);
        kite.transform.position += moveVelo*moveSpeed;

    }
}
