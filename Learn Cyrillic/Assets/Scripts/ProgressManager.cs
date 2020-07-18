using UnityEngine;
using UnityEngine.UI;

public class ProgressManager : MonoBehaviour
{
    public bool[] level;
    public string language = "";
    private string code;
    public int highestLevel = 0;

    private void Update()
    {
        if (language == "")
        {
            Assign();
        }
    }

    private void Assign()
    {
        language = this.gameObject.name;
        Debug.Log(language);
        switch (language)
        {
            case "Bulgarian(Clone)":
                level = new bool[30];
                code = "BUL";
                for (int i = 0; i < 30; i++)
                {
                    if (PlayerPrefs.GetInt("BUL" + i.ToString()) == 0)
                    {
                        level[i] = false;
                    }
                    else
                    {
                        level[i] = true;
                    }
                }
                CheckLetters();
                break;

            case "Russian(Clone)":
                level = new bool[33];
                code = "RUS";
                for (int i = 0; i < 33; i++)
                {
                    if (PlayerPrefs.GetInt("RUS" + i.ToString()) == 0)
                    {
                        level[i] = false;
                    }
                    else
                    {
                        level[i] = true;
                    }
                }
                CheckLetters();
                break;

            case "Serbian(Clone)":
                level = new bool[30];
                code = "SER";

                for (int i = 0; i < 30; i++)
                {
                    if (PlayerPrefs.GetInt("SER" + i.ToString()) == 0)
                    {
                        level[i] = false;
                    }
                    else
                    {
                        level[i] = true;
                    }
                }
                CheckLetters();
                break;
        }
    }

    public void LetterUnlocked(int index)
    {
        level[index] = true;

        PlayerPrefs.SetInt(code + index.ToString(), 1);
        CheckLetters();
    }

    public void CheckLetters()
    {
        bool reset = false;
        for (int i = 0; i < level.Length; i++)
        {
            transform.GetChild(4).transform.GetChild(i).gameObject.GetComponent<Image>().color = new Color32(255, 190, 118, 0);
        }

        for (int i = 0; i < level.Length; i++)
        {
            if (level[i] == false)
            {
                highestLevel = i;
                //transform.GetChild(5).transform.GetChild(i).gameObject.GetComponent<Image>().color = new Color32(255, 190, 118, 80);
                break;
            }
            if (i == level.Length - 1)
            {
                for (int j = 0; j < 30; j++)
                {
                    Debug.Log(code);
                    PlayerPrefs.SetInt(code + j.ToString(), 0);
                }
                Assign();
            }
        }
    }
}