using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManagement : MonoBehaviour
{
    [SerializeField]
    private Button Level1, Level2, Level3, Level4, Level5;
    private string scores, coins;
    // Start is called before the first frame update
    void Start()
    {
        LoadLevel();
    }

    // Update is called once per frame
    void Update()
    {
        LoadLevel();
    }

    private void LoadLevel()
    {
        if (PlayerPrefs.HasKey("Level1"))
        {
            Load("Level1");
            Level1.transform.GetChild(0).GetComponent<Text>().text = "Level 1 \n" + "Scores : " + scores + "\nCoins : " + coins;
        }
        if (PlayerPrefs.HasKey("Level2"))
        {
            Load("Level2");
            Level2.transform.GetChild(0).GetComponent<Text>().text = "Level 2 \n" + "Scores : " + scores + "\nCoins : " + coins;
        }
        if (PlayerPrefs.HasKey("Level3"))
        {
            Load("Level3");
            Level3.transform.GetChild(0).GetComponent<Text>().text = "Level 3 \n" + "Scores : " + scores + "\nCoins : " + coins;

        }
        if (PlayerPrefs.HasKey("Level4"))
        {
            Load("Level4");
            Level4.transform.GetChild(0).GetComponent<Text>().text = "Level 4 \n" + "Scores : " + scores + "\nCoins : " + coins;

        }
        if (PlayerPrefs.HasKey("Level5"))
        {
            Load("Level5");
            Level5.transform.GetChild(0).GetComponent<Text>().text = "Level 5 \n" + "Scores : " + scores + "\nCoins : " + coins;

        }
    }

    private void Load(string lv)
    {
        scores = PlayerPrefs.GetString("Scores_"+lv);
        coins = PlayerPrefs.GetString("Coins_"+lv);
    }
}
