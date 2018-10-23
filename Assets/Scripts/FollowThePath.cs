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
    private float questionTrigger = 0;

    public bool moveAllowed = false;

    // Use this for initialization
    private void Start()
    {
        transform.position = waypoints[waypointIndex].transform.position;
        timeRemaining = timeStart;
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

        //questionTrigger++;
        
        //if (questionTrigger == 1)
        //{
        //    StartCoroutine(InstansiateQuiz());
        //}
        

    }

    public float CalculateSliderValue()
    {
        return (timeRemaining / timeStart);
    }

    IEnumerator InstansiateQuiz()
    {
        randomQuestion = Random.Range(1, question.Length + 1);
        randomAnswer = Random.Range(1, 5);
        yield return new WaitForSeconds(1f);
        questionTemporary = Instantiate(question[randomQuestion - 1], popupParent.transform);
        timerLoop = true;
    }

}
