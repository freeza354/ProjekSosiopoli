using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public Text scorePlayer1Text, scoreplayer2Text, scoreplayer3Text, scoreplayer4Text, GameTimer;
    public static AudioClip wrongClip, correctClip;
    public static AudioSource wrongSource, correctSource;
    
    public static float timeGame = 7200f;
    private int minutes, second;

    // Use this for initialization
    void Start () {

        wrongClip = Resources.Load<AudioClip>("SFX/Wrong");
        correctClip = Resources.Load<AudioClip>("SFX/Correct");
        wrongSource = gameObject.GetComponent<AudioSource>();
        correctSource = gameObject.GetComponent<AudioSource>();

        StartCoroutine(LosingTimerGame());

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
        
        second = (int)(timeGame % 60);
        minutes = (int)(timeGame / 60);

        GameTimer.text = minutes + " : " + second;
        
        if (timeGame <= 0)
        {
            StopCoroutine(LosingTimerGame());
            GameTimer.text = "Times up!";
        }

    }

    public static void WrongAnswer()
    {
        wrongSource.clip = wrongClip;
        wrongSource.Play();
    }

    public static void CorrectAnswer()
    {

        correctSource.clip = correctClip;
        correctSource.Play();
    }

    IEnumerator LosingTimerGame()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeGame--;
        }
    }

}
