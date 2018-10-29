using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

    public GameObject setName, hint;

    public void onStartClicked()
    {
        setName.active = true;
        hint.active = false;
    }

    public void onHintClicked()
    {

        setName.active = false;
        hint.active = true;
    }

    public void onBackClicked()
    {
        setName.active = false;
        hint.active = false;
    }

    public void onBackToMenuClicked()
    {
        Application.LoadLevel(0);
    }

    public void onExitClicked()
    {
        Application.Quit();
    }

}
