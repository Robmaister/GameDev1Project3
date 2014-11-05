using UnityEngine;
using System.Collections;

public class CollectibleItem : MonoBehaviour {
    public int itemNumber;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void collect() {
		Destroy(gameObject);
        GameObject.Find("CollectiveItemImage"+itemNumber.ToString()).GetComponent<ItemSelection>().collect();
    }
}
