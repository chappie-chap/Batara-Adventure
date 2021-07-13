using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TarianAdapter : MonoBehaviour
{
    private Tarians tarianInJson;
    public TextAsset jsonFile;

    // Start is called before the first frame update
    void Start()
    {
        GameObject ItemList = transform.GetChild(0).gameObject;
        GameObject item, bgImage, title;
        tarianInJson = JsonUtility.FromJson<Tarians>(jsonFile.text);
        int i = 0;
        foreach (Tarian itemTarian in tarianInJson.tarians)
        {
            item = Instantiate(ItemList, transform);
            var sprite = Resources.Load<Sprite>("Images/Materi/Tarian/" + itemTarian.sprite);
            bgImage = item.transform.GetChild(1).gameObject;
            title = item.transform.GetChild(2).gameObject;

            bgImage.transform.GetComponent<Image>().sprite = sprite;
            title.transform.GetComponent<Text>().text = itemTarian.title;
            i++;
        }

        Destroy(ItemList);
    }
}