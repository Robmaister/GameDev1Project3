using UnityEngine;
using System.Collections;

public class TreasureBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ToggleTreasureBoxUI(){
        GameObject.Find("TreasureBoxUIPanel").GetComponent<CanvasGroup>().alpha = 1;
        GameObject.Find("First Person Controller").GetComponent<CharacterMotor>().canControl = false;
        GameObject.Find("TreasureBoxCamera").GetComponent<Camera>().enabled = true;
        GameObject.Find("Main Camera").GetComponent<Camera>().enabled = false;
    }

    public void HideTreasureBoxUI()
    {
        GameObject.Find("TreasureBoxUIPanel").GetComponent<CanvasGroup>().alpha = 0;
        GameObject.Find("First Person Controller").GetComponent<CharacterMotor>().canControl = true;
        GameObject.Find("TreasureBoxCamera").GetComponent<Camera>().enabled = false;
        GameObject.Find("Main Camera").GetComponent<Camera>().enabled = true;
    }
}
