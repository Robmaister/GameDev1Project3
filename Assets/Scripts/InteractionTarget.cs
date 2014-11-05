using UnityEngine;
using System.Collections;

public enum InteractType { Collectible, TreasureBox, DescriptiveText }

public class InteractionTarget : MonoBehaviour {
    public InteractType itemType;

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
		//print ("looking");
		isLooking = true;
		MeshRenderer mr = this.gameObject.GetComponent<MeshRenderer> ();
		if (mr == null)
			return;

		mr.material.SetFloat("_IsHover", 1);
		mr.material.SetFloat ("_HoverStartTime", Time.time);
	}

	void InteractUnlook()
	{
		//print ("unlooking");
		isLooking = false;

		MeshRenderer mr = this.gameObject.GetComponent<MeshRenderer> ();
		if (mr == null)
			return;
		
		mr.material.SetFloat("_IsHover", 0);
	}

	void Interact()
	{
		switch (itemType) {
				case InteractType.TreasureBox:
						TreasureBox treasureBoxScript = gameObject.GetComponent<TreasureBox> ();
						treasureBoxScript.ToggleTreasureBoxUI ();
						break;
				case InteractType.Collectible:
						CollectibleItem collectibleItemScript = gameObject.GetComponent<CollectibleItem> ();
						collectibleItemScript.collect ();
						break;
				default:
						break;
				}
	}
}
