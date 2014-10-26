using UnityEngine;
using System.Collections;

public class SelectItem2 : MonoBehaviour {
    ShowItemDetail otherScript;

	// Use this for initialization
	void Start () {
        otherScript = GetComponent<ShowItemDetail>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void onMouseDown()
    {
        otherScript.setSelectedItem(2);
    }
}
