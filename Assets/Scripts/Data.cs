using UnityEngine;

public class Data : MonoBehaviour{

    public static int answer;
    public static int answerPlayer1 = 0, answerPlayer2 = 0, answerPlayer3 = 0, answerPlayer4 = 0;
    public int getAnswer;

    private void Start()
    {
        answer = getAnswer;
        Debug.Log("The answer value is : " + answer);
    }


    public void buttonAnswer1()
    {
        if (answer == 1)
        {
            Debug.Log("This code is called A");
            if (FollowThePath.checkPlayer == 1)
            {
                Debug.Log("This code is called 1+");
                Data.answerPlayer1 += 10;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                Debug.Log("This code is called 2+");
                Data.answerPlayer2 += 10;
            }
        }
        else
        {
            if (FollowThePath.checkPlayer == 1)
            {
                Debug.Log("This code is called 1-");
                answerPlayer1 -= 10;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                Debug.Log("This code is called 2-");
                answerPlayer2 -= 10;
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
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 += 10;
            }
        }
        else
        {
            if (FollowThePath.checkPlayer == 1)
            {
                answerPlayer1 -= 10;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 -= 10;
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
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                Debug.Log("This code is called 2+");
                answerPlayer2 += 10;
            }
        }
        else
        {
            if (FollowThePath.checkPlayer == 1)
            {
                Debug.Log("This code is called");
                answerPlayer1 -= 10;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                Debug.Log("This code is called");
                answerPlayer2 -= 10;
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
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 += 10;
            }
        }
        else
        {
            if (FollowThePath.checkPlayer == 1)
            {
                answerPlayer1 -= 10;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 -= 10;
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
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 += 10;
            }
        }
        else
        {
            if (FollowThePath.checkPlayer == 1)
            {
                answerPlayer1 -= 10;
            }
            else if (FollowThePath.checkPlayer == 2)
            {
                answerPlayer2 -= 10;
            }
        }
    }

}
