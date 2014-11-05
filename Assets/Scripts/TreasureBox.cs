using UnityEngine;
using System.Collections;

public class TreasureBox : MonoBehaviour {

	//GameObject canvas;
	//GameObject nightPanel;

	// Use this for initialization
	void Start () {
		//nightPanel = GameObject.FindWithTag("WakeUpUIPanel");
		//canvas = GameObject.Find ("Canvas");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void ToggleTreasureBoxUI(){
		//nightPanel.SetActive (false);
		//canvas.SetActive (true);
        GameObject.Find("TreasureBoxUIPanel").GetComponent<CanvasGroup>().alpha = 1;
        GameObject.Find("First Person Controller").GetComponent<CharacterMotor>().canControl = false;
        GameObject.Find("TreasureBoxCamera").GetComponent<Camera>().enabled = true;
        GameObject.Find("Main Camera").GetComponent<Camera>().enabled = false;
    }

    public void HideTreasureBoxUI()
    {
		//canvas.SetActive (false);
        GameObject.Find("TreasureBoxUIPanel").GetComponent<CanvasGroup>().alpha = 0;
        GameObject.Find("First Person Controller").GetComponent<CharacterMotor>().canControl = true;
        GameObject.Find("TreasureBoxCamera").GetComponent<Camera>().enabled = false;
        GameObject.Find("Main Camera").GetComponent<Camera>().enabled = true;
    }
}
