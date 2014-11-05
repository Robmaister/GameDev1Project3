using UnityEngine;
using System.Collections;

public class GameFlow : MonoBehaviour {
    public int day = 0;
	public bool bedTransition = false;

	GameObject[][] days;
	
	GameObject nightPanel;
	//GameObject canvas;
	
	// Use this for initialization
	void Start () {
		nightPanel = GameObject.FindWithTag("WakeUpUIPanel");
		nightPanel.SetActive (false);
		//canvas = GameObject.Find ("Canvas");
		days = new GameObject[4][];
		days[0] = GameObject.FindGameObjectsWithTag ("CollectibleDay1");
		days[1] = GameObject.FindGameObjectsWithTag ("CollectibleDay2");
		days[2] = GameObject.FindGameObjectsWithTag ("CollectibleDay3");
		days[3] = GameObject.FindGameObjectsWithTag ("CollectibleDay4");

		foreach (GameObject obj in days[1])
			obj.SetActive (false);
		foreach (GameObject obj in days[2])
			obj.SetActive (false);
		foreach (GameObject obj in days[3])
			obj.SetActive (false);

		//canvas.SetActive (false);

	}

    // Update is called once per frame
    void Update()
    {
		if (bedTransition) {
			return;
			//TransitionDay();
		}

		if (day == 4) {
			nightPanel.SetActive(true);
			return;
				}

		bool allCollected = true;
		foreach (GameObject obj in days[day]) {
			if (!(obj == null))
			{
				allCollected = false;
				break;
			}
		}

		bedTransition = allCollected;

	}

	void TransitionDay() {
		if (bedTransition) {
			//nightPanel.SetActive(false);
			//canvas.SetActive(false);
			day++;
			bedTransition = false;

			if (day == 4)
				return;

			foreach (GameObject obj in days[day])
				obj.SetActive(true);
		}
	}
}
