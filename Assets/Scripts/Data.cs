using UnityEngine;
using UnityEngine.SceneManagement;

public class Data : MonoBehaviour{

    public static int answer;
    public static int answerPlayer1 = 0, answerPlayer2 = 0, answerPlayer3 = 0, answerPlayer4 = 0;
    public int getAnswer;
    
    public static string Player1Name, Player2Name, Player3Name, Player4Name, PlayerNametemp;    

    public GameObject Player1, Player2, Player3, Player4;

    private void Start()
    {
        answer = getAnswer;
        Debug.Log("The answer value is : " + answer);
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
            Debug.Log("This code activated 3" + Player2Name); 
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
            SceneManager.LoadScene("SampleScene");
        }
    }

    public void buttonAnswer1()
    {
        if (answer == 1)
        {
            Debug.Log("This code is called A");
            if (FollowThePath.checkPlayer == 1)
            {
                Debug.Log("This code is called 1+");
                answerPlayer1 += 10;
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                Debug.Log("This code is called 2+");
                answerPlayer2 += 10;
                FollowThePath.questionOver = true;
            }
        }
        else
        {
            if (FollowThePath.checkPlayer == 1)
            {
                Debug.Log("This code is called 1-");
                answerPlayer1 -= 10;
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                Debug.Log("This code is called 2-");
                answerPlayer2 -= 10;
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
                answerPlayer1 += 10;
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 += 10;
                FollowThePath.questionOver = true;
            }
        }
        else
        {
            if (FollowThePath.checkPlayer == 1)
            {
                answerPlayer1 -= 10;
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 -= 10;
                FollowThePath.questionOver = true;
            }
        }
    }

    public void buttonAnswer3()
    {
        if (answer == 3)
        {
            Debug.Log("This code is called C");
            if (FollowThePath.checkPlayer == 1)
            {
                Debug.Log("This code is called 1+");
                answerPlayer1 += 10;
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                Debug.Log("This code is called 2+");
                answerPlayer2 += 10;
                FollowThePath.questionOver = true;
            }
        }
        else
        {
            if (FollowThePath.checkPlayer == 1)
            {
                Debug.Log("This code is called");
                answerPlayer1 -= 10;
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                Debug.Log("This code is called");
                answerPlayer2 -= 10;
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
                answerPlayer1 += 10;
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 += 10;
                FollowThePath.questionOver = true;
            }
        }
        else
        {
            if (FollowThePath.checkPlayer == 1)
            {
                answerPlayer1 -= 10;
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 -= 10;
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
                answerPlayer1 += 10;
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 += 10;
                FollowThePath.questionOver = true;
            }
        }
        else
        {
            if (FollowThePath.checkPlayer == 1)
            {
                answerPlayer1 -= 10;
                FollowThePath.questionOver = true;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 -= 10;
                FollowThePath.questionOver = true;
            }
        }
    }

}
