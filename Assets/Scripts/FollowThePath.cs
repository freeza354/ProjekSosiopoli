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
    public static float timeRemaining, timeStart = 40f;

    public static bool timerLoop = false;
    public static bool nextPlayerTurn = false;
    public static bool questionOver = false;

    public bool moveAllowed = false;

    // Use this for initialization
    private void Start()
    {
        question = Resources.LoadAll<GameObject>("Prefab/");
        transform.position = waypoints[waypointIndex].transform.position;
        timeRemaining = timeStart;
        popupParent.SetActive(false);
        checkPlayer = 1;
    }

    // Update is called once per frame
    private void Update()
    {
        if (moveAllowed)
        {
            dice.SetActive(false);
            Move();
        }

        if (GameControl.turnOverPlayer1)
        {
            checkPlayer = 1;
            StartCoroutine(InstansiateQuiz());
            GameControl.turnOverPlayer1 = false;
        }

        if (GameControl.turnOverPlayer2)
        {
            checkPlayer = 2;
            StartCoroutine(InstansiateQuiz());
            GameControl.turnOverPlayer2 = false;
        }

        if (GameControl.turnOverPlayer3)
        {
            checkPlayer = 3;
            StartCoroutine(InstansiateQuiz());
            GameControl.turnOverPlayer3 = false;
        }

        if (GameControl.turnOverPlayer4)
        {
            checkPlayer = 4;
            StartCoroutine(InstansiateQuiz());
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
                Debug.Log("This code called min1 " + Data.answerPlayer1);
                GameControl.turnOverPlayer1 = false;
            }

            else if (checkPlayer == 2)
            {
                Debug.Log("This code called min2 " + Data.answerPlayer2);
                GameControl.turnOverPlayer2 = false;
            }

            else if (checkPlayer == 3)
            {
                Debug.Log("This code called min2 " + Data.answerPlayer3);
                GameControl.turnOverPlayer3 = false;
            }

            else if (checkPlayer == 4)
            {
                Debug.Log("This code called min2 " + Data.answerPlayer4);
                GameControl.turnOverPlayer4 = false;
            }

            dice.SetActive(true);

            ResetTimer();

            Debug.Log("Is this called?");

        }

        if (timerLoop && popupParent.activeInHierarchy)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining < 0)
                timerLoop = false;
        }

        if (timeRemaining <= 0)
        {
            
            if (checkPlayer == 1)
            {                
                Data.answerPlayer1 -= 10;
                Debug.Log("This code called min1 " + Data.answerPlayer1);
                GameControl.turnOverPlayer1 = false;
            }

            else if(checkPlayer == 2)
            {
                Data.answerPlayer2 -= 10;
                Debug.Log("This code called min2 " + Data.answerPlayer2);
                GameControl.turnOverPlayer2 = false;
            }

            else if (checkPlayer == 3)
            {
                Data.answerPlayer3 -= 10;
                Debug.Log("This code called min2 " + Data.answerPlayer2);
                GameControl.turnOverPlayer2 = false;
            }

            else if (checkPlayer == 4)
            {
                Data.answerPlayer4 -= 10;
                Debug.Log("This code called min2 " + Data.answerPlayer2);
                GameControl.turnOverPlayer2 = false;
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
        }
        if (waypointIndex == waypoints.Length)
        {
            waypointIndex = 0;
        }

    }

    public float CalculateSliderValue()
    {
        return (timeRemaining / timeStart);
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
