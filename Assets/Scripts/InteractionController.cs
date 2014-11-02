using UnityEngine;
using System.Collections;

public class InteractionController : MonoBehaviour {

	public float RaycastDistance = 2;

	private GameObject lookAtObj;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//raycast forward and upate the object that is being targeted.
		InteractRaycast ();

		if (Input.GetButtonDown ("Interact") && lookAtObj != null) {
			lookAtObj.SendMessage ("Interact");
			print ("INTERACT");
		}
	}

	void InteractRaycast()
	{
		Vector3 fwd = transform.TransformDirection (Vector3.forward);
		
		//raycast
		RaycastHit hitInfo;
		if (Physics.Raycast (transform.position, fwd, out hitInfo, RaycastDistance)) {
			//get GameObject ray collides with
			GameObject obj = hitInfo.collider.gameObject;
			InteractionTarget objTarget = obj.GetComponent<InteractionTarget>();
			if (objTarget == null) {
				//unlook (old interactable, new isn't)
				if (lookAtObj != null)
				{
					lookAtObj.SendMessage("InteractUnlook");
					lookAtObj = null;
				}
				return;
			}

			//don't do anything if looking at the same object
			if (obj == lookAtObj)
				return;

			//unlook old
			if (lookAtObj != null)
				lookAtObj.SendMessage("InteractUnlook");
			
			obj.SendMessage("InteractLook");
			lookAtObj = obj;
		}
		else if (lookAtObj != null) {
			lookAtObj.SendMessage("InteractUnlook");
			lookAtObj = null;
		}
	}
}
