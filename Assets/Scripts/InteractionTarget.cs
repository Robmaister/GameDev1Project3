using UnityEngine;
using System.Collections;

public enum InteractType { Collectible, TreasureBox, Bed }

public class InteractionTarget : MonoBehaviour {
    public InteractType itemType;

	bool isLooking = false;
	GameFlow flow;
	//GameObject nightPanel;
	//GameObject canvas;

	// Use this for initialization
	void Start () {
		flow = GameObject.Find ("GameFlow").GetComponent<GameFlow>();
		//canvas = GameObject.Find ("Canvas");
		//nightPanel = GameObject.FindWithTag("WakeUpUIPanel");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void InteractLook()
	{
		if (itemType == InteractType.Bed && !flow.bedTransition)
			return;

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
                case InteractType.Bed:
						if (flow.bedTransition)
			{
				//canvas.SetActive(true);
							//nightPanel.SetActive(true);
				flow.SendMessage("TransitionDay");
				InteractUnlook();
			}
                        break;
                default:
						break;
				}
	}
}
