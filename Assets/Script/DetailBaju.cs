using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailBaju : MonoBehaviour
{
    public string title= "", description ="";
    public string sp= null;

    public GameObject Title, desc, img;

    private void Start()
    {
        Title.GetComponent<Text>().text = "";
        desc.GetComponent<Text>().text = "";
        img.GetComponent<Image>().overrideSprite = null;
        
    }

    private void Update()
    {
        Title.GetComponent<Text>().text = title;
        desc.GetComponent<Text>().text = description;
        var sprite = Resources.Load<Sprite>("Images/Materi/Baju/" + sp);
        img.GetComponent<Image>().overrideSprite = sprite;
    }
}
