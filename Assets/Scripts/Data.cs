using UnityEngine;
using UnityEngine.SceneManagement;

public class Data : MonoBehaviour{

    public static int answer;
    public static int answerPlayer1 = 250, answerPlayer2 = 250, answerPlayer3 = 250, answerPlayer4 = 250;
    public static bool Player1Lose = false, Player2Lose = false, Player3Lose = false, Player4Lose = false;
    public int getAnswer;
    
    public static string Player1Name, Player2Name, Player3Name, Player4Name, PlayerNametemp;    

    public GameObject Player1, Player2, Player3, Player4;

    private void Start()
    {
        answer = getAnswer;
        Debug.Log("The answer value is : " + answer);
    }

    private void Update()
    {
        if (answerPlayer1 <= 0)
        {
            Player1Lose = true;
        }

        if(answerPlayer2 <= 0)
        {
            Player2Lose = true;
        }

        if (answerPlayer3 <= 0)
        {
            Player3Lose = true;
        }

        if(answerPlayer4 <= 0)
        {
            Player4Lose = true;
        }
    }    

    public void Set_Text()
    {
        if (Player1.activeInHierarchy)
        {
            Player1Name = Player1.GetComponent<UnityEngine.UI.InputField>().text;
            Player1.SetActive(false);
            Player2.SetActive(true);
            Debug.Log("This code activated 1 " + Player1Name);
        }            
        else if (Player2.activeInHierarchy)
        {
            Player2Name = Player2.GetComponent<UnityEngine.UI.InputField>().text;
            Player2.SetActive(false);
            Player3.SetActive(true);
            Debug.Log("This code activated 2" + Player2Name); 
        }
        else if (Player3.activeInHierarchy)
        {
            Player3Name = Player3.GetComponent<UnityEngine.UI.InputField>().text;
            Player3.SetActive(false);
            Player4.SetActive(true);
            Debug.Log("This code activated 3" + Player3Name);
        }
        else if (Player4.activeInHierarchy)
        {
            Player4Name = Player4.GetComponent<UnityEngine.UI.InputField>().text;
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void buttonAnswer1()
    {
        if (answer == 1)
        {
            if (FollowThePath.checkPlayer == 1)
            {
                answerPlayer1 += (25 + WaypointData.pointBenar[GameControl.player1StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 += (25 + WaypointData.pointBenar[GameControl.player2StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 3)
            {
                answerPlayer3 += (25 + WaypointData.pointBenar[GameControl.player3StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 4)
            {
                answerPlayer4 += (25 + WaypointData.pointBenar[GameControl.player4StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
        }
        else
        {
            if (FollowThePath.checkPlayer == 1)
            {
                answerPlayer1 -= (10 + WaypointData.pointSalah[GameControl.player1StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 -= (10 + WaypointData.pointSalah[GameControl.player2StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 3)
            {
                answerPlayer3 -= (10 + WaypointData.pointSalah[GameControl.player3StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 4)
            {
                answerPlayer4 -= (10 + WaypointData.pointSalah[GameControl.player4StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
        }
    }

    public void buttonAnswer2()
    {
        if (answer == 2)
        {
            if (FollowThePath.checkPlayer == 1)
            {
                answerPlayer1 += (25 + WaypointData.pointBenar[GameControl.player1StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 += (25 + WaypointData.pointBenar[GameControl.player2StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 3)
            {
                answerPlayer3 += (25 + WaypointData.pointBenar[GameControl.player3StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 4)
            {
                answerPlayer4 += (25 + WaypointData.pointBenar[GameControl.player4StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
        }
        else
        {
            if (FollowThePath.checkPlayer == 1)
            {
                answerPlayer1 -= (10 + WaypointData.pointSalah[GameControl.player1StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 -= (10 + WaypointData.pointSalah[GameControl.player2StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 3)
            {
                answerPlayer3 -= (10 + WaypointData.pointSalah[GameControl.player3StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 4)
            {
                answerPlayer4 -= (10 + WaypointData.pointSalah[GameControl.player4StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
        }
    }

    public void buttonAnswer3()
    {
        if (answer == 3)
        {
            if (FollowThePath.checkPlayer == 1)
            {
                answerPlayer1 += (25 + WaypointData.pointBenar[GameControl.player1StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 += (25 + WaypointData.pointBenar[GameControl.player2StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 3)
            {
                answerPlayer3 += (25 + WaypointData.pointBenar[GameControl.player3StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 4)
            {
                answerPlayer4 += (25 + WaypointData.pointBenar[GameControl.player4StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
        }
        else
        {
            if (FollowThePath.checkPlayer == 1)
            {
                answerPlayer1 -= (10 + WaypointData.pointSalah[GameControl.player1StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 -= (10 + WaypointData.pointSalah[GameControl.player2StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 3)
            {
                answerPlayer3 -= (10 + WaypointData.pointSalah[GameControl.player3StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 4)
            {
                answerPlayer4 -= (10 + WaypointData.pointSalah[GameControl.player4StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
        }
    }

    public void buttonAnswer4()
    {
        if (answer == 4)
        {
            if (FollowThePath.checkPlayer == 1)
            {
                answerPlayer1 += (25 + WaypointData.pointBenar[GameControl.player1StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 += (25 + WaypointData.pointBenar[GameControl.player2StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 3)
            {
                answerPlayer3 += (25 + WaypointData.pointBenar[GameControl.player3StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 4)
            {
                answerPlayer4 += (25 + WaypointData.pointBenar[GameControl.player4StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
        }
        else
        {
            if (FollowThePath.checkPlayer == 1)
            {
                answerPlayer1 -= (10 + WaypointData.pointSalah[GameControl.player1StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 -= (10 + WaypointData.pointSalah[GameControl.player2StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 3)
            {
                answerPlayer3 -= (10 + WaypointData.pointSalah[GameControl.player3StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 4)
            {
                answerPlayer4 -= (10 + WaypointData.pointSalah[GameControl.player4StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
        }
    }
    public void buttonAnswer5()
    {
        if (answer == 5)
        {
            if (FollowThePath.checkPlayer == 1)
            {
                answerPlayer1 += (25 + WaypointData.pointBenar[GameControl.player1StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 += (25 + WaypointData.pointBenar[GameControl.player2StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 3)
            {
                answerPlayer3 += (25 + WaypointData.pointBenar[GameControl.player3StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 4)
            {
                answerPlayer4 += (25 + WaypointData.pointBenar[GameControl.player4StartWaypoint]);
                GameManager.CorrectAnswer();
                FollowThePath.questionOver = true;
            }
        }
        else
        {
            if (FollowThePath.checkPlayer == 1)
            {
                answerPlayer1 -= (10 + WaypointData.pointSalah[GameControl.player1StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 -= (10 + WaypointData.pointSalah[GameControl.player2StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 3)
            {
                answerPlayer3 -= (10 + WaypointData.pointSalah[GameControl.player3StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 4)
            {
                answerPlayer4 -= (10 + WaypointData.pointSalah[GameControl.player4StartWaypoint]);
                GameManager.WrongAnswer();
                FollowThePath.questionOver = true;
            }
        }
    }

}
