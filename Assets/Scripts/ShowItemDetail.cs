using UnityEngine;
using System.Collections;

public class ShowItemDetail : MonoBehaviour {
    int itemSelected;

	// Use this for initialization
	void Start () {
        itemSelected = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void setSelectedItem(int itemNum) {
        itemSelected = itemNum;
    }

    int getSelectedItem() {
        return itemSelected;
    }
}
