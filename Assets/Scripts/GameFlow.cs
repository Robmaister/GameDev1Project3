using UnityEngine;
using System.Collections;

public class GameFlow : MonoBehaviour {
    public int day;
    public string time;
	// Use this for initialization
	void Start () {
        day = 1;
        time = "night";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void triggerNextDay(){
        day++;
        time = "day";
    }
}
