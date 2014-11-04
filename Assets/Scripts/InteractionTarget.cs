using UnityEngine;
using System.Collections;

public class InteractionTarget : MonoBehaviour {
    // 0 for treasurebox, 1 for collective item, 2 for text descriptive item
    public int itemType;

	bool isLooking = false;

	// Use this for initialization
	//TODO grab renderer and swap shader with one that glows.
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void InteractLook()
	{
		print ("looking");
		isLooking = true;
		MeshRenderer mr = this.gameObject.GetComponent<MeshRenderer> ();
		if (mr == null)
			return;

		mr.material.SetFloat("_IsHover", 1);
		mr.material.SetFloat ("_HoverStartTime", Time.time);
	}

	void InteractUnlook()
	{
		print ("unlooking");
		isLooking = false;

		MeshRenderer mr = this.gameObject.GetComponent<MeshRenderer> ();
		if (mr == null)
			return;
		
		mr.material.SetFloat("_IsHover", 0);
	}

	void Interact()
	{
		MeshRenderer mr = this.gameObject.GetComponent<MeshRenderer> ();
		if (mr == null)
			return;
		
		mr.material.SetColor("_Color", new Color (0f, 0f, 1f));

        if (itemType == 0) {
            TreasureBox treasureBoxScript = gameObject.GetComponent<TreasureBox>();
            treasureBoxScript.ToggleTreasureBoxUI();
        }
        else if (itemType == 1)
        {
            CollectibleItem collectibleItemScript = gameObject.GetComponent<CollectibleItem>();
            collectibleItemScript.collect();
        }
        else if (itemType == 2)
        {

        }
	}
}
