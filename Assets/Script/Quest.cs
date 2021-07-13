using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest
{
    public string sprite;
    public string quest;
    public string answerA,answerB,answerC,answerD, key;
    public bool isOpened;

    public Quest(string sprite, string quest, string answerA,string answerB,string answerC,string answerD,string key, bool isOpened)
    {
        this.sprite = sprite;
        this.quest = quest;
        this.answerA = answerA;
        this.answerB = answerB;
        this.answerC = answerC;
        this.answerD = answerD;
        this.key = key;
        this.isOpened = isOpened;
    }

}
