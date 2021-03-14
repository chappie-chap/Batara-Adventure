using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetailBaju : MonoBehaviour
{
    public string title, description;
    public Sprite sp;

    public GameObject Title, desc, img;

    private void Start()
    {
        Title.GetComponent<Text>().text = title;
        desc.GetComponent<Text>().text = description;
        img.GetComponent<Image>().sprite = sp;
    }
}
