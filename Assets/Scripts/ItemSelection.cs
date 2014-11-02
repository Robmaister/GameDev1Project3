﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemSelection : MonoBehaviour {
    CloserLookButton closerLookButtonScript;
    ItemDetailDisplay itemDetailDisplayScript;
    DescriptionText descriptionTextScript;

    public int itemNumber;
    public bool available;
    public Sprite blankSprite;
    public Sprite itemSprite;

	// Use this for initialization
	void Start () {
        available = false;
        gameObject.GetComponent<Image>().sprite = blankSprite;
        closerLookButtonScript = GameObject.Find("Button").GetComponent<CloserLookButton>();
        itemDetailDisplayScript = GameObject.Find("SelectedImage").GetComponent<ItemDetailDisplay>();
        descriptionTextScript = GameObject.Find("DescriptionText").GetComponent<DescriptionText>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    public void collect() {
        available = true;
        gameObject.GetComponent<Image>().sprite = itemSprite;
        itemDetailDisplayScript.itemAvailablbility[itemNumber] = true;
    }
}