using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    private static GameObject whoWinsTextShadow;

    public static Text player1MoveText, player2MoveText, player3MoveText, player4MoveText;

    private static GameObject player1, player2, player3, player4;
    
    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;
    public static int player3StartWaypoint = 0;
    public static int player4StartWaypoint = 0;
    public static int turnGame = 1;

    public static bool gameOver = false;
    public static bool turnOverPlayer1 = false, turnOverPlayer2 = false, turnOverPlayer3 = false, turnOverPlayer4 = false;

    // Use this for initialization
    void Start () {

        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        player1MoveText = GameObject.Find("Player1MoveText").GetComponent<Text>();
        player2MoveText = GameObject.Find("Player2MoveText").GetComponent<Text>();
        player3MoveText = GameObject.Find("Player3MoveText").GetComponent<Text>();
        player4MoveText = GameObject.Find("Player4MoveText").GetComponent<Text>();

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
        player3 = GameObject.Find("Player3");
        player4 = GameObject.Find("Player4");
        
        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;
        player3.GetComponent<FollowThePath>().moveAllowed = false;
        player4.GetComponent<FollowThePath>().moveAllowed = false;

        whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);
        player3MoveText.gameObject.SetActive(false);
        player4MoveText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (diceSideThrown == 0 && player1.GetComponent<FollowThePath>().moveAllowed == true)
        {           
                player1.GetComponent<FollowThePath>().moveAllowed = false;
                player1MoveText.gameObject.SetActive(false);
                player2MoveText.gameObject.SetActive(true);
                player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
                turnOverPlayer1 = true;            
        }

        if (diceSideThrown == 0 && player2.GetComponent<FollowThePath>().moveAllowed == true)
        {
           
                player2.GetComponent<FollowThePath>().moveAllowed = false;
                player2MoveText.gameObject.SetActive(false);
                player3MoveText.gameObject.SetActive(true);
                player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
                turnOverPlayer2 = true;
            
        }

        if (diceSideThrown == 0 && player3.GetComponent<FollowThePath>().moveAllowed == true)
        {
           
                player3.GetComponent<FollowThePath>().moveAllowed = false;
                player3MoveText.gameObject.SetActive(false);
                player4MoveText.gameObject.SetActive(true);
                player3StartWaypoint = player3.GetComponent<FollowThePath>().waypointIndex - 1;
                turnOverPlayer3 = true;
            
        }

        if (diceSideThrown == 0 && player4.GetComponent<FollowThePath>().moveAllowed == true)
        {
           
                player4.GetComponent<FollowThePath>().moveAllowed = false;
                player4MoveText.gameObject.SetActive(false);
                player1MoveText.gameObject.SetActive(true);
                player4StartWaypoint = player4.GetComponent<FollowThePath>().waypointIndex - 1;
                turnOverPlayer4 = true;
            
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            /*whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 1 Wins";
            gameOver = true;*/
            player1.GetComponent<FollowThePath>().waypointIndex = 0;
            player1StartWaypoint = 0;
            Data.answerPlayer1 += 15;
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
            player2.GetComponent<FollowThePath>().waypointIndex = 0;
            player2StartWaypoint = 0;
            Data.answerPlayer2 += 15;
        }

        if (player3.GetComponent<FollowThePath>().waypointIndex ==
            player3.GetComponent<FollowThePath>().waypoints.Length)
        {
            /*
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 2 Wins";
            gameOver = true;*/
            player3.GetComponent<FollowThePath>().waypointIndex = 0;
            player3StartWaypoint = 0;
            Data.answerPlayer3 += 15;
        }
        
        if (player4.GetComponent<FollowThePath>().waypointIndex ==
            player4.GetComponent<FollowThePath>().waypoints.Length)
        {
            /*
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 2 Wins";
            gameOver = true;*/
            player4.GetComponent<FollowThePath>().waypointIndex = 0;
            player4StartWaypoint = 0;
            Data.answerPlayer4 += 15;
        }


    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                turnGame = 1;
                break;
            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                turnGame = 2;
                break;
            case 3:
                player3.GetComponent<FollowThePath>().moveAllowed = true;
                turnGame = 3;
                break;
            case 4:
                player4.GetComponent<FollowThePath>().moveAllowed = true;
                turnGame = 4;
                break;
        }
    }


}
