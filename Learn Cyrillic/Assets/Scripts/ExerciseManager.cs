using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExerciseManager : MonoBehaviour
{
    private bool[] unlocked;
    public string language;

    public string[,] questions;
    public string[,] answers;
    public string[,] type;

    public GameObject exerciseMenu;
    public int questionIndexA;
    public int questionIndexB;
    public GameObject menu;
    private Vector2 spawnPos = new Vector2(2000, 1280);

    private int level = 0;

    public string answer;
    public string input;

    public AudioSource click;

    public void Exercise()
    {
        click.Play();

        if (this.gameObject.name == "Bulgarian(Clone)")
        {
            unlocked = new bool[30];
            language = "BUL";

            for (int i = 0; i < 30; i++)
            {
                if (PlayerPrefs.GetInt("BUL" + i.ToString()) == 0)
                {
                    unlocked[i] = false;
                    if (i > 0)
                    {
                        level = i;
                    }
                    else
                    {
                        level = 0;
                    }
                    break;
                }
                else
                {
                    level = i;
                    unlocked[i] = true;
                }
            }

            BGQuestions();
        }

        if (this.gameObject.name == "Russian(Clone)")
        {
            unlocked = new bool[33];
            language = "RUS";

            Debug.Log(level);

            for (int i = 0; i < 33; i++)
            {
                if (PlayerPrefs.GetInt("RUS" + i.ToString()) == 0)
                {
                    unlocked[i] = false;
                    if (i > 0)
                    {
                        level = i;
                    }
                    else
                    {
                        level = 0;
                    }
                    break;
                }
                else
                {
                    level = i;
                    unlocked[i] = true;
                }
            }

            RUSQuestions();
        }

        if (this.gameObject.name == "Serbian(Clone)")
        {
            unlocked = new bool[30];
            language = "SER";

            for (int i = 0; i < 30; i++)
            {
                if (PlayerPrefs.GetInt("SER" + i.ToString()) == 0)
                {
                    unlocked[i] = false;
                    if (i > 0)
                    {
                        level = i;
                    }
                    else
                    {
                        level = 0;
                    }
                    break;
                }
                else
                {
                    level = i;
                    unlocked[i] = true;
                }
            }

            Debug.Log(level);

            SERQUESTION();
        }
    }

    private void BGQuestions()
    {
            questions = new string[30, 5];
            answers = new string[30, 5];
            type = new string[30, 5];

            type[0, 0] = "Which letter correspond in English";
            questions[0, 0] = "А";
            answers[0, 0] = "A";
            type[0, 1] = "Which letter correspond in English";
            questions[0, 1] = "a";
            answers[0, 1] = "a";
            type[0, 2] = "Which letter correspond in English";
            questions[0, 2] = "a";
            answers[0, 2] = "a";

            type[1, 0] = "Which letter correspond in English";
            questions[1, 0] = "Б";
            answers[1, 0] = "B";
            type[1, 1] = "Which letter correspond in English";
            questions[1, 1] = "б";
            answers[1, 1] = "b";
            type[1, 2] = "Type the following in English";
            questions[1, 2] = "Бaба";
            answers[1, 2] = "Baba";

            type[2, 0] = "Which letter corresponds in English";
            questions[2, 0] = "В";
            answers[2, 0] = "V";
            type[2, 1] = "Which letters correspond in English";
            questions[2, 1] = "Вв";
            answers[2, 1] = "Vv";
            type[2, 2] = "Type the following in English";
            questions[2, 2] = "АБВ";
            answers[2, 2] = "ABV";

            type[3, 0] = "Which letter corresponds in English";
            questions[3, 0] = "Г";
            answers[3, 0] = "G";
            type[3, 1] = "Which letters correspond in English";
            questions[3, 1] = "Гг";
            answers[3, 1] = "Gg";
            type[3, 2] = "Type the following in English";
            questions[3, 2] = "BVG";
            answers[3, 2] = "BVG";

            type[4, 0] = "Which letter corresponds in English";
            questions[4, 0] = "Д";
            answers[4, 0] = "D";
            type[4, 1] = "Which letters correspond in English";
            questions[4, 1] = "ДГБ";
            answers[4, 1] = "DGB";
            type[4, 2] = "Type the following in English";
            questions[4, 2] = "АВД";
            answers[4, 2] = "AVD";

            type[5, 0] = "If this word was spelled in English, what would it mean:";
            questions[5, 0] = "Бед";
            answers[5, 0] = "Bed";
            type[5, 1] = "If this word was spelled in English, what would it mean:";
            questions[5, 1] = "Баг";
            answers[5, 1] = "Bag";
            type[5, 2] = "Which letter corresponds in English";
            questions[5, 2] = "Ee";
            answers[5, 2] = "Ee";

            type[6, 0] = "Which letter corresponds in English";
            questions[6, 0] = "Ж";
            answers[6, 0] = "J";
            type[6, 1] = "If this word was spelled in English, what would it mean:";
            questions[6, 1] = "Бадж";
            answers[6, 1] = "Badge";
            type[6, 2] = "If this word was spelled in English, what would it mean:";
            questions[6, 2] = "Бег";
            answers[6, 2] = "Beg";

            type[7, 0] = "Type the following in English";
            questions[7, 0] = "Аве";
            answers[7, 0] = "Ave";
            type[7, 1] = "If this word was spelled in English, what would it mean:";
            questions[7, 1] = "Зигзаг";
            answers[7, 1] = "Zigzag";
            type[7, 2] = "Which letter corresponds in English";
            questions[7, 2] = "З";
            answers[7, 2] = "Z";

            type[8, 0] = "Which letter corresponds in English";
            questions[8, 0] = "И";
            answers[8, 0] = "I";
            type[8, 1] = "Which letters correspond in English";
            questions[8, 1] = "Ии";
            answers[8, 1] = "Ii";
            type[8, 2] = "If this word was spelled in English, what would it mean:";
            questions[8, 2] = "Гив";
            answers[8, 2] = "Give";

            type[9, 0] = "Type the following in English";
            questions[9, 0] = "Йe";
            answers[9, 0] = "Ye";
            type[9, 1] = "Type the following in English";
            questions[9, 1] = "Йо";
            answers[9, 1] = "Yo";
            type[9, 2] = "Type the following in English";
            questions[9, 2] = "Йа";
            answers[9, 2] = "Ya";

            type[10, 0] = "If this word was spelled in English, what would it mean:";
            questions[10, 0] = "Кайак";
            answers[10, 0] = "Kayak";
            type[10, 1] = "If this word was spelled in English, what would it mean:";
            questions[10, 1] = "Кау";
            answers[10, 1] = "Cow";
            type[10, 2] = "If this word was spelled in English, what would it mean:";
            questions[10, 2] = "Кий";
            answers[10, 2] = "Key";

            type[11, 0] = "Type the following in English";
            questions[11, 0] = "Лаг";
            answers[11, 0] = "Lag";
            type[11, 1] = "Which letters correspond in English";
            questions[11, 1] = "Лл";
            answers[11, 1] = "Ll";
            type[11, 2] = "If this word was spelled in English, what would it mean:";
            questions[11, 2] = "Ливид";
            answers[11, 2] = "Livid";

            type[12, 0] = "If this word was spelled in English, what would it mean:";
            questions[12, 0] = "Мол";
            answers[12, 0] = "Mall";
            type[12, 1] = "If this word was spelled in English, what would it mean:";
            questions[12, 1] = "Мад";
            answers[12, 1] = "Mad";
            type[12, 2] = "Which letters correspond to these in English";
            questions[12, 2] = "Mм";
            answers[12, 2] = "Mm";

            type[13, 0] = "Type the following in English";
            questions[13, 0] = "Нaйк";
            answers[13, 0] = "Nike";
            type[13, 1] = "Which letter corresponds to this one in English";
            questions[13, 1] = "Н";
            answers[13, 1] = "N";
            type[13, 2] = "Which letter corresponds to this one in English";
            questions[13, 2] = "н";
            answers[13, 2] = "n";

            type[14, 0] = "If this word was spelled in English, what would it mean:";
            questions[14, 0] = "Облигейт";
            answers[14, 0] = "Obligate";
            type[14, 1] = "If this word was spelled in English, what would it mean:";
            questions[14, 1] = "Олив";
            answers[14, 1] = "Olive";
            type[14, 2] = "If this word was spelled in English, what would it mean:";
            questions[14, 2] = "Он";
            answers[14, 2] = "On";

            type[15, 0] = "Which letter corresponds in English";
            questions[15, 0] = "П";
            answers[15, 0] = "P";
            type[15, 1] = "Which letters correspond in English";
            questions[15, 1] = "Пп";
            answers[15, 1] = "Pp";
            type[15, 2] = "If this word was spelled in English, what would it mean:";
            questions[15, 2] = "Пей";
            answers[15, 2] = "Pay";

            type[16, 0] = "Which letter corresponds in English";
            questions[16, 0] = "Р";
            answers[16, 0] = "R";
            type[16, 1] = "Which letters correspond in English";
            questions[16, 1] = "Рр";
            answers[16, 1] = "Rr";
            type[16, 2] = "If this word was spelled in English, what would it mean:";
            questions[16, 2] = "Рок";
            answers[16, 2] = "Rock";

            type[17, 0] = "If this word was spelled in English, what would it mean:";
            questions[17, 0] = "Сикс";
            answers[17, 0] = "Six";
            type[17, 1] = "Which letters correspond in English";
            questions[17, 1] = "Сс";
            answers[17, 1] = "Ss";
            type[17, 2] = "If this word was spelled in English, what would it mean:";
            questions[17, 2] = "Силикон";
            answers[17, 2] = "Silicon";

            type[18, 0] = "If this word was spelled in English, what would it mean:";
            questions[18, 0] = "Tоп";
            answers[18, 0] = "Top";
            type[18, 1] = "Which letters correspond in English";
            questions[18, 1] = "Тт";
            answers[18, 1] = "Tt";
            type[18, 2] = "If this word was spelled in English, what would it mean:";
            questions[18, 2] = "Тобако";
            answers[18, 2] = "Tobacco";

            type[19, 0] = "Which letter corresponds in English";
            questions[19, 0] = "У";
            answers[19, 0] = "U";
            type[19, 1] = "Which letters correspond in English";
            questions[19, 1] = "Уу";
            answers[19, 1] = "Uu";
            type[19, 2] = "If this word was spelled in English, what would it mean:";
            questions[19, 2] = "Ултра";
            answers[19, 2] = "Ultra";

            type[20, 0] = "Which letter corresponds in English";
            questions[20, 0] = "Ф";
            answers[20, 0] = "F";
            type[20, 1] = "Which letters correspond in English";
            questions[20, 1] = "Фф";
            answers[20, 1] = "Ff";
            type[20, 2] = "If this word was spelled in English, what would it mean:";
            questions[20, 2] = "Фарм";
            answers[20, 2] = "Farm";

            type[21, 0] = "If this word was spelled in English, what would it mean:";
            questions[21, 0] = "Хот";
            answers[21, 0] = "Hot";
            type[21, 1] = "If this word was spelled in English, what would it mean:";
            questions[21, 1] = "Хепи";
            answers[21, 1] = "Happy";
            type[21, 2] = "Type the following in English";
            questions[21, 2] = "Хх";
            answers[21, 2] = "Hh";

            type[22, 0] = "Which letter corresponds in English";
            questions[22, 0] = "Ц";
            answers[22, 0] = "C";
            type[22, 1] = "Which letters correspond in English";
            questions[22, 1] = "Цц";
            answers[22, 1] = "Cc";
            type[22, 2] = "If this word was spelled in English, what would it mean:";
            questions[22, 2] = "Цар";
            answers[22, 2] = "Tsar";

            type[23, 0] = "Which letters corresponds in English";
            questions[23, 0] = "Ч";
            answers[23, 0] = "Ch";
            type[23, 1] = "Which letters correspond in English";
            questions[23, 1] = "Чч";
            answers[23, 1] = "ChCh";
            type[23, 2] = "If this word was spelled in English, what would it mean:";
            questions[23, 2] = "Цунами";
            answers[23, 2] = "Tsunami";

            type[24, 0] = "Which letter corresponds in English";
            questions[24, 0] = "Ш";
            answers[24, 0] = "Sh";
            type[24, 1] = "Which letters correspond in English";
            questions[24, 1] = "Шш";
            answers[24, 1] = "SHsh";
            type[24, 2] = "If this word was spelled in English, what would it mean:";
            questions[24, 2] = "Шелф";
            answers[24, 2] = "Shelf";

            type[25, 0] = "Which letter corresponds in English";
            questions[25, 0] = "Щ";
            answers[25, 0] = "Sht";
            type[25, 1] = "Translate this word";
            questions[25, 1] = "Университет";
            answers[25, 1] = "University";
            type[25, 2] = "Translate this word";
            questions[25, 2] = "Амстердам";
            answers[25, 2] = "Amsterdam";

            type[26, 0] = "Which letter corresponds in English";
            questions[26, 0] = "Ъ";
            answers[26, 0] = "Y";
            type[26, 1] = "Translate this word";
            questions[26, 1] = "Москва";
            answers[26, 1] = "Moscow";
            type[26, 2] = "Type the following in English";
            questions[26, 2] = "Йорк";
            answers[26, 2] = "York";

            type[27, 0] = "Translate this word";
            questions[27, 0] = "Телефон";
            answers[27, 0] = "Telephone";
            type[27, 1] = "Translate this word";
            questions[27, 1] = "Лондон";
            answers[27, 1] = "London";
            type[27, 2] = "Translate this word";
            questions[27, 2] = "Мадрид";
            answers[27, 2] = "Madrid";

            type[28, 0] = "Which letters correspond in English";
            questions[28, 0] = "Ю";
            answers[28, 0] = "You";
            type[28, 1] = "Translate this word";
            questions[28, 1] = "Ню Йорк";
            answers[28, 1] = "New York";
            type[28, 2] = "If this word was typed in English, what would it mean:";
            questions[28, 2] = "Юнивърсити";
            answers[28, 2] = "Univercity";

            type[29, 0] = "Which letter corresponds in English";
            questions[29, 0] = "Я";
            answers[29, 0] = "Ya";
            type[29, 1] = "If this word was typed in English, what would it mean:";
            questions[29, 1] = "Ямайка";
            answers[29, 1] = "Jamaica";
            type[29, 2] = "Type the following in English";
            questions[29, 2] = "Азбука";
            answers[29, 2] = "Azbuka";


            foreach (GameObject ex in GameObject.FindGameObjectsWithTag("language"))
            {
                Destroy(ex);
            }

            GameObject exerciseObject = Instantiate(exerciseMenu, this.transform.parent);

            exerciseObject.transform.localPosition = new Vector2(1500,0);
            exerciseObject.transform.DOLocalMoveX(0, 2);

            menu.GetComponent<Button>().enabled = false;
            menu.GetComponent<Image>().enabled = false;
            this.transform.DOLocalMoveX(-2200, 2);

            if (level != 0)
            {
                questionIndexA = Random.Range(0, level-1);
                questionIndexB = Random.Range(0, 2);
            }
            else
            {
                questionIndexA = 0;
                questionIndexB = Random.Range(0, 2);
            }

            Debug.Log(level);

            exerciseObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = type[questionIndexA, questionIndexB];
            exerciseObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = questions[questionIndexA, questionIndexB];
            answer = answers[questionIndexA, questionIndexB];
    }

    private void RUSQuestions()
    {
            questions = new string[33, 5];
            answers = new string[33, 5];
            type = new string[33, 5];

            type[0, 0] = "Which letter correspond in English";
            questions[0, 0] = "А";
            answers[0, 0] = "A";
            type[0, 1] = "Which letter correspond in English";
            questions[0, 1] = "a";
            answers[0, 1] = "a";
            type[0, 2] = "Which letter correspond in English";
            questions[0, 2] = "a";
            answers[0, 2] = "a";

            type[1, 0] = "Which letter correspond in English";
            questions[1, 0] = "Б";
            answers[1, 0] = "B";
            type[1, 1] = "Which letter correspond in English";
            questions[1, 1] = "б";
            answers[1, 1] = "b";
            type[1, 2] = "Type the following in English";
            questions[1, 2] = "Бaба";
            answers[1, 2] = "Baba";

            type[2, 0] = "Which letter corresponds in English";
            questions[2, 0] = "В";
            answers[2, 0] = "V";
            type[2, 1] = "Which letters correspond in English";
            questions[2, 1] = "Вв";
            answers[2, 1] = "Vv";
            type[2, 2] = "Type the following in English";
            questions[2, 2] = "АБВ";
            answers[2, 2] = "ABV";

            type[3, 0] = "Which letter corresponds in English";
            questions[3, 0] = "Г";
            answers[3, 0] = "G";
            type[3, 1] = "Which letters correspond in English";
            questions[3, 1] = "Гг";
            answers[3, 1] = "Gg";
            type[3, 2] = "Type the following in English";
            questions[3, 2] = "BVG";
            answers[3, 2] = "BVG";

            type[4, 0] = "Which letter corresponds in English";
            questions[4, 0] = "Д";
            answers[4, 0] = "D";
            type[4, 1] = "Which letters correspond in English";
            questions[4, 1] = "ДГБ";
            answers[4, 1] = "DGB";
            type[4, 2] = "Type the following in English";
            questions[4, 2] = "АВД";
            answers[4, 2] = "AVD";

            type[5, 0] = "If this word was spelled in English, what would it mean:";
            questions[5, 0] = "Бед";
            answers[5, 0] = "Bed";
            type[5, 1] = "If this word was spelled in English, what would it mean:";
            questions[5, 1] = "Баг";
            answers[5, 1] = "Bag";
            type[5, 2] = "Which letter corresponds in English";
            questions[5, 2] = "Ee";
            answers[5, 2] = "Ee";

            type[6, 0] = "Which letters corresponds in Englis";
            questions[6, 0] = "ё";
            answers[6, 0] = "Yo";
            type[6, 1] = "If this word was spelled in English, what would it mean:";
            questions[6, 1] = "Баг";
            answers[6, 1] = "Bag";
            type[6, 2] = "Which letter corresponds in English";
            questions[6, 2] = "Ee";
            answers[6, 2] = "Ee";

            type[7, 0] = "Which letter corresponds in English";
            questions[7, 0] = "Ж";
            answers[7, 0] = "J";
            type[7, 1] = "If this word was spelled in English, what would it mean:";
            questions[7, 1] = "Бадж";
            answers[7, 1] = "Badge";
            type[7, 2] = "If this word was spelled in English, what would it mean:";
            questions[7, 2] = "Бег";
            answers[7, 2] = "Beg";

            type[8, 0] = "Type the following in English";
            questions[8, 0] = "Аве";
            answers[8, 0] = "Ave";
            type[8, 1] = "If this word was spelled in English, what would it mean:";
            questions[8, 1] = "Зигзаг";
            answers[8, 1] = "Zigzag";
            type[8, 2] = "Which letter corresponds in English";
            questions[8, 2] = "З";
            answers[8, 2] = "Z";

            type[9, 0] = "Which letter corresponds in English";
            questions[9, 0] = "И";
            answers[9, 0] = "I";
            type[9, 1] = "Which letters correspond in English";
            questions[9, 1] = "Ии";
            answers[9, 1] = "Ii";
            type[9, 2] = "If this word was spelled in English, what would it mean:";
            questions[9, 2] = "Гив";
            answers[9, 2] = "Give";

            type[10, 0] = "Type the following in English";
            questions[10, 0] = "Ей";
            answers[10, 0] = "Ey";
            type[10, 1] = "Type the following in English";
            questions[10, 1] = "Йо";
            answers[10, 1] = "Yo";
            type[10, 2] = "Type the following in English";
            questions[10, 2] = "Йа";
            answers[10, 2] = "Ya";

            type[11, 0] = "Type the following in English";
            questions[11, 0] = "KЖБ";
            answers[11, 0] = "KJB";
            type[11, 1] = "If this word was spelled in English, what would it mean:";
            questions[11, 1] = "Кау";
            answers[11, 1] = "Cow";
            type[11, 2] = "If this word was spelled in English, what would it mean:";
            questions[11, 2] = "Кий";
            answers[11, 2] = "Key";

            type[12, 0] = "Type the following in English";
            questions[12, 0] = "Лаг";
            answers[12, 0] = "Lag";
            type[12, 1] = "Which letters correspond in English";
            questions[12, 1] = "Лл";
            answers[12, 1] = "Ll";
            type[12, 2] = "If this word was spelled in English, what would it mean:";
            questions[12, 2] = "Ливид";
            answers[12, 2] = "Livid";

            type[13, 0] = "If this word was spelled in English, what would it mean:";
            questions[13, 0] = "Малл";
            answers[13, 0] = "Mall";
            type[13, 1] = "If this word was spelled in English, what would it mean:";
            questions[13, 1] = "Мад";
            answers[13, 1] = "Mad";
            type[13, 2] = "Which letters correspond to these in English";
            questions[13, 2] = "Mм";
            answers[13, 2] = "Mm";

            type[14, 0] = "Type the following in English";
            questions[14, 0] = "Нaйк";
            answers[14, 0] = "Nike";
            type[14, 1] = "Which letter corresponds to this one in English";
            questions[14, 1] = "Н";
            answers[14, 1] = "N";
            type[14, 2] = "Which letter corresponds to this one in English";
            questions[14, 2] = "н";
            answers[14, 2] = "n";

            type[15, 0] = "If this word was spelled in English, what would it mean:";
            questions[15, 0] = "Облигейт";
            answers[15, 0] = "Obligate";
            type[15, 1] = "If this word was spelled in English, what would it mean:";
            questions[15, 1] = "Олив";
            answers[15, 1] = "Olive";
            type[15, 2] = "If this word was spelled in English, what would it mean:";
            questions[15, 2] = "Он";
            answers[15, 2] = "On";

            type[16, 0] = "Which letter corresponds in English";
            questions[16, 0] = "П";
            answers[16, 0] = "P";
            type[16, 1] = "Which letters correspond in English";
            questions[16, 1] = "Пп";
            answers[16, 1] = "Pp";
            type[16, 2] = "If this word was spelled in English, what would it mean:";
            questions[16, 2] = "Пей";
            answers[16, 2] = "Pay";

            type[17, 0] = "Which letter corresponds in English";
            questions[17, 0] = "Р";
            answers[17, 0] = "R";
            type[17, 1] = "Which letters correspond in English";
            questions[17, 1] = "Рр";
            answers[17, 1] = "Rr";
            type[17, 2] = "If this word was spelled in English, what would it mean:";
            questions[17, 2] = "Рок";
            answers[17, 2] = "Rock";

            type[18, 0] = "If this word was spelled in English, what would it mean:";
            questions[18, 0] = "Сикс";
            answers[18, 0] = "Six";
            type[18, 1] = "Which letters correspond in English";
            questions[18, 1] = "Сс";
            answers[18, 1] = "Ss";
            type[18, 2] = "If this word was spelled in English, what would it mean:";
            questions[18, 2] = "Силикон";
            answers[18, 2] = "Silicon";

            type[19, 0] = "If this word was spelled in English, what would it mean:";
            questions[19, 0] = "Тop";
            answers[19, 0] = "Tоп";
            type[19, 1] = "Which letters correspond in English";
            questions[19, 1] = "Тт";
            answers[19, 1] = "Tt";
            type[19, 2] = "If this word was spelled in English, what would it mean:";
            questions[19, 2] = "Tobacco";
            answers[19, 2] = "Тобако";

            type[20, 0] = "Which letter corresponds in English";
            questions[20, 0] = "У";
            answers[20, 0] = "U";
            type[20, 1] = "Which letters correspond in English";
            questions[20, 1] = "Уу";
            answers[20, 1] = "Uu";
            type[20, 2] = "If this word was spelled in English, what would it mean:";
            questions[20, 2] = "Ултра";
            answers[20, 2] = "Ultra";

            type[21, 0] = "Which letter corresponds in English";
            questions[21, 0] = "Ф";
            answers[21, 0] = "F";
            type[21, 1] = "Which letters correspond in English";
            questions[21, 1] = "Фф";
            answers[21, 1] = "Ff";
            type[21, 2] = "If this word was spelled in English, what would it mean:";
            questions[21, 2] = "Фарм";
            answers[21, 2] = "Farm";

            type[22, 0] = "If this word was spelled in English, what would it mean:";
            questions[22, 0] = "Хот";
            answers[22, 0] = "Hot";
            type[22, 1] = "If this word was spelled in English, what would it mean:";
            questions[22, 1] = "Хепи";
            answers[22, 1] = "Happy";
            type[22, 2] = "Type the following in English";
            questions[22, 2] = "Хх";
            answers[22, 2] = "Hh";

            type[23, 0] = "Which letter corresponds in English";
            questions[23, 0] = "Ц";
            answers[23, 0] = "C";
            type[23, 1] = "Which letters correspond in English";
            questions[23, 1] = "Цц";
            answers[23, 1] = "Cc";
            type[23, 2] = "If this word was spelled in English, what would it mean:";
            questions[23, 2] = "Цар";
            answers[23, 2] = "Tsar";

            type[24, 0] = "Which letters corresponds in English";
            questions[24, 0] = "Ч";
            answers[24, 0] = "Ch";
            type[24, 1] = "Which letters correspond in English";
            questions[24, 1] = "Чч";
            answers[24, 1] = "ChCh";
            type[24, 2] = "If this word was spelled in English, what would it mean:";
            questions[24, 2] = "Цунами";
            answers[24, 2] = "Tsunami";

            type[25, 0] = "Which letter corresponds in English";
            questions[25, 0] = "Ш";
            answers[25, 0] = "Sh";
            type[25, 1] = "Which letters correspond in English";
            questions[25, 1] = "Шш";
            answers[25, 1] = "SHsh";
            type[25, 2] = "If this word was spelled in English, what would it mean:";
            questions[25, 2] = "Шелф";
            answers[25, 2] = "Shelf";

            type[26, 0] = "Which letter corresponds in English";
            questions[26, 0] = "Щ";
            answers[26, 0] = "Sht";
            type[26, 1] = "Translate this word";
            questions[26, 1] = "Университет";
            answers[26, 1] = "University";
            type[26, 2] = "Translate this word";
            questions[26, 2] = "Амстердам";
            answers[26, 2] = "Amsterdam";

            type[27, 0] = "Which letter corresponds in English";
            questions[27, 0] = "Ж";
            answers[27, 0] = "J";
            type[27, 1] = "Translate this word";
            questions[27, 1] = "Москва";
            answers[27, 1] = "Moscow";
            type[27, 2] = "Type the following in English";
            questions[27, 2] = "Йорк";
            answers[27, 2] = "York";

            type[28, 0] = "Translate this word";
            questions[28, 0] = "Телефон";
            answers[28, 0] = "Telephone";
            type[28, 1] = "Translate this word";
            questions[28, 1] = "Лондон";
            answers[28, 1] = "London";
            type[28, 2] = "Translate this word";
            questions[28, 2] = "Мадрид";
            answers[28, 2] = "Madrid";

            type[29, 0] = "Translate this word";
            questions[29, 0] = "Берлин";
            answers[29, 0] = "Berlin";
            type[29, 1] = "Translate this word";
            questions[29, 1] = "Майами";
            answers[29, 1] = "Miami";
            type[29, 2] = "Translate this word";
            questions[29, 2] = "Мадагаскар";
            answers[29, 2] = "Madagascar";

            type[30, 0] = "If this word was written in English, what would it mean?";
            questions[30, 0] = "электрисити";
            answers[30, 0] = "Electricity";
            type[30, 1] = "Translate this word";
            questions[30, 1] = "Париж";
            answers[30, 1] = "Paris";
            type[30, 2] = "Translate this word";
            questions[30, 2] = "Лос-Анджелес";
            answers[30, 2] = "Los Angeles";

            type[31, 0] = "Which letters correspond in English";
            questions[31, 0] = "Ю";
            answers[31, 0] = "You";
            type[31, 1] = "Translate this word";
            questions[31, 1] = "Нью-Йорк";
            answers[31, 1] = "New York";
            type[31, 2] = "Translate this word";
            questions[31, 2] = "Университет";
            answers[31, 2] = "University";

            type[32, 0] = "Which letter corresponds in English";
            questions[32, 0] = "Я";
            answers[32, 0] = "Ya";
            type[32, 1] = "If this word was typed in English, what would it mean:";
            questions[32, 1] = "Ямайка";
            answers[32, 1] = "Jamaica";
            type[32, 2] = "Translate this word";
            questions[32, 2] = "Алфавит";
            answers[32, 2] = "Alphabet";


            foreach (GameObject ex in GameObject.FindGameObjectsWithTag("language"))
            {
                Destroy(ex);
            }

            GameObject exerciseObject = Instantiate(exerciseMenu, this.transform.parent);

            exerciseObject.transform.localPosition = new Vector2(1500, 0);
            exerciseObject.transform.DOLocalMoveX(0, 2);

            menu.GetComponent<Button>().enabled = false;
            menu.GetComponent<Image>().enabled = false;
            this.transform.DOLocalMoveX(-2200, 2);

            if (level != 0)
            {
                questionIndexA = Random.Range(0, level-1);
                questionIndexB = Random.Range(0, 2);
            }
            else
            {
                questionIndexA = 0;
                questionIndexB = Random.Range(0, 2);
            }

            Debug.Log(level);

            exerciseObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = type[questionIndexA, questionIndexB];
            exerciseObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = questions[questionIndexA, questionIndexB];
            answer = answers[questionIndexA, questionIndexB];
    }

    private void SERQUESTION()
    {
            questions = new string[30, 5];
            answers = new string[30, 5];
            type = new string[30, 5];

            type[0, 0] = "Which letter correspond in English";
            questions[0, 0] = "А";
            answers[0, 0] = "A";
            type[0, 1] = "Which letter correspond in English";
            questions[0, 1] = "a";
            answers[0, 1] = "a";
            type[0, 2] = "Which letter correspond in English";
            questions[0, 2] = "a";
            answers[0, 2] = "a";

            type[1, 0] = "Which letter correspond in English";
            questions[1, 0] = "Б";
            answers[1, 0] = "B";
            type[1, 1] = "Which letter correspond in English";
            questions[1, 1] = "б";
            answers[1, 1] = "b";
            type[1, 2] = "Type the following in English";
            questions[1, 2] = "Бaба";
            answers[1, 2] = "Baba";

            type[2, 0] = "Which letter corresponds in English";
            questions[2, 0] = "В";
            answers[2, 0] = "V";
            type[2, 1] = "Which letters correspond in English";
            questions[2, 1] = "Вв";
            answers[2, 1] = "Vv";
            type[2, 2] = "Type the following in English";
            questions[2, 2] = "АБВ";
            answers[2, 2] = "ABV";

            type[3, 0] = "Which letter corresponds in English";
            questions[3, 0] = "Г";
            answers[3, 0] = "G";
            type[3, 1] = "Which letters correspond in English";
            questions[3, 1] = "Гг";
            answers[3, 1] = "Gg";
            type[3, 2] = "Type the following in English";
            questions[3, 2] = "BVG";
            answers[3, 2] = "BVG";

            type[4, 0] = "Which letter corresponds in English";
            questions[4, 0] = "Д";
            answers[4, 0] = "D";
            type[4, 1] = "Which letters correspond in English";
            questions[4, 1] = "ДГБ";
            answers[4, 1] = "DGB";
            type[4, 2] = "Type the following in English";
            questions[4, 2] = "АВД";
            answers[4, 2] = "AVD";

            type[5, 0] = "If this word was spelled in English, what would it mean:";
            questions[5, 0] = "Бед";
            answers[5, 0] = "Bed";
            type[5, 1] = "If this word was spelled in English, what would it mean:";
            questions[5, 1] = "Баг";
            answers[5, 1] = "Bag";
            type[5, 2] = "Which letters correspond to this one in English";
            questions[5, 2] = "Ђ";
            answers[5, 2] = "Dj";

            type[6, 0] = "Which letter corresponds in English";
            questions[6, 0] = "E";
            answers[6, 0] = "E";
            type[6, 1] = "If this word was spelled in English, what would it mean:";
            questions[6, 1] = "Бађ ";
            answers[6, 1] = "Badge";
            type[6, 2] = "If this word was spelled in English, what would it mean:";
            questions[6, 2] = "Бег";
            answers[6, 2] = "Beg";

            type[7, 0] = "Type the following in English";
            questions[7, 0] = "Аве";
            answers[7, 0] = "Ave";
            type[7, 1] = "Which letters correspond in English";
            questions[7, 1] = "Жж";
            answers[7, 1] = "Jj";
            type[7, 2] = "Which letter corresponds in English";
            questions[7, 2] = "АБЖ";
            answers[7, 2] = "ABJ";

            type[8, 0] = "Which letter corresponds in English";
            questions[8, 0] = "З";
            answers[8, 0] = "Z";
            type[8, 1] = "Which letters correspond in English";
            questions[9, 1] = "ЗАК";
            answers[9, 1] = "ZAK";
            type[8, 2] = "Which letters correspond in English";
            questions[8, 2] = "ЗБВ";
            answers[8, 2] = "ZBV";

            type[9, 0] = "Which letter corresponds in English";
            questions[9, 0] = "И";
            answers[9, 0] = "I";
            type[9, 1] = "Which letters correspond in English";
            questions[9, 1] = "Зигзаг";
            answers[9, 1] = "Zigzag";
            type[9, 2] = "If this word was spelled in English, what would it mean:";
            questions[9, 2] = "Гив";
            answers[9, 2] = "Give";

            type[10, 0] = "Type the following in English";
            questions[10, 0] = "Je";
            answers[10, 0] = "Ye";
            type[10, 1] = "Type the following in English";
            questions[10, 1] = "Jo";
            answers[10, 1] = "Yo";
            type[10, 2] = "Type the following in English";
            questions[10, 2] = "Jа";
            answers[10, 2] = "Ya";

            type[11, 0] = "If this word was spelled in English, what would it mean:";
            questions[11, 0] = "Кајак";
            answers[11, 0] = "Kayak";
            type[11, 1] = "If this word was spelled in English, what would it mean:";
            questions[11, 1] = "Кау";
            answers[11, 1] = "Cow";
            type[11, 2] = "If this word was spelled in English, what would it mean:";
            questions[11, 2] = "Киj";
            answers[11, 2] = "Key";

            type[12, 0] = "Type the following in English";
            questions[12, 0] = "Лаг";
            answers[12, 0] = "Lag";
            type[12, 1] = "Which letters correspond in English";
            questions[12, 1] = "Лл";
            answers[12, 1] = "Ll";
            type[12, 2] = "If this word was spelled in English, what would it mean:";
            questions[12, 2] = "Ливид";
            answers[12, 2] = "Livid";

            type[13, 0] = "Type the following in English";
            questions[13, 0] = "Љ";
            answers[13, 0] = "Ly";
            type[13, 1] = "If this word was spelled in English, what would it mean:";
            questions[13, 1] = "Лад";
            answers[13, 1] = "Lad";
            type[13, 2] = "Which letters correspond to these in English";
            questions[13, 2] = "Љa";
            answers[13, 2] = "Lya";

            type[14, 0] = "Type the following in English";
            questions[14, 0] = "M";
            answers[14, 0] = "M";
            type[14, 1] = "If this word was spelled in English, what would it mean:";
            questions[14, 1] = "Мад";
            answers[14, 1] = "Mad";
            type[14, 2] = "Which letters correspond to these in English";
            questions[14, 2] = "Mм";
            answers[14, 2] = "Mm";

            type[15, 0] = "Type the following in English";
            questions[15, 0] = "Нике";
            answers[15, 0] = "Nike";
            type[15, 1] = "Which letter corresponds to this one in English";
            questions[15, 1] = "Н";
            answers[15, 1] = "N";
            type[15, 2] = "Which letter corresponds to this one in English";
            questions[15, 2] = "н";
            answers[15, 2] = "n";

            type[16, 0] = "Which letters correspond to this one in English";
            questions[16, 0] = "Њ";
            answers[16, 0] = "Ny";
            type[16, 1] = "Type the following in English";
            questions[16, 1] = "НБА";
            answers[16, 1] = "NBA";
            type[16, 2] = "Type the following in English";
            questions[16, 2] = "НБА";
            answers[16, 2] = "NBA";

            type[17, 0] = "If this word was spelled in English, what would it mean:";
            questions[17, 0] = "Oблигате";
            answers[17, 0] = "Obligate";
            type[17, 1] = "If this word was spelled in English, what would it mean:";
            questions[17, 1] = "Олив";
            answers[17, 1] = "Olive";
            type[17, 2] = "If this word was spelled in English, what would it mean:";
            questions[17, 2] = "Он";
            answers[17, 2] = "On";

            type[18, 0] = "Which letter corresponds in English";
            questions[18, 0] = "П";
            answers[18, 0] = "P";
            type[18, 1] = "Which letters correspond in English";
            questions[18, 1] = "Пп";
            answers[18, 1] = "Pp";
            type[18, 2] = "If this word was spelled in English, what would it mean:";
            questions[18, 2] = "Пеj";
            answers[18, 2] = "Pay";

            type[19, 0] = "Which letter corresponds in English";
            questions[19, 0] = "Р";
            answers[19, 0] = "R";
            type[19, 1] = "Which letters correspond in English";
            questions[19, 1] = "Рр";
            answers[19, 1] = "Rr";
            type[19, 2] = "If this word was spelled in English, what would it mean:";
            questions[19, 2] = "Рок";
            answers[19, 2] = "Rock";

            type[20, 0] = "If this word was spelled in English, what would it mean:";
            questions[20, 0] = "Сикс";
            answers[20, 0] = "Six";
            type[20, 1] = "Which letters correspond in English";
            questions[20, 1] = "Сс";
            answers[20, 1] = "Ss";
            type[20, 2] = "If this word was spelled in English, what would it mean:";
            questions[20, 2] = "Силикон";
            answers[20, 2] = "Silicon";

            type[21, 0] = "If this word was spelled in English, what would it mean:";
            questions[21, 0] = "Тop";
            answers[21, 0] = "Tоп";
            type[21, 1] = "Which letters correspond in English";
            questions[21, 1] = "Тт";
            answers[21, 1] = "Tt";
            type[21, 2] = "If this word was spelled in English, what would it mean:";
            questions[21, 2] = "Tobacco";
            answers[21, 2] = "Тобако";

            type[22, 0] = "If this word was spelled in English, what would it mean:";
            questions[22, 0] = "Ћao";
            answers[22, 0] = "Ciao";
            type[22, 1] = "Which letters correspond in English";
            questions[22, 1] = "Ћ";
            answers[22, 1] = "Tshe";
            type[22, 2] = "If this word was spelled in English, what would it mean:";
            questions[22, 2] = "Ћоколат";
            answers[22, 2] = "Chocolate";

            type[23, 0] = "Which letter corresponds in English";
            questions[23, 0] = "У";
            answers[23, 0] = "U";
            type[23, 1] = "Which letters correspond in English";
            questions[23, 1] = "Уу";
            answers[23, 1] = "Uu";
            type[23, 2] = "If this word was spelled in English, what would it mean:";
            questions[23, 2] = "Ултра";
            answers[23, 2] = "Ultra";

            type[24, 0] = "Which letter corresponds in English";
            questions[24, 0] = "Ф";
            answers[24, 0] = "F";
            type[24, 1] = "Which letters correspond in English";
            questions[24, 1] = "Фф";
            answers[24, 1] = "Ff";
            type[24, 2] = "If this word was spelled in English, what would it mean:";
            questions[24, 2] = "Фарм";
            answers[24, 2] = "Farm";

            type[25, 0] = "If this word was spelled in English, what would it mean:";
            questions[25, 0] = "Хот";
            answers[25, 0] = "Hot";
            type[25, 1] = "If this word was spelled in English, what would it mean:";
            questions[25, 1] = "Хепи";
            answers[25, 1] = "Happy";
            type[25, 2] = "Type the following in English";
            questions[25, 2] = "Хх";
            answers[25, 2] = "Hh";

            type[26, 0] = "Which letter corresponds in English";
            questions[26, 0] = "Ц";
            answers[26, 0] = "Ts";
            type[26, 1] = "Which letters correspond in English";
            questions[26, 1] = "Цц";
            answers[26, 1] = "Cc";
            type[26, 2] = "If this word was spelled in English, what would it mean:";
            questions[26, 2] = "Цар";
            answers[26, 2] = "Tsar";

            type[27, 0] = "Which letters corresponds in English";
            questions[27, 0] = "Ч";
            answers[27, 0] = "Ch";
            type[27, 1] = "Which letters correspond in English";
            questions[27, 1] = "Чч";
            answers[27, 1] = "ChCh";
            type[27, 1] = "If this word was spelled in English, what would it mean:";
            questions[27, 2] = "Цунами";
            answers[27, 2] = "Tsunami";

            type[28, 0] = "Which letters corresponds in English";
            questions[28, 0] = "Џ";
            answers[28, 0] = "Dzhe";
            type[28, 1] = "Which letters correspond in English";
            questions[28, 1] = "Џa";
            answers[28, 1] = "Dzha";
            type[28, 1] = "If this word was spelled in English, what would it mean:";
            questions[28, 2] = "Џанго";
            answers[28, 2] = "Django";

            type[29, 0] = "Which letter corresponds in English";
            questions[29, 0] = "Ш";
            answers[29, 0] = "Sh";
            type[29, 1] = "Which letters correspond in English";
            questions[29, 1] = "Шш";
            answers[29, 1] = "SHsh";
            type[29, 2] = "If this word was spelled in English, what would it mean:";
            questions[29, 2] = "Шелф";
            answers[29, 2] = "Shelf";

            foreach (GameObject ex in GameObject.FindGameObjectsWithTag("language"))
            {
                Destroy(ex);
            }

            GameObject exerciseObject = Instantiate(exerciseMenu, this.transform.parent);

            exerciseObject.transform.localPosition = new Vector2(1500, 0);
            exerciseObject.transform.DOLocalMoveX(0, 2);

            menu.GetComponent<Button>().enabled = false;
            menu.GetComponent<Image>().enabled = false;
            this.transform.DOLocalMoveX(-2200, 2);

            if (level != 0)
            {
                questionIndexA = Random.Range(0, level-1);
                questionIndexB = Random.Range(0, 2);
            }
            else
            {
                questionIndexA = 0;
                questionIndexB = Random.Range(0, 2);
            }
            Debug.Log(questionIndexA);

            exerciseObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = type[questionIndexA, questionIndexB];
            exerciseObject.transform.GetChild(1).gameObject.GetComponent<Text>().text = questions[questionIndexA, questionIndexB];
            answer = answers[questionIndexA, questionIndexB];
    }
    
    private void Update()
        {
            if (GameObject.FindGameObjectWithTag("input") != null)
            {
                input = GameObject.FindGameObjectWithTag("input").GetComponent<Text>().text;
            }
        }
    }