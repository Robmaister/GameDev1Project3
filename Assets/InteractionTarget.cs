using UnityEngine;
using System.Collections;

public class InteractionTarget : MonoBehaviour {

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

		mr.material.SetColor("_Color", new Color (0f, 1f, 0f));
	}

	void InteractUnlook()
	{
		print ("unlooking");
		isLooking = false;

		MeshRenderer mr = this.gameObject.GetComponent<MeshRenderer> ();
		if (mr == null)
			return;
		
		mr.material.SetColor("_Color", new Color (1f, 0f, 0f));
	}

	void Interact()
	{
		MeshRenderer mr = this.gameObject.GetComponent<MeshRenderer> ();
		if (mr == null)
			return;
		
		mr.material.SetColor("_Color", new Color (0f, 0f, 1f));
	}
}
