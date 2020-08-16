using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject settingmenu;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onStartButtonClick(){
        SceneManager.LoadScene(1);
    }
    public void onSettingButtonClick(){
        settingmenu.gameObject.SetActive(true);
    }
    public void onCreditsButtonClick(){
        SceneManager.LoadScene(2);
    }
    public void onNewGameButtonClick(){
        SceneManager.LoadScene(0);
    }
}
