using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FollowThePath : MonoBehaviour
{

    public Transform[] waypoints;

    [SerializeField]
    private GameObject[] question;

    public GameObject popupParent;
    public GameObject dice;

    public static GameObject questionTemporary;

    public Slider questionTimer;

    [SerializeField]
    private float moveSpeed = 1f;

    [HideInInspector]
    public int waypointIndex = 0;

    public static int randomAnswer, randomQuestion, checkPlayer;
    public static float timeRemaining, timeStart = 250f;

    public static bool timerLoop = false;
    public static bool nextPlayerTurn = false;
    public static bool questionOver = false;

    private bool[] firstMove = new bool[4];  

    public bool moveAllowed = false;

    // Use this for initialization
    private void Start()
    {
        question = Resources.LoadAll<GameObject>("Prefab/");
        transform.position = waypoints[waypointIndex].transform.position;
        timeRemaining = timeStart;
        popupParent.SetActive(false);
        checkPlayer = 1;

        for(int i = 0; i < 4; i++)
        {
            firstMove[i] = true;
        }

    }

    // Update is called once per frame
    private void Update()
    {
        if (moveAllowed)
        {
            //dice.SetActive(false);
            Move();
        }

        if (GameControl.turnOverPlayer1)
        {
            checkPlayer = 1;
            dice.SetActive(false);
            if(GameControl.player1StartWaypoint == 27)
            {
                Data.answerPlayer1 -= 5;
                questionOver = true;
            }
            else if (GameControl.player1StartWaypoint == 9)
            {
                Data.answerPlayer1 += 5;
                questionOver = true;
            }
            else
            {
                StartCoroutine(InstansiateQuiz());
            }
            GameControl.turnOverPlayer1 = false;
        }

        if (GameControl.turnOverPlayer2)
        {
            checkPlayer = 2;
            dice.SetActive(false);
            if (GameControl.player2StartWaypoint == 27)
            {
                Data.answerPlayer2 -= 5;
                questionOver = true;
            }
            else if (GameControl.player2StartWaypoint == 9)
            {
                Data.answerPlayer2 += 5;
                questionOver = true;
            }
            else
            {
                StartCoroutine(InstansiateQuiz());
            }
            GameControl.turnOverPlayer2 = false;
        }

        if (GameControl.turnOverPlayer3)
        {
            checkPlayer = 3;
            dice.SetActive(false);
            if (GameControl.player3StartWaypoint == 27)
            {
                Data.answerPlayer3 -= 5;
                questionOver = true;
            }
            else if (GameControl.player3StartWaypoint == 9)
            {
                Data.answerPlayer3 += 5;
                questionOver = true;
            }
            else
            {
                StartCoroutine(InstansiateQuiz());
            }
            GameControl.turnOverPlayer3 = false;
        }

        if (GameControl.turnOverPlayer4)
        {
            checkPlayer = 4;
            dice.SetActive(false);
            if (GameControl.player4StartWaypoint == 27)
            {
                Data.answerPlayer4 -= 5;
                questionOver = true;
            }
            else if (GameControl.player4StartWaypoint == 9)
            {
                Data.answerPlayer4 += 5;
                questionOver = true;
            }
            else
            {
                StartCoroutine(InstansiateQuiz());
            }
            GameControl.turnOverPlayer4 = false;
        }

        questionTimer.value = CalculateSliderValue();

        if (questionOver)
        {
            Destroy(questionTemporary);
            popupParent.SetActive(false);
            questionOver = false;
            
            if (checkPlayer == 1)
            {
                GameControl.turnOverPlayer1 = false;
            }

            else if (checkPlayer == 2)
            {
                GameControl.turnOverPlayer2 = false;
            }

            else if (checkPlayer == 3)
            {
                GameControl.turnOverPlayer3 = false;
            }

            else if (checkPlayer == 4)
            {
                GameControl.turnOverPlayer4 = false;
            }

            dice.SetActive(true);
            ResetTimer();

        }

        if (timerLoop && popupParent.activeInHierarchy)
        {
            timeRemaining -= Time.fixedDeltaTime;
            if (timeRemaining < 0)
                timerLoop = false;
        }

        if (timeRemaining <= 0)
        {
            
            if (checkPlayer == 1)
            {                
                Data.answerPlayer1 -= 10;
                GameManager.WrongAnswer();
                GameControl.turnOverPlayer1 = false;
            }

            else if(checkPlayer == 2)
            {
                Data.answerPlayer2 -= 10;
                GameManager.WrongAnswer();
                GameControl.turnOverPlayer2 = false;
            }

            else if (checkPlayer == 3)
            {
                Data.answerPlayer3 -= 10;
                GameManager.WrongAnswer();
                GameControl.turnOverPlayer3 = false;
            }

            else if (checkPlayer == 4)
            {
                Data.answerPlayer4 -= 10;
                GameManager.WrongAnswer();
                GameControl.turnOverPlayer4 = false;
            }

            dice.SetActive(true);

            ResetTimer();

            Destroy(questionTemporary);
            popupParent.SetActive(false);

        }

    }

    private void ResetTimer()
    {
        timeRemaining = timeStart;
        Debug.Log("this function is called " + timeRemaining);
    }

    private void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position,
        waypoints[waypointIndex].transform.position,
        moveSpeed * Time.deltaTime);

        if (transform.position == waypoints[waypointIndex].transform.position)
        {
            waypointIndex += 1;
            if(firstMove[GameControl.turnGame - 1] == true)
            {
                firstMove[GameControl.turnGame  - 1] = false;
            }
            else 
            {
                GameControl.diceSideThrown--;
            }
        }

    }

    public float CalculateSliderValue()
    {
        return (timeRemaining / timeStart);
    }

    IEnumerator QuizTimer()
    {
        yield return new WaitForSeconds(1f);
        timeRemaining--;
    }

    IEnumerator InstansiateQuiz()
    {
        randomQuestion = Random.Range(1, question.Length + 1);
        randomAnswer = Random.Range(1, 5);
        yield return new WaitForSeconds(0.75f);
        popupParent.SetActive(true);
        questionTemporary = Instantiate(question[randomQuestion - 1], popupParent.transform);
        timerLoop = true;
    }

}
