using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoller : MonoBehaviour {

	// Use this for initialization
	void Start () {
        RollResult = new int();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int RollResult;

    public Sprite[] DiceImages;

    public void RollDie()
    {
        RollResult = Random.Range(1,7);
        Debug.Log("Rolled: " + RollResult);
        this.transform.GetComponent<Image>().sprite = DiceImages[RollResult - 1];
    }

}
