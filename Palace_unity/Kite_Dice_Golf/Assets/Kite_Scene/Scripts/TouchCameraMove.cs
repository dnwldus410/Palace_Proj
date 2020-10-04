using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchCameraMove : MonoBehaviour
{
public float moveSpeed;
public Transform cam;

Vector2 prevPos = Vector2.zero;
float prevDistance = 0f;


    // Start is called before the first frame update
    void Start()
    {
        cam=Camera.main.transform;
    }

    public void onDrag(){
        int touchCount = Input.touchCount;
        if(touchCount==1){
            if(prevPos==Vector2.zero){
                prevPos=Input.GetTouch(0).position;
                return;
            }
        Vector2 dir = (Input.GetTouch(0).position - prevPos).normalized;
        Vector3 vec = new Vector3(dir.x,0,dir.y);

        cam.position -= vec*moveSpeed*Time.deltaTime;
        prevPos = Input.GetTouch(0).position;
        }
    }
    public void ExitDrag(){
        prevPos = Vector2.zero;
        prevDistance = 0f;
    }
}
