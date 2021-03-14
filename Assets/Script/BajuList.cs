using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BajuList : MonoBehaviour
{
    [Serializable]
    public struct Baju
    {
        public string Name;
        public Sprite image;
        public string description;
    }

    [SerializeField] Baju[] AllBaju;
    public GameObject bg, detail, go;

    // Start is called before the first frame update
    void Start()
    {
        GameObject ItemList = transform.GetChild(0).gameObject;
        GameObject item;
        int n = AllBaju.Length;
       for(int i=0; i<5; i++)
        {
            item = Instantiate(ItemList, transform);
            item.transform.GetChild(1).GetComponent<Image>().sprite = AllBaju[i].image;
            item.transform.GetChild(2).GetComponent<Text>().text = AllBaju[i].Name;
            item.GetComponent<Button> ().AddEventListener(i, ItemClicked);
        }

        Destroy(ItemList);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ItemClicked(int index)
    {
        Debug.Log("Item " + index + " Clicked");
        Debug.Log("Item " + AllBaju[index].Name + " Clicked");
        bg.SetActive(true);
        detail.SetActive(true);

        DetailBaju db = (DetailBaju)go.GetComponent(typeof(DetailBaju));
        db.title = AllBaju[index].Name;
        db.description = AllBaju[index].description;
        db.sp = AllBaju[index].image;
    }
}

public static class ButtonExtension
{
    public static void AddEventListener<T>(this Button button, T param, Action<T> OnClick)
    {
        button.onClick.AddListener(delegate ()
        {
            OnClick(param);
        });
    }
}