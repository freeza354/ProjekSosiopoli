using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollDice : MonoBehaviour {

    public Dice Dice1, Dice2;

    private bool coroutineAllowed = true;
    private int whosTurn = 1;

    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseDown()
    {
        if (!GameControl.gameOver && coroutineAllowed)
        {
        //    StartCoroutine(Dice1.DiceRollAnim());
        //    StartCoroutine(Dice2.DiceRollAnim());
            StartCoroutine(RollTheDice());
        }
    }

    private IEnumerator RollTheDice()
    {
        coroutineAllowed = false;

        GameControl.diceSideThrown = Dice1.diceVal + Dice2.diceVal;
        Debug.Log("dadu = " + Dice1.diceVal + Dice2.diceVal);

        if (whosTurn == 1)
        {
            GameControl.MovePlayer(1);
        }
        else if (whosTurn == 2)
        {
            GameControl.MovePlayer(2);
        }
        else if (whosTurn == 3)
        {
            GameControl.MovePlayer(3);
        }
        else if (whosTurn == 4)
        {
            GameControl.MovePlayer(4);
            whosTurn = 0;
        }

        whosTurn += 1;
        coroutineAllowed = true;

        yield return new WaitForSeconds(0.5f);

    }

}
