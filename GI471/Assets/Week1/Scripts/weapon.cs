﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weapon : MonoBehaviour
{
    public Text myText;
    public Image imagePrefab;
    public List<string> itemList = new List<string>();
    public List<Sprite> images = new List<Sprite>();
    public Sprite shield;
    public Sprite sword;
    public Sprite wand;
    public Sprite axe;
    public Sprite archer;

    // Start is called before the first frame update
    void Start()
    {
        images.Add(shield);
        images.Add(sword);
        images.Add(wand);
        images.Add(axe);
        images.Add(archer);

        itemList.Add("shield");
        itemList.Add("word");
        itemList.Add("wand");
        itemList.Add("axe");
        itemList.Add("archer");
        myText.text = itemList[0] + "\n" + itemList[1] + "\n" + itemList[2] + "\n" + itemList[3] + "\n" + itemList[4];

    }

    // Update is called once per frame
    void Update()
    {
      

        if (Input.GetKeyDown(KeyCode.Return))
        {
            imagePrefab.GetComponent<Image>().sprite = images[0];
           
            itemList.RemoveAt(0);
            images.RemoveAt(0);
            itemList.Add("");

        }
        foreach (string str in itemList)
        {
            myText.GetComponent<Text>().text = itemList[0] + "\n" + itemList[1] + "\n" + itemList[2] + "\n" + itemList[3] + "\n" + itemList[4];

        }
    }



}
