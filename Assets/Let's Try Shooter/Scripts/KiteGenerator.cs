using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KiteGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject kite;
    public GameObject kiteLine;
    
    public void onClickKiteEvent(){
        if(kite.activeSelf==true){
            kite.SetActive(false);
            kiteLine.SetActive(false);
        }
        else{
            kite.SetActive(true);
            kiteLine.SetActive(true);
        }
    }

  
}
