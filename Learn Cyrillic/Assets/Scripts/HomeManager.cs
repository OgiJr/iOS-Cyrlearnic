using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HomeManager : MonoBehaviour
{
    private string languageSaved = "";
    public GameObject[] languageSettings = new GameObject[9];
    public int languageSelected = 0;
    public AudioSource click;

    private Vector2 spawnPos = new Vector2(1500, 0);
    public GameObject homeObject;

    private void Start()
    {
        SelectLanguage();
        if (PlayerPrefs.GetString("Language") != string.Empty)
        {
            homeObject.transform.localPosition = new Vector2(-2000, 0);
        }
    }

    private void SelectLanguage()
    {
        languageSaved = PlayerPrefs.GetString("Language");
        GameObject newMenu;

        if (GameObject.FindGameObjectsWithTag("menu") != null)
        {
            foreach (GameObject menu in GameObject.FindGameObjectsWithTag("menu"))
            {
                Destroy(menu);
            }
        }

        switch (languageSaved)
        {
            case "RUS":
                newMenu = Instantiate(languageSettings[0], this.transform);
                newMenu.transform.localPosition = spawnPos;
                newMenu.transform.DOLocalMoveX(0, 2);
                homeObject.transform.DOMoveX(-1500, 2);
                break;
            case "BUL":
                newMenu = Instantiate(languageSettings[3], this.transform);
                newMenu.transform.localPosition = spawnPos;
                newMenu.transform.DOLocalMoveX(0, 2);
                homeObject.transform.DOMoveX(-1500, 2);
                break;
            case "SER":
                newMenu = Instantiate(languageSettings[4], this.transform);
                newMenu.transform.localPosition = spawnPos;
                newMenu.transform.DOLocalMoveX(0, 2);
                homeObject.transform.DOMoveX(-1500, 2);
                break;
            default:
                newMenu = Instantiate(languageSettings[8]);
                newMenu.transform.position = Vector3.zero;
                break;
        }
    }

    public void Select()
    {
        switch (languageSelected)
        {
            case 0:
                PlayerPrefs.SetString("Language", "RUS");
                break;
            case 1:
                PlayerPrefs.SetString("Language", "BUL");
                break;
            case 2:
                PlayerPrefs.SetString("Language", "SER");
                break;
        }
        click.Play();
        SelectLanguage();
    }

    public void Left()
    {
        click.Play();
        languageSelected--;

        if (languageSelected < 0)
        {
            languageSelected = 2;
        }
    }

    public void Right()
    {
        click.Play();
        languageSelected++;

        if (languageSelected > 2)
        {
            languageSelected = 0;
        }
    }
}
