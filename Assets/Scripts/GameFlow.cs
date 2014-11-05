using UnityEngine;
using System.Collections;

public class GameFlow : MonoBehaviour {
    public int day;
    public bool[] collectibleStatus = new bool[8];
	// Use this for initialization
	
    void Start () {
        day = 1;
        for (int i = 1; i < 8; i++) {
            collectibleStatus[i] = false;
        }
	}

    // Update is called once per frame
    void Update()
    {
	
	}

    public void setCollect(int itemNum) {
        collectibleStatus[itemNum] = true;
    }

    public void triggerNight(){

        GameObject.Find("First Person Controller").GetComponent<CharacterMotor>().canControl = false;        
    }

    void triggerAnotherDay(){
        day++;
        GameObject.Find("First Person Controller").GetComponent<CharacterMotor>().canControl = true;
    }
}
