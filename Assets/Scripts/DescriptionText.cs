using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DescriptionText : MonoBehaviour {
    public int itemSelected;
    string[] description = new string[13];

	// Use this for initialization
	void Start () {
        itemSelected = 0;
        description[1] = "    the monsters must have stolen one of mommy’s rings and threw it around the house";
        description[2] = "    looks like the monsters like to watch tv, but got angry and broke the remote";
        description[3] = "    looks the monsters broke one of daddy’s special drinks";
        description[4] = "    looks like the monsters wanted to hide something. I wonder what this paper means";
        description[5] = "    looks like the monsters are sleeping on the couch when i'm not looking";
        description[6] = "    looks like the monsters destroyed daddy’s flowers for mommy. They must really hate flowers";
        description[7] = "    the monsters must be dumping out all of daddy’s special drinks";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void changeItemSelected(int itemNum) {
        ItemSelection itemSelectionScript = GameObject.Find("CollectiveItemImage" + itemNum.ToString()).GetComponent<ItemSelection>();
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
