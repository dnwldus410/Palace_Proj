using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiteLineGenerator : MonoBehaviour
{
    LineRenderer lr;
    Vector3 cube1Pos, cube2Pos;
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        lr.startWidth = .05f;
        lr.endWidth = .05f;
 
        cube1Pos = gameObject.GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, GameObject.Find("KiteStart").GetComponent<Transform>().position);
        lr.SetPosition(1, GameObject.Find("KITE").GetComponent<Transform>().position);

    }
}
