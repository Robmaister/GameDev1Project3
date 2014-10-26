using UnityEngine;
using System.Collections;

public class SelectItem1 : MonoBehaviour {
    ShowItemDetail otherScript;

	// Use this for initialization
	void Start () {
        otherScript = GetComponent<ShowItemDetail>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void onMouseDown() {
        otherScript.setSelectedItem(1);
    }
}
