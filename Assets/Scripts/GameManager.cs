using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Text scorePlayer1Text, scoreplayer2Text, scoreplayer3Text, scoreplayer4Text;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        scorePlayer1Text.text = "" + Data.answerPlayer1;
        scoreplayer2Text.text = "" + Data.answerPlayer2;
        scoreplayer3Text.text = "" + Data.answerPlayer3;
        scoreplayer4Text.text = "" + Data.answerPlayer4;

        GameControl.player1MoveText.text = Data.Player1Name + "'s Move";
        GameControl.player2MoveText.text = Data.Player2Name + "'s Move";
        GameControl.player3MoveText.text = Data.Player3Name + "'s Move";
        GameControl.player4MoveText.text = Data.Player4Name + "'s Move";

    }
}
