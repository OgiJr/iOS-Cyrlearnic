using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CheckAnswer : MonoBehaviour
{
    private ExerciseManager exerciseManager;
    public AudioSource success;
    public AudioSource fail;
    bool returnOnTouch = false;

    public Text answerText;
    private Camera mainCamera;
    public Color defaultColor;
    public Color errorColor;
    public Color correctColor;
    public GameObject tick;

    public Color successBackground;
    public Color failBackground;
    public Color standardBackground;

    public Image background;

    private void Update()
    {
        if (exerciseManager == null)
        {
            exerciseManager = GameObject.FindGameObjectWithTag("menu").GetComponent<ExerciseManager>();
            mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        }

        if (returnOnTouch == true)
        {
            if (Input.GetMouseButtonDown(0) || Input.touchCount > 0 && EventSystem.current.currentSelectedGameObject == null)
            {
                returnOnTouch = false;
                Return();
            }
        }
    }
    public void CheckAnswerMethod()
    {
        background = GameObject.Find("Background").GetComponent<Image>();
        GameObject.FindGameObjectWithTag("mainMenu").GetComponent<Image>().enabled = true;
        GameObject.FindGameObjectWithTag("mainMenu").GetComponent<Button>().enabled = true;
        if (exerciseManager.input.ToLower() == exerciseManager.answer.ToLower())
        {
            success.Play();
            mainCamera.backgroundColor = correctColor;
            background.color = successBackground;
            tick.SetActive(false);
            returnOnTouch = true;
        }
        else
        {
            mainCamera.backgroundColor = errorColor;
            background.color = failBackground;
            tick.SetActive(false);
            returnOnTouch = true;
            fail.Play();
            answerText.text = "Answer: " + exerciseManager.answer + ".";
            answerText.fontSize = 190;
        }
    }

    private void Return()
    {
        GameObject.Find("Click").GetComponent<AudioSource>().Play();
        mainCamera.backgroundColor = defaultColor;
        background.color = standardBackground;
        exerciseManager.transform.localPosition = new Vector2(1500, 0);
        exerciseManager.transform.DOLocalMoveX(0, 2);
        this.transform.DOLocalMoveX(-1500, 2);
    }
}
