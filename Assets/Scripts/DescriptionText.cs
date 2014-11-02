using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DescriptionText : MonoBehaviour {
    public int itemSelected;
    string[] description = new string[13];

	// Use this for initialization
	void Start () {
        itemSelected = 0;
        description[1] = "This item 1";
        description[2] = "This item 2";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void changeItemSelected(int itemNum) {
        ItemSelection itemSelectionScript = GameObject.Find("Item"+itemNum.ToString()).GetComponent<ItemSelection>();
        if (itemSelectionScript.available)
        {
            gameObject.GetComponent<Text>().text = description[itemNum];
        }
        else
        {
            gameObject.GetComponent<Text>().text = description[0];
        }
    }
}
