using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    
    private string scene;
    private GameObject PG,PEG;
    private string PopUpGame = "PopUpGame", PopExitGame = "PopExitGame";

    public void SetScene(string scene){
        this.scene = scene;
    }

    public string GetScene(){
        return scene;
    }

    void Start(){

    }
    void Update(){
        if(Input.GetKey(KeyCode.Escape)){
            //SceneManager.LoadScene(GetScene());
            Debug.Log("Pressed");
            if(SceneManager.GetActiveScene().name == "Play Game"){
                PG = FindInActiveObjectByTag(PopUpGame);
                PEG = FindInActiveObjectByTag(PopExitGame);
                PG.SetActive(true);
                PEG.SetActive(true);
            }
        }
    }

    public void exit(){
        Application.Quit();
    }

    public void switchScene(){
        SceneManager.LoadScene(GetScene());
    }

    GameObject FindInActiveObjectByTag(string tag){

        Transform[] objs = Resources.FindObjectsOfTypeAll<Transform>() as Transform[];
        for (int i = 0; i < objs.Length; i++)
        {
            if (objs[i].hideFlags == HideFlags.None)
            {
                if (objs[i].CompareTag(tag))
                {
                    return objs[i].gameObject;
                }
            }
        }
        return null;
    }
}
