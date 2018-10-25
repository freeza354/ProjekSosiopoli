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

    public static int randomAnswer, randomQuestion;
    public static float timeRemaining, timeStart = 10f;

    public static bool timerLoop = false;
    public static bool nextPlayerTurn = false;
    public bool moveAllowed = false;
    public static bool CheckAnswerWhenTimeRunsOut1 = false, CheckAnswerWhenTimeRunsOut2 = false, CheckAnswerWhenTimeRunsOut3 = false, CheckAnswerWhenTimeRunsOut4 = false, CheckAnswerWhenTimeRunsOut5 = false;

    private float questionTrigger = 0;

    // Use this for initialization
    private void Start()
    {
        question = Resources.LoadAll<GameObject>("Prefab/");
        transform.position = waypoints[waypointIndex].transform.position;
        timeRemaining = timeStart;
        popupParent.SetActive(false);
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
            StartCoroutine(InstansiateQuiz());
            GameControl.turnOverPlayer1 = false;
        }

        if (GameControl.turnOverPlayer2)
        {
            StartCoroutine(InstansiateQuiz());
            GameControl.turnOverPlayer2 = false;
        }

        questionTimer.value = CalculateSliderValue();

        if (timerLoop)
        {

            timeRemaining -= Time.deltaTime;
            if (timeRemaining < 0)
                timerLoop = false;
        }

        if (timeRemaining <= 0)
        {
            timeRemaining = timeStart;
            questionTrigger = 0;
            Destroy(questionTemporary);
            popupParent.SetActive(false);

            if (CheckAnswerWhenTimeRunsOut1)
            {
                Data.answerPlayer1 -= 10;
                GameControl.turnOverPlayer1 = false;
            }

            else if(CheckAnswerWhenTimeRunsOut2)
            {
                Data.answerPlayer1 -= 10;
                GameControl.turnOverPlayer2 = false;
            }

            dice.SetActive(true);
        }

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
        if (GameControl.turnOverPlayer1)
            CheckAnswerWhenTimeRunsOut1 = true;
        else if(GameControl.turnOverPlayer2)
            CheckAnswerWhenTimeRunsOut2 = true;

        randomQuestion = Random.Range(1, question.Length + 1);
        randomAnswer = Random.Range(1, 5);
        yield return new WaitForSeconds(0.75f);
        popupParent.SetActive(true);
        questionTemporary = Instantiate(question[randomQuestion - 1], popupParent.transform);
        timerLoop = true;
    }

}
