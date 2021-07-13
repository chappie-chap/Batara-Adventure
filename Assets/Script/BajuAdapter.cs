using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class BajuAdapter : MonoBehaviour
{
    private Bajus bajuInJson;
    public GameObject bg, detail, go;
    public TextAsset jsonFile;

    // Start is called before the first frame update
    void Start()
    {
        GameObject ItemList = transform.GetChild(0).gameObject;
        GameObject item, bgImage,title;
        bajuInJson = JsonUtility.FromJson<Bajus>(jsonFile.text);
        int i = 0;
        foreach (Baju itemBaju in bajuInJson.bajus)
        {
            item = Instantiate(ItemList, transform);
            var sprite = Resources.Load<Sprite>("Images/Materi/Baju/"+itemBaju.sprite);
            bgImage = item.transform.GetChild(1).gameObject;
            title = item.transform.GetChild(2).gameObject;
            
            bgImage.transform.GetComponent<Image>().sprite = sprite;
            title.transform.GetComponent<Text>().text = itemBaju.title;
            item.GetComponent<Button>().AddEventListener(i, ItemClicked);
            i++;
        }

        Destroy(ItemList);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ItemClicked(int index)
    {
        bg.SetActive(true);
        detail.SetActive(true);

        DetailBaju db = (DetailBaju)go.GetComponent(typeof(DetailBaju));
        db.title = bajuInJson.bajus[index].title;
        db.description = bajuInJson.bajus[index].description;
        db.sp = bajuInJson.bajus[index].sprite;
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