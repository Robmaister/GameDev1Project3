using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemDetailDisplay : MonoBehaviour {
    public Sprite blankSprite;
    public Sprite sprite1;
    public Sprite sprite2;
    public bool[] itemAvailablbility = new bool[13];

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Image>().sprite = blankSprite;
        for (int i = 0; i < 13; i++){
            itemAvailablbility[i] = false;
        }
	}

    // Update is called once per frame
    void Update()
    {
	
	}

    public void setTexture(int number) {
        if (itemAvailablbility[number])
        {
            switch (number)
            {
                case 1:
                    gameObject.GetComponent<Image>().sprite = sprite1;
                    break;
                case 2:
                    gameObject.GetComponent<Image>().sprite = sprite2;
                    break;
                default:
                    gameObject.GetComponent<Image>().sprite = blankSprite;
                    break;
            }
        }
        else {
            gameObject.GetComponent<Image>().sprite = blankSprite;
        }
    }
}
