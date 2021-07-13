using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class RumahAdapter : MonoBehaviour
{
    private Rumahs rumahInJson;
    public TextAsset jsonFile;

    // Start is called before the first frame update
    void Start()
    {
        GameObject ItemList = transform.GetChild(0).gameObject;
        GameObject item, bgImage, title;
        rumahInJson = JsonUtility.FromJson<Rumahs>(jsonFile.text);
        int i = 0;
        foreach (Rumah itemRumah in rumahInJson.rumahs)
        {
            item = Instantiate(ItemList, transform);
            var sprite = Resources.Load<Sprite>("Images/Materi/Rumah/" + itemRumah.sprite);
            bgImage = item.transform.GetChild(1).gameObject;
            title = item.transform.GetChild(2).gameObject;

            bgImage.transform.GetComponent<Image>().sprite = sprite;
            title.transform.GetComponent<Text>().text = itemRumah.title;
            i++;
        }

        Destroy(ItemList);
    }
}