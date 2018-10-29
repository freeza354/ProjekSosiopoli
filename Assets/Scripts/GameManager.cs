using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public Text scorePlayer1Text, scoreplayer2Text, scoreplayer3Text, scoreplayer4Text, GameTimer;
    public static AudioClip wrongClip, correctClip;
    public static AudioSource wrongSource, correctSource;
    public GameObject PauseMenuUI;
    public GameObject Player1, Player2, Player3, Player4, Player1LoseUI, Player2LoseUI, Player3LoseUI, Player4LoseUI, Player1WinUI, Player2WinUI, Player3WinUI, Player4WinUI;
    public Text Player1Name, Player2Name, Player3Name, Player4Name;

    public static bool isPaused = false;

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
    void Update() {

        scorePlayer1Text.text = "" + Data.answerPlayer1;
        scoreplayer2Text.text = "" + Data.answerPlayer2;
        scoreplayer3Text.text = "" + Data.answerPlayer3;
        scoreplayer4Text.text = "" + Data.answerPlayer4;
        
        GameControl.player1MoveText.text = Data.Player1Name + "'s Move";
        GameControl.player2MoveText.text = Data.Player2Name + "'s Move";
        GameControl.player3MoveText.text = Data.Player3Name + "'s Move"; 
        GameControl.player4MoveText.text = Data.Player4Name + "'s Move";

        Player1Name.text = Data.Player1Name;
        Player2Name.text = Data.Player2Name;
        Player3Name.text = Data.Player3Name;
        Player4Name.text = Data.Player4Name;

        if(Data.Player1Lose == true)
        {
            Player1.SetActive(false);
            scorePlayer1Text.gameObject.SetActive(false);
            Player1LoseUI.SetActive(true);
        }

        if (Data.Player2Lose == true)
        {
            Player2.SetActive(false);
            scoreplayer2Text.gameObject.SetActive(false);
            Player2LoseUI.SetActive(true);
        }

        if (Data.Player3Lose == true)
        {
            Player3.SetActive(false);
            scoreplayer3Text.gameObject.SetActive(false);
            Player3LoseUI.SetActive(true);
        }

        if (Data.Player4Lose == true)
        {
            Player4.SetActive(false);
            scoreplayer4Text.gameObject.SetActive(false);
            Player4LoseUI.SetActive(true);
        }

        CheckWin();

        second = (int)(timeGame % 60);
        minutes = (int)(timeGame / 60);

        GameTimer.text = minutes + " : " + second;
        
        if (timeGame <= 0)
        {
            StopCoroutine(LosingTimerGame());
            if((Data.answerPlayer1 > Data.answerPlayer2) && (Data.answerPlayer1 > Data.answerPlayer3) && (Data.answerPlayer1 > Data.answerPlayer4))
            {
                Player1WinUI.SetActive(true);
                Time.timeScale = 0f;
            }
            else if((Data.answerPlayer2 > Data.answerPlayer1) && (Data.answerPlayer2 > Data.answerPlayer3) && (Data.answerPlayer2 > Data.answerPlayer4))
            {
                Player2WinUI.SetActive(true);
                Time.timeScale = 0f;
            }
            else if ((Data.answerPlayer3 > Data.answerPlayer1) && (Data.answerPlayer3 > Data.answerPlayer2) && (Data.answerPlayer3 > Data.answerPlayer4))
            {
                Player3WinUI.SetActive(true);
                Time.timeScale = 0f;
            }
            else if ((Data.answerPlayer4 > Data.answerPlayer1) && (Data.answerPlayer4 > Data.answerPlayer3) && (Data.answerPlayer4 > Data.answerPlayer2))
            {
                Player4WinUI.SetActive(true);
                Time.timeScale = 0f;
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Paused();
            }
        }

    }

    public void CheckWin()
    {

        if (Data.Player2Lose == true && Data.Player3Lose == true && Data.Player4Lose == true)
            Player1WinUI.SetActive(true);
        else if (Data.Player1Lose == true && Data.Player3Lose == true && Data.Player4Lose == true)
            Player2WinUI.SetActive(true);
        else if (Data.Player1Lose == true && Data.Player2Lose == true && Data.Player4Lose == true)
            Player3WinUI.SetActive(true);
        else if (Data.Player1Lose == true && Data.Player2Lose == true && Data.Player3Lose == true)
            Player4WinUI.SetActive(true);
              
    }

    void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Paused()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void PauseButton()
    {
        if (isPaused)
        {
            Resume();
        }
        else
        {
            Paused();
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
