using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TarianList : MonoBehaviour
{
    [Serializable]
    public struct Tarian
    {
        public string Name;
        public Sprite image;
    }

    [SerializeField] Tarian[] AllTarian;

    // Start is called before the first frame update
    void Start()
    {
        GameObject ItemList = transform.GetChild(0).gameObject;
        GameObject item;
        int n = AllTarian.Length;
        for (int i = 0; i < 5; i++)
        {
            item = Instantiate(ItemList, transform);
            item.transform.GetChild(1).GetComponent<Image>().sprite = AllTarian[i].image;
            item.transform.GetChild(2).GetComponent<Text>().text = AllTarian[i].Name;
        }

        Destroy(ItemList);
    }
}