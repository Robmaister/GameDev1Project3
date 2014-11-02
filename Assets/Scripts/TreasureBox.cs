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
    }

    public void HideTreasureBoxUI()
    {
        GameObject.Find("TreasureBoxUIPanel").GetComponent<CanvasGroup>().alpha = 0;
    }
}
