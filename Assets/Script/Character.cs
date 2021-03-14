using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Character : MonoBehaviour
{

    private Rigidbody2D rb;
    private float moveSpeed, dirX;
    //private bool facingRight = true;
    private Vector3 localScale;
    private GameObject PG,GO,Quest;
    public static bool gameIsPaused;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        localScale = transform.localScale;
        moveSpeed =5f;
        Time.timeScale =1;
    }

    // Update is called once per frame
    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;

            if(CrossPlatformInputManager.GetButtonDown("Jump") && rb.velocity.y == 0)
                rb.AddForce(Vector2.up * 700f);
    }

    private void FixedUpdate(){
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }

    // private void LateUpdate(){
    //     if(dirX > 0){
    //         facingRight = true;
    //     }else{
    //         facingRight = false;
    //     }

    //     if(((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x >0))){
    //         localScale.x *= -1;
    //     }

    //     transform.localScale = localScale;
    // }

    private void OnTriggerEnter2D(Collider2D collision){

        if (collision.gameObject.name == "Quest1")
        {
            collision.gameObject.SetActive(false);
            Debug.Log("Quest1");
            Debug.Log("------------");
            Debug.Log(gameObject.name);
            gameObject.SetActive(false);
            PG = FindInActiveObjectByTag("PopUpGame");
            Quest = FindInActiveObjectByTag("Quest");
            PG.SetActive(true);
            Quest.SetActive(true);

        }
        else if (collision.gameObject.name == "OffsetDown")
        {

            gameObject.SetActive(false);
            PG = FindInActiveObjectByTag("PopUpGame");
            GO = FindInActiveObjectByTag("GameOver");
            Debug.Log("OnTrigger " + GO.name);
            gameIsPaused = !gameIsPaused;
            PG.SetActive(true);
            GO.SetActive(true);
            PauseGame();
        }
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

    void PauseGame(){
        if(gameIsPaused){
            Time.timeScale =0;
        }else{
            Time.timeScale =1;
        }
    }
}
