using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    private static GameObject whoWinsTextShadow, player1MoveText, player2MoveText;

    private static GameObject player1, player2;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;

    public static bool gameOver = false;
    public static bool turnOverPlayer1 = false, turnOverPlayer2 = false;

    // Use this for initialization
    void Start () {

        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        player1MoveText = GameObject.Find("Player1MoveText");
        player2MoveText = GameObject.Find("Player2MoveText");

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;
        
        whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {  
        if (player1.GetComponent<FollowThePath>().waypointIndex > 
            player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(true);
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
            turnOverPlayer1 = true;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2StartWaypoint + diceSideThrown)
        {
            player2.GetComponent<FollowThePath>().moveAllowed = false;
            player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(true);
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
            turnOverPlayer2 = true;
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            /*whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 1 Wins";
            gameOver = true;*/
            //player1.GetComponent<FollowThePath>().waypointIndex = 0;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            /*
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 2 Wins";
            gameOver = true;*/
            //player2.GetComponent<FollowThePath>().waypointIndex = 0;
        }

    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }

    public void buttonAnswer1()
    {
        if (Data.answer == 1)
        {
            if (turnOverPlayer1)
            {
                FollowThePath.CheckAnswerWhenTimeRunsOut1 = false;
                Data.answerPlayer1 += 10;
            }
            else if (turnOverPlayer2)
            {
                FollowThePath.CheckAnswerWhenTimeRunsOut2 = false;
                Data.answerPlayer2 += 10;
            }
        }
        else
        {
            if (turnOverPlayer1)
            {
                FollowThePath.CheckAnswerWhenTimeRunsOut1 = false;
                Data.answerPlayer1 -= 10;
            }
            else if (turnOverPlayer2)
            {
                FollowThePath.CheckAnswerWhenTimeRunsOut2 = false;
                Data.answerPlayer2 -= 10;
            }
        }
    }

    public void buttonAnswer2()
    {
        if (Data.answer == 2)
        {
            if (turnOverPlayer1)
            {
                FollowThePath.CheckAnswerWhenTimeRunsOut1 = false;
                Data.answerPlayer1 += 10;
            }
            else if (turnOverPlayer2)
            {
                FollowThePath.CheckAnswerWhenTimeRunsOut2 = false;
                Data.answerPlayer2 += 10;
            }
        }
        else
        {
            if (turnOverPlayer1)
            {
                Data.answerPlayer1 -= 10;
            }
            else if (turnOverPlayer2)
            {
                Data.answerPlayer2 -= 10;
            }
        }
    }

    public void buttonAnswer3()
    {
        if (Data.answer == 3)
        {
            if (turnOverPlayer1)
            {
                Data.answerPlayer1 += 10;
            }
            else if (turnOverPlayer2)
            {
                Data.answerPlayer2 += 10;
            }
        }
        else
        {
            if (turnOverPlayer1)
            {
                Data.answerPlayer1 -= 10;
            }
            else if (turnOverPlayer2)
            {
                Data.answerPlayer2 -= 10;
            }
        }
    }

    public void buttonAnswer4()
    {
        if (Data.answer == 4)
        {
            if (turnOverPlayer1)
            {
                Data.answerPlayer1 += 10;
            }
            else if (turnOverPlayer2)
            {
                Data.answerPlayer2 += 10;
            }
        }
        else
        {
            if (turnOverPlayer1)
            {
                Data.answerPlayer1 -= 10;
            }
            else if (turnOverPlayer2)
            {
                Data.answerPlayer2 -= 10;
            }
        }
    }
    public void buttonAnswer5()
    {
        if (Data.answer == 5)
        {
            if (turnOverPlayer1)
            {
                Data.answerPlayer1 += 10;
            }
            else if (turnOverPlayer2)
            {
                Data.answerPlayer2 += 10;
            }
        }
        else
        {
            if (turnOverPlayer1)
            {
                Data.answerPlayer1 -= 10;
            }
            else if (turnOverPlayer2)
            {
                Data.answerPlayer2 -= 10;
            }
        }
    }

}
