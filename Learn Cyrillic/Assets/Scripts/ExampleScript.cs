using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ExampleScript : MonoBehaviour
{
    public AudioSource click;
    private GameObject homeScreen;
    public GameObject mainMenu;
    public AudioSource success;

    public GameObject writeBoard;

    public AudioSource letterAudio;
    public AudioSource wordAudio;

    private void Update()
    {
        if (click == null)
        {
            click = GameObject.Find("Click").GetComponent<AudioSource>();
        }

        if (writeBoard != null)
        {
            writeBoard.transform.position = new Vector3(0, -4.5f, -1);
        }

        if (homeScreen == null)
        {
            foreach (GameObject go in GameObject.FindGameObjectsWithTag("menu"))
            {
                if (go.name != "LetterScreen(Clone)")
                {
                    homeScreen = go;
                }
            }
        }
    }

    bool playable = true;

    public void AudioWord()
    {
        if(playable == true)
        {
            playable = false;
            wordAudio.Play();
        }
        Invoke("Playable", 1);
    }

    public void AudioLetter()
    {
        if (playable == true)
        {
            playable = false;
            letterAudio.Play();
        }
        Invoke("Playable", 1);
    }

    private void Playable()
    {
        playable = true;
    }

    public void Advance()
    {
        click.Play();
        Destroy(writeBoard);
        this.transform.parent.transform.DOLocalMoveX(-1500, 2);
    }

    public void Return()
    {
        if (PlayerPrefs.GetInt("LearnMode") == 0)
        {
            ProgressManager progressManager = GameObject.FindGameObjectWithTag("menu").GetComponent<ProgressManager>();
            progressManager.CheckLetters();
            homeScreen.transform.localPosition = new Vector2(1500, 0);
            homeScreen.transform.DOLocalMoveX(0, 2);

            mainMenu = GameObject.FindGameObjectWithTag("mainMenu");
            mainMenu.GetComponent<Button>().enabled = true;
            mainMenu.GetComponent<Image>().enabled = true;
            this.transform.parent.transform.DOLocalMoveX(-3000, 2);
            success.Play();
        }
        else
        {
            GameObject.Find("LetterScreen(Clone)").transform.localPosition = new Vector2(1500, 0);
            this.transform.parent.transform.DOLocalMoveX(0, 2);
        }
        PlayerPrefs.SetInt("LearnMode", 0);
    }
}
