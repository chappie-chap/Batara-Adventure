using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class RumahList : MonoBehaviour
{
    [Serializable]
    public struct Rumah
    {
        public string Name;
        public Sprite image;
    }

    [SerializeField] Rumah[] AllRumah;

    // Start is called before the first frame update
    void Start()
    {
        GameObject ItemList = transform.GetChild(0).gameObject;
        GameObject item;
        int n = AllRumah.Length;
        for (int i = 0; i < 5; i++)
        {
            item = Instantiate(ItemList, transform);
            item.transform.GetChild(1).GetComponent<Image>().sprite = AllRumah[i].image;
            item.transform.GetChild(2).GetComponent<Text>().text = AllRumah[i].Name ;


        }

        Destroy(ItemList);
    }
}