using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ItemDetailDisplay : MonoBehaviour {
    public Sprite blankSprite;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
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
                case 3:
                    gameObject.GetComponent<Image>().sprite = sprite3;
                    break;
                case 4:
                    gameObject.GetComponent<Image>().sprite = sprite4;
                    break;
                case 5:
                    gameObject.GetComponent<Image>().sprite = sprite5;
                    break;
                case 6:
                    gameObject.GetComponent<Image>().sprite = sprite6;
                    break;
                case 7:
                    gameObject.GetComponent<Image>().sprite = sprite7;
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
