using UnityEngine;
using System.Collections;

public class GameFlow : MonoBehaviour {
    public int day = 0;
	public bool bedTransition = false;

	GameObject[][] days;
	
    void Start () {
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
	}

    // Update is called once per frame
    void Update()
    {
		if (bedTransition)
			return;

		bool allCollected = true;
		foreach (GameObject obj in days[day]) {
			if (obj != null)
			{
				allCollected = false;
				break;
			}
		}

		bedTransition = allCollected;

	}

	void TransitionDay() {
		if (bedTransition) {
			day++;
			bedTransition = false;

			foreach (GameObject obj in days[day])
				obj.SetActive(true);
		}
	}
}
