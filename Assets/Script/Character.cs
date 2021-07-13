using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{

    private Rigidbody2D rb;
    private Animator anim;
    private float moveSpeed, dirX;
    private bool facingRight = true, isImage;
    private Vector3 localScale;
    private List<Quest> questList = new List<Quest>();
    [SerializeField]
    private GameObject PG,GO,Quest,withImage, imgQuest, msg1,msg2, noImage, btnA, btnB, btnC, btnD, textCoin, textQuest, spawn, heart1,heart2,heart3, titleGO,winGO,btnGO,btnNext;
    private int numbQuest, tempScoreQuest=0, tempCoin = 0, heartCount = 3;
    private Level level;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        localScale = transform.localScale;
        moveSpeed =5f;
        var sceneName = SceneManager.GetActiveScene().name;
        if(sceneName == "Level1")
        {
            level = new Level();
            questList = level.questLevel1();
        }else if(sceneName == "Level2")
        {
            level = new Level();
            questList = level.questLevel2();
        }else if(sceneName == "Level3")
        {
            level = new Level();
            questList = level.questLevel3();
        }else if(sceneName == "Level4")
        {
            level = new Level();
            questList = level.questLevel4();
        }
        else if(sceneName == "Level5")
        {
            level = new Level();
            questList = level.questLevel5();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;

        if(CrossPlatformInputManager.GetButtonDown("Jump") && rb.velocity.y == 0)
           rb.AddForce(Vector2.up * 700f);

        if (Mathf.Abs(dirX) > 0 && rb.velocity.y == 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if(rb.velocity.y == 0)
        {
            anim.SetBool("isJumping", false);
            anim.SetBool("isFalling", false);
        }

        if (rb.velocity.y > 0)
        {
            anim.SetBool("isJumping", true);
        }
        if (rb.velocity.y < 0)
        {
            anim.SetBool("isJumping", false);
            anim.SetBool("isFalling", true);
        }

    }

    private void FixedUpdate(){
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }

    private void LateUpdate(){
        if (dirX > 0)
        {
            facingRight = true;
        }
        else if (dirX<0)
        {
            facingRight = false;
        }

        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
        {
            localScale.x *= -1;
        }

        transform.localScale = localScale;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Platform")
        {
            this.gameObject.transform.parent = collision.gameObject.transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Platform"))
        {
            this.transform.parent = null;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        string name = collision.gameObject.name;
        switch (name)
        {
            case "Treasure 1":
                Question(collision, questList[0].sprite != null, questList[0]);
                numbQuest = 0; 
                break;
            case "Treasure 2":
                Question(collision, questList[1].sprite != null, questList[1]);
                numbQuest = 1;
                break;
            case "Treasure 3":
                Question(collision, questList[2].sprite != null, questList[2]);
                numbQuest = 2;
                break;
            case "Treasure 4":
                Question(collision, questList[3].sprite != null, questList[3]);
                numbQuest = 3;
                break;
            case "Treasure 5":
                Question(collision, questList[4].sprite != null, questList[4]);
                numbQuest = 4;
                break;
            case "Treasure 6":
                Question(collision, questList[5].sprite != null, questList[5]);
                numbQuest = 5;
                break;
            case "Treasure 7":
                Question(collision, questList[6].sprite != null, questList[6]);
                numbQuest = 6;
                break;
            case "Treasure 8":
                Question(collision, questList[7].sprite != null, questList[7]);
                numbQuest = 7;
                break;
            case "Treasure 9":
                Question(collision, questList[8].sprite != null, questList[8]);
                numbQuest = 8;
                break;
            case "Treasure 10":
                Question(collision, questList[9].sprite != null, questList[9]);
                numbQuest = 9;
                break;
            case "Water":
                if(heartCount == 3)
                {
                    gameObject.transform.position = spawn.transform.position;
                    heart3.SetActive(false);
                    heartCount--;
                }else if(heartCount == 2)
                {
                    gameObject.transform.position = spawn.transform.position;
                    heart2.SetActive(false);
                    heartCount--;
                }
                else
                {
                    this.gameObject.SetActive(false);
                    PG.SetActive(true);
                    GO.SetActive(true);
                    titleGO.GetComponent<Text>().text = "Game Over";
                    winGO.SetActive(true);
                    winGO.transform.GetChild(1).GetComponent<Text>().text = tempCoin.ToString();
                    winGO.transform.GetChild(3).GetComponent<Text>().text = tempScoreQuest.ToString();
                    btnGO.SetActive(true);
                    btnNext.SetActive(false);
                    Save(SceneManager.GetActiveScene().name);
                }
                break;
            default:
                collision.gameObject.SetActive(false);
                tempCoin += 2;
                textCoin.GetComponent<Text>().text = tempCoin.ToString();
                break;
        }
    }
	
    private void Question(Collider2D collision, bool isImage, Quest quests)
    {
        collision.gameObject.SetActive(false);
		//gameObject.SetActive(false);
        PG.SetActive(true);
        Quest.SetActive(true);
        if (isImage)
        {
            noImage.SetActive(false);
            withImage.SetActive(true);
            imgQuest.GetComponent<Image>().sprite = null;
            msg1.GetComponent<TextMeshProUGUI>().text = null;
            imgQuest.GetComponent<Image>().sprite = Resources.Load<Sprite>("Images/Materi" + quests.sprite);
            msg1.GetComponent<TextMeshProUGUI>().text = quests.quest;
        }
        else
        {
            withImage.SetActive(false);
            noImage.SetActive(true);
            msg2.GetComponent<TextMeshProUGUI>().text = null;
            msg2.GetComponent<TextMeshProUGUI>().text = quests.quest;
        }
        btnA.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = null;
        btnB.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = null;
        btnC.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = null;
        btnD.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = null;
        btnA.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = quests.answerA;
        btnB.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = quests.answerB;
        btnC.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = quests.answerC;
        btnD.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = quests.answerD;
    }

    public void CheckQuest(GameObject gObject)
    {
        if(gObject.name == questList[numbQuest].key.Trim())
        {
            tempScoreQuest += 10;
            textQuest.GetComponent<Text>().text = tempScoreQuest.ToString();
            if(numbQuest == 9 && tempScoreQuest == 100)
            {
                this.gameObject.SetActive(false);
                PG.SetActive(true);
                GO.SetActive(true);
                titleGO.GetComponent<Text>().text = "Horee! Menang";
                winGO.SetActive(true);
                winGO.transform.GetChild(1).GetComponent<Text>().text = tempCoin.ToString();
                winGO.transform.GetChild(3).GetComponent<Text>().text = tempScoreQuest.ToString();
                btnGO.SetActive(false);
                btnNext.SetActive(true);
                Save(SceneManager.GetActiveScene().name);

            }
            else if(numbQuest == 9 && tempScoreQuest != 100)
            {

                this.gameObject.SetActive(false);
                PG.SetActive(true);
                GO.SetActive(true);
                titleGO.GetComponent<Text>().text = "Game Over";
                winGO.transform.GetChild(1).GetComponent<Text>().text = tempCoin.ToString();
                winGO.transform.GetChild(3).GetComponent<Text>().text = tempScoreQuest.ToString();
                btnGO.SetActive(true);
                winGO.SetActive(false);
                btnNext.SetActive(false);
                Save(SceneManager.GetActiveScene().name);
            }
        }
        //this.gameObject.SetActive(true);
        
    }

    private void Save(string lv)
    {
        PlayerPrefs.SetString(lv, lv);
        PlayerPrefs.SetString("Scores_" + lv, tempScoreQuest.ToString());
        PlayerPrefs.SetString("Coins_" + lv, tempCoin.ToString());
    }

}
