using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine.UI;

public class LetterScript : MonoBehaviour
{
    public AudioSource click;
    private string letter;
    public GameObject letterPrefab;
    public GameObject examplePrefab;

    private Vector2 spawnPos = new Vector2(2000, 1280);

    private GameObject menu;
    private GameObject letterObject;
    public ProgressManager progressManager;

    private AudioSource audioLetter;
    private AudioSource audioWord;

    public AudioClip[] audioClipLetter = new AudioClip[33];
    public AudioClip[] audioClipWord = new AudioClip[99];

    public void SelectLetter()
    {
        click.Play();
        letter = EventSystem.current.currentSelectedGameObject.name;
        menu = GameObject.FindGameObjectWithTag("mainMenu");

        InstantiateLetter();
        int random = Random.Range(0, 2);

        switch (letter)
        {
            case "BG0":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Аа";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Aa";
                audioLetter.clip = audioClipLetter[0];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[А]удио";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[A]udio";
                        audioWord.clip = audioClipWord[0];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[А]тлас";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[A]tlas";
                        audioWord.clip = audioClipWord[1];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[А]виатор";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[A]viator";
                        audioWord.clip = audioClipWord[2];
                        break;
                }
                break;

            case "BG1":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Бб";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Bb";
                audioLetter.clip = audioClipLetter[1];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Б]иология";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[B]iology";
                        audioWord.clip = audioClipWord[3];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Б]иография";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[B]iography";
                        audioWord.clip = audioClipWord[4];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Б]юро";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[B]ureau";
                        audioWord.clip = audioClipWord[5];
                        break;
                }
                break;

            case "BG2":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Вв";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Vv";
                audioLetter.clip = audioClipLetter[2];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[В]иктор";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[V]ictor";
                        audioWord.clip = audioClipWord[6];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[В]арна";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[V]arna";
                        audioWord.clip = audioClipWord[7];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[В]ариант";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[V]ariant";
                        audioWord.clip = audioClipWord[8];
                        break;
                }
                break;

            case "BG3":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Гг";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Gg";
                audioLetter.clip = audioClipLetter[3];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Г]ном";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[G]nome";
                        audioWord.clip = audioClipWord[9];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Г]еография";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[G]eography";
                        audioWord.clip = audioClipWord[10];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Г]облин";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[G]oblin";
                        audioWord.clip = audioClipWord[11];
                        break;
                }
                break;

            case "BG4":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Дд";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Dd";
                audioLetter.clip = audioClipLetter[4];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Д]етектив";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[D]etective";
                        audioWord.clip = audioClipWord[12];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Д]епартамент";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[D]epartment";
                        audioWord.clip = audioClipWord[13];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Д]окумент";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[D]ocument";
                        audioWord.clip = audioClipWord[14];
                        break;
                }
                break;

            case "BG5":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Ее";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ee";
                audioLetter.clip = audioClipLetter[5];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Е]кспертиза";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[E]xpertise";
                        audioWord.clip = audioClipWord[15];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Е]ксплозия";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[E]xplosion";
                        audioWord.clip = audioClipWord[16];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Е]вропа";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Е]urope";
                        audioWord.clip = audioClipWord[17];
                        break;
                }
                break;

            case "BG6":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Жж";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Zh";
                audioLetter.clip = audioClipLetter[6];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ж]";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Lei[s]ure";
                        audioWord.clip = audioClipWord[18];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ж]";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Trea[s]ure";
                        audioWord.clip = audioClipWord[19];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ж]окей";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[J]ockey";
                        audioWord.clip = audioClipWord[20];
                        break;
                }

                break;

            case "BG7":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Зз";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Zz";
                audioLetter.clip = audioClipLetter[7];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[З]ебра";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Z]ebra";
                        audioWord.clip = audioClipWord[21];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[З]аир";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Z]aire";
                        audioWord.clip = audioClipWord[22];

                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[З]оология";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Z]oology";
                        audioWord.clip = audioClipWord[23];
                        break;
                }
                break;

            case "BG8":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Ии";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ii";
                audioLetter.clip = audioClipLetter[8];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[И]талия";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[I]taly";
                        audioWord.clip = audioClipWord[24];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[И]нтервю";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[I]nterview";
                        audioWord.clip = audioClipWord[25];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[И]нформация";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[I]nformation";
                        audioWord.clip = audioClipWord[26];
                        break;
                }
                break;

            case "BG9":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Йй";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Yy";
                audioLetter.clip = audioClipLetter[9];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Й]ога";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Y]oga";
                        audioWord.clip = audioClipWord[27];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Й]елоу";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Y]ellow";
                        audioWord.clip = audioClipWord[28];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Плe[й]ер";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Pla[y]er";
                        audioWord.clip = audioClipWord[29];
                        break;
                }
                break;
            case "BG10":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Kк";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Kk";
                audioLetter.clip = audioClipLetter[10];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[К]омпютър";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[C]omputer";
                        audioWord.clip = audioClipWord[30];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[K]еш";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[C]ash";
                        audioWord.clip = audioClipWord[31];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[К]афе";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[C]offee";
                        audioWord.clip = audioClipWord[32];
                        break;
                }
                break;
            case "BG11":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Лл";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ll";
                audioLetter.clip = audioClipLetter[11];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Л]имон";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[L]emon";
                        audioWord.clip = audioClipWord[33];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Л]айм";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[L]ime";
                        audioWord.clip = audioClipWord[34];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[L]ux";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Л]укс";
                        audioWord.clip = audioClipWord[35];
                        break;
                }
                break;
            case "BG12":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Мм";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Mm";
                audioLetter.clip = audioClipLetter[12];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[М]ерси";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[M]erci";
                        audioWord.clip = audioClipWord[36];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[М]андат";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[M]andate";
                        audioWord.clip = audioClipWord[37];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[М]акс";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[M]ax";
                        audioWord.clip = audioClipWord[38];
                        break;
                }
                break;
            case "BG13":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Нн";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Nn";
                audioLetter.clip = audioClipLetter[13];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Н]е";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[N]o";
                        audioWord.clip = audioClipWord[39];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Н]епал";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[N]epal";
                        audioWord.clip = audioClipWord[40];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Н]еутрон";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[N]eutron";
                        audioWord.clip = audioClipWord[41];
                        break;
                }
                break;
            case "BG14":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Оо";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Oо";
                audioLetter.clip = audioClipLetter[14];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[О]ктопод";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[O]ctopus";
                        audioWord.clip = audioClipWord[42];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[О]ртографичен";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[O]rtographic";
                        audioWord.clip = audioClipWord[43];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[О]бект";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[O]bject";
                        audioWord.clip = audioClipWord[44];
                        break;
                }
                break;

            case "BG15":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Пп";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Pp";
                audioLetter.clip = audioClipLetter[15];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[П]анда";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[P]anda";
                        audioWord.clip = audioClipWord[45];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[П]анда";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[P]anda";
                        audioWord.clip = audioClipWord[46];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[П]ринтер";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[P]rinter";
                        audioWord.clip = audioClipWord[47];
                        break;
                }
                break;

            case "BG16":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Рр";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Rr";
                audioLetter.clip = audioClipLetter[16];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Р]ом";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[R]um";
                        audioWord.clip = audioClipWord[48];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Р]им";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[R]ome";
                        audioWord.clip = audioClipWord[49];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Р]еален";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[R]eal";
                        audioWord.clip = audioClipWord[50];
                        break;
                }
                break;

            case "BG17":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Сс";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ss";
                audioLetter.clip = audioClipLetter[17];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[С]алса";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[S]alsa";
                        audioWord.clip = audioClipWord[51];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[С]ин";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[S]on";
                        audioWord.clip = audioClipWord[52];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[С]алса";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[S]alsa";
                        audioWord.clip = audioClipWord[53];
                        break;
                }
                break;

            case "BG18":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Tт";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Тt";
                audioLetter.clip = audioClipLetter[18];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Т]рактор";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[T]ractor";
                        audioWord.clip = audioClipWord[54];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Т]ест";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[T]est";
                        audioWord.clip = audioClipWord[55];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Т]ехнология";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[T]echnology";
                        audioWord.clip = audioClipWord[56];
                        break;
                }
                break;

            case "BG19":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Уу";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Uu";
                audioLetter.clip = audioClipLetter[19];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[У]лтимат";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[U]ltmate";
                        audioWord.clip = audioClipWord[57];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[У]лтра";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[U]ltra";
                        audioWord.clip = audioClipWord[58];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[У]ебсайт";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[W]ebsite";
                        audioWord.clip = audioClipWord[59];
                        break;
                }
                break;

            case "BG20":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Фф";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ff";
                audioLetter.clip = audioClipLetter[20];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ф]ерма";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[F]arm";
                        audioWord.clip = audioClipWord[60];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ф]акт";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[F]act";
                        audioWord.clip = audioClipWord[61];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ф]утбол";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[F]ootball";
                        audioWord.clip = audioClipWord[62];
                        break;
                }
                break;

            case "BG21":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Хх";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Hh";
                audioLetter.clip = audioClipLetter[21];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Х]ипер";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[H]yper";
                        audioWord.clip = audioClipWord[63];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Х]eтрик";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[H]ead trick";
                        audioWord.clip = audioClipWord[64];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Х]авана";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[H]avana";
                        audioWord.clip = audioClipWord[65];
                        break;
                }
                break;

            case "BG22":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Цц";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ts";
                audioLetter.clip = audioClipLetter[22];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ц]ар";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[T]sar";
                        audioWord.clip = audioClipWord[66];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ц]унами";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ts]unami";
                        audioWord.clip = audioClipWord[67];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ц]елзий";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[C]elsius";
                        audioWord.clip = audioClipWord[68];
                        break;
                }
                break;

            case "BG23":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Чч";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ch";
                audioLetter.clip = audioClipLetter[23];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ч]ереша";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ch]erry";
                        audioWord.clip = audioClipWord[69];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ч]арлз";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ch]arles";
                        audioWord.clip = audioClipWord[70];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ч]икаго";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ch]icago";
                        audioWord.clip = audioClipWord[71];
                        break;
                }
                break;

            case "BG24":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Шш";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Sh";
                audioLetter.clip = audioClipLetter[24];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ш]ампоан";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Sh]ampoo";
                        audioWord.clip = audioClipWord[72];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ш]оу";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Sh]ow";
                        audioWord.clip = audioClipWord[73];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ш]ериф";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Sh]erif";
                        audioWord.clip = audioClipWord[74];
                        break;
                }
                break;

            case "BG25":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Щщ";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Sht";
                audioLetter.clip = audioClipLetter[25];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Сма[щ]";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Sma[shed]";
                        audioWord.clip = audioClipWord[75];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Щ]ъркел";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Stork";
                        audioWord.clip = audioClipWord[76];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Щ]астие";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Happiness";
                        audioWord.clip = audioClipWord[77];
                        break;
                }
                break;

            case "BG26":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Ъъ";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Uu";
                audioLetter.clip = audioClipLetter[26];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ъ]пдейт";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[U]pdate";
                        audioWord.clip = audioClipWord[78];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ъ]гъл";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Angle";
                        audioWord.clip = audioClipWord[79];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ъ]ндърграунд";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[U]nderground";
                        audioWord.clip = audioClipWord[80];
                        break;
                }
                break;

            case "BG27":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "ь";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Y";
                audioLetter.clip = audioClipLetter[27];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Пет[ьо]";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Pet[yo]";
                        audioWord.clip = audioClipWord[81];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Пет[ьо]";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Pet[yo]";
                        audioWord.clip = audioClipWord[82];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[ь]";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Y]outh";
                        audioWord.clip = audioClipWord[83];
                        break;
                }
                break;

            case "BG28":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Юю";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "You";
                audioLetter.clip = audioClipLetter[28];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ю]ли";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "July";
                        audioWord.clip = audioClipWord[84];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ю]нивърсити";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Univesity";
                        audioWord.clip = audioClipWord[85];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ю]гославия";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Yu]goslavia";
                        audioWord.clip = audioClipWord[86];
                        break;
                }
                break;

            case "BG29":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Яя";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Yа";
                audioLetter.clip = audioClipLetter[29];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Я]хта";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ya]cht";
                        audioWord.clip = audioClipWord[87];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Я]нуари";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "January";
                        audioWord.clip = audioClipWord[88];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Я]майка";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Jamaica";
                        audioWord.clip = audioClipWord[89];
                        break;
                }
                break;

            case "SER0":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Аа";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Aa";

                audioLetter.clip = audioClipLetter[0];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[А]рхив";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[A]rchive";
                        audioWord.clip = audioClipWord[0];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[А]прил";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[A]pril";
                        audioWord.clip = audioClipWord[1];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[А]лжир";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[A]lgire";
                        audioWord.clip = audioClipWord[2];
                        break;
                }
                break;

            case "SER1":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Бб";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Bb";

                audioLetter.clip = audioClipLetter[1];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Б]еoград";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[B]elgrade";
                        audioWord.clip = audioClipWord[3];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Б]алерина";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[B]allerina";
                        audioWord.clip = audioClipWord[4];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Б]анка";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[B]ank";
                        audioWord.clip = audioClipWord[5];
                        break;
                }
                break;

            case "SER2":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Вв";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Vv";
                audioLetter.clip = audioClipLetter[2];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[В]алкира";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[V]alkyrie";
                        audioWord.clip = audioClipWord[6];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[В]идео";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[V]ideo";
                        audioWord.clip = audioClipWord[7];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[В]ирус";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[V]irus";
                        audioWord.clip = audioClipWord[8];
                        break;
                }
                break;

            case "SER3":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Гг";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Gg";
                audioLetter.clip = audioClipLetter[3];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Г]рфити";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[G]raffiti";
                        audioWord.clip = audioClipWord[9];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Г]аранциja";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[G]uarantee";
                        audioWord.clip = audioClipWord[10];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Г]игант";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[G]iant";
                        audioWord.clip = audioClipWord[11];
                        break;
                }
                break;

            case "SER4":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Дд";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Dd";
                audioLetter.clip = audioClipLetter[4];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Д]есерелација";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[D]eserelation";
                        audioWord.clip = audioClipWord[12];

                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Д]есерт";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[D]esert";
                        audioWord.clip = audioClipWord[13];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Д]елфин";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[D]olphin";
                        audioWord.clip = audioClipWord[14];
                        break;
                }
                break;

            case "SER5":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "ђЂ";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Dj";
                audioLetter.clip = audioClipLetter[5];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Ђанго";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Dj]ango";
                        audioWord.clip = audioClipWord[15];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ђ]убриште";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Landfill";
                        audioWord.clip = audioClipWord[16];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ђ]енерал";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[G]eneral";
                        audioWord.clip = audioClipWord[17];
                        break;
                }
                break;

            case "SER6":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Ее";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Eе";
                audioLetter.clip = audioClipLetter[6];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Е]кслклузиван";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[E]xclusive";
                        audioWord.clip = audioClipWord[18];

                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Е]лектроника";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[E]lectonic";
                        audioWord.clip = audioClipWord[19];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Е]моција";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[E]motion";
                        audioWord.clip = audioClipWord[20];
                        break;
                }

                break;

            case "SER7":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Жж";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Zh";
                audioLetter.clip = audioClipLetter[7];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ж]урналииста";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[J]ournalist";
                        audioWord.clip = audioClipWord[21];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ж]аргон";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[J]argon";
                        audioWord.clip = audioClipWord[22];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ж]анр";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[G]enre";
                        audioWord.clip = audioClipWord[23];
                        break;
                }
                break;

            case "SER8":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Зз";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Zz";
                audioLetter.clip = audioClipLetter[8];


                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[З]агреб";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Z]agreb";
                        audioWord.clip = audioClipWord[24];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[З]ебра";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Z]ebra";
                        audioWord.clip = audioClipWord[25];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[З]емља";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Z]emlia";
                        audioWord.clip = audioClipWord[26];
                        break;
                }
                break;

            case "SER9":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Ии";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ii";
                audioLetter.clip = audioClipLetter[9];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[И]нтервенција";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[I]ntervention";
                        audioWord.clip = audioClipWord[27];

                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[И]магинација";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[I]magination";
                        audioWord.clip = audioClipWord[28];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[И]нформација";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[I]nformation";
                        audioWord.clip = audioClipWord[29];
                        break;
                }
                break;
            case "SER10":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Jj";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Yy";
                audioLetter.clip = audioClipLetter[10];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Jугославија";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Y]ugoslavia";
                        audioWord.clip = audioClipWord[30];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[J]емен";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Y]emen";
                        audioWord.clip = audioClipWord[31];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Jединица";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[U]nit";
                        audioWord.clip = audioClipWord[32];
                        break;
                }
                break;
            case "SER11":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Кк";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Kk";
                audioLetter.clip = audioClipLetter[11];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[К]анада";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[C]anada";
                        audioWord.clip = audioClipWord[33];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[К]онстантин";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[K]onstantin";
                        audioWord.clip = audioClipWord[34];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[К]алендар";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[C]alendar";
                        audioWord.clip = audioClipWord[35];
                        break;
                }
                break;
            case "SER12":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Лл";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ll";
                audioLetter.clip = audioClipLetter[12];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Л]атекс ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[L]atex";
                        audioWord.clip = audioClipWord[36];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Л]ампа";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[L]amp";
                        audioWord.clip = audioClipWord[37];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Л]ампа";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[L]amp";
                        audioWord.clip = audioClipWord[38];
                        break;
                }
                break;
            case "SER13":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Љљ";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Lju";
                audioLetter.clip = audioClipLetter[13];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Љ]убав";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[L]ove";
                        audioWord.clip = audioClipWord[39];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Љутња";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Anger]";
                        audioWord.clip = audioClipWord[40];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Љ]уљашка";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Swing]";
                        audioWord.clip = audioClipWord[41];
                        break;
                }
                break;
            case "SER14":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Мм";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Mm";
                audioLetter.clip = audioClipLetter[14];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[М]агнет ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[M]agnet";
                        audioWord.clip = audioClipWord[42];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[М]иш";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[M]ouse";
                        audioWord.clip = audioClipWord[43];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[М]алтер";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[M]ortar";
                        audioWord.clip = audioClipWord[44];
                        break;
                }
                break;

            case "SER15":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Нн";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Nn";
                audioLetter.clip = audioClipLetter[15];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Н]овинар";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[N]ews";
                        audioWord.clip = audioClipWord[45];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Н]оминиран";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[N]ominate";
                        audioWord.clip = audioClipWord[46];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Н]овембар";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[N]ovembar";
                        audioWord.clip = audioClipWord[47];
                        break;
                }
                break;

            case "SER16":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Њ њ";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ny";
                audioLetter.clip = audioClipLetter[16];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Њ]егов";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[His]";
                        audioWord.clip = audioClipWord[48];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Њ]ен";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Hers]";
                        audioWord.clip = audioClipWord[49];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Њ]ушка";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Muzzle]";
                        audioWord.clip = audioClipWord[50];
                        break;
                }
                break;

            case "SER17":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Oo";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Оо";
                audioLetter.clip = audioClipLetter[17];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[O]кеан";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[O]cean";
                        audioWord.clip = audioClipWord[51];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[O]стрво";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[I]sland";
                        audioWord.clip = audioClipWord[52];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Oпера";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[O]pera";
                        audioWord.clip = audioClipWord[53];
                        break;
                }
                break;

            case "SER18":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Пп";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Pp";
                audioLetter.clip = audioClipLetter[18];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[П]илот ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[P]ilot";
                        audioWord.clip = audioClipWord[54];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[П]етар";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[P]etar";
                        audioWord.clip = audioClipWord[55];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[П]ошта";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[P]ost";
                        audioWord.clip = audioClipWord[56];
                        break;
                }
                break;

            case "SER19":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Рр";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Rr";
                audioLetter.clip = audioClipLetter[19];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Р]адар ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[R]adar";
                        audioWord.clip = audioClipWord[57];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Р]агби";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[R]ugby";
                        audioWord.clip = audioClipWord[58];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Р]акун";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Raccoon]";
                        audioWord.clip = audioClipWord[59];
                        break;
                }
                break;

            case "SER20":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Сс";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ss";
                audioLetter.clip = audioClipLetter[20];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[С]афир ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[S]aphire";
                        audioWord.clip = audioClipWord[60];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[С]ауна ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[S]auna";
                        audioWord.clip = audioClipWord[61];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[С]амба";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[S]amba";
                        audioWord.clip = audioClipWord[62];
                        break;
                }
                break;

            case "SER21":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Тт";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Tt";
                audioLetter.clip = audioClipLetter[21];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Т]ранспорт ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[T]ransport";
                        audioWord.clip = audioClipWord[63];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Т]ама";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Darkness]";
                        audioWord.clip = audioClipWord[64];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Т]рагедија";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[T]ragedy";
                        audioWord.clip = audioClipWord[65];
                        break;
                }
                break;

            case "SER22":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Ћћ";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Tshe";
                audioLetter.clip = audioClipLetter[22];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ћ]ирилица";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Cyrillic]";
                        audioWord.clip = audioClipWord[66];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ћ]ао";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[B]ye";
                        audioWord.clip = audioClipWord[67];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ћ]ошак";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[C]orner";
                        audioWord.clip = audioClipWord[68];
                        break;
                }
                break;

            case "SER23":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Уу";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Uu";
                audioLetter.clip = audioClipLetter[23];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[У]ниверзум";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "B[u]lk";
                        audioWord.clip = audioClipWord[69];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[У]ниверзитет";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[U]niversity";
                        audioWord.clip = audioClipWord[70];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[У]лтра-звук";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[U]ltra-sound";
                        audioWord.clip = audioClipWord[71];
                        break;
                }
                break;

            case "SER24":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Фф";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ff";
                audioLetter.clip = audioClipLetter[24];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ф]изика";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ph]ysics";
                        audioWord.clip = audioClipWord[72];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ф]антазиja";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ph]antasy";
                        audioWord.clip = audioClipWord[73];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ф]ебруар";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[F]bruary";
                        audioWord.clip = audioClipWord[74];
                        break;
                }
                break;

            case "SER25":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Хх";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Hh";
                audioLetter.clip = audioClipLetter[25];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Х]лад";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Cold]";
                        audioWord.clip = audioClipWord[75];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Х]ерој";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[H]ero";
                        audioWord.clip = audioClipWord[76];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Хигиjена";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[H]ygiene";
                        audioWord.clip = audioClipWord[77];
                        break;
                }
                break;

            case "SER26":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Цц";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Cc";
                audioLetter.clip = audioClipLetter[26];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ц]ентиматaр ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[C]antimeter";
                        audioWord.clip = audioClipWord[78];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ц]ар";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ts]ar";
                        audioWord.clip = audioClipWord[79];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ц]ивилизациja";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[C]ivilization";
                        audioWord.clip = audioClipWord[80];
                        break;
                }
                break;

            case "SER27":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Ч";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ch";
                audioLetter.clip = audioClipLetter[27];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Чиле";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ch]ile";
                        audioWord.clip = audioClipWord[81];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ч]oколада";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[C]hocolate";
                        audioWord.clip = audioClipWord[82];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Чешка";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Czech Republic";
                        audioWord.clip = audioClipWord[83];
                        break;
                }
                break;

            case "SER28":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Џ џ";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Dž";
                audioLetter.clip = audioClipLetter[28];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Џ]ин";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[G]ene";
                        audioWord.clip = audioClipWord[84];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Џ]емпер";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Sweater";
                        audioWord.clip = audioClipWord[85];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Џ]езва";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Dž]ezva";
                        audioWord.clip = audioClipWord[86];
                        break;
                }
                break;

            case "SER29":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Шш";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Sh";
                audioLetter.clip = audioClipLetter[29];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ш]еширs";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Hats";
                        audioWord.clip = audioClipWord[87];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ш]ампањац";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ch]ampagne";
                        audioWord.clip = audioClipWord[88];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ш]ок";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Sh]ock";
                        audioWord.clip = audioClipWord[89];
                        break;
                }
                break;

            case "RUS0":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Аа";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Aa";
                audioLetter.clip = audioClipLetter[0];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[А]вгуст";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[A]ugust";
                        audioWord.clip = audioClipWord[0];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[А]втобус";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[A]utobus";
                        audioWord.clip = audioClipWord[1];

                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[А]вокадо";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[A]vocado";
                        audioWord.clip = audioClipWord[2];

                        break;
                }
                break;

            case "RUS1":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Бб";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Bb";
                audioLetter.clip = audioClipLetter[1];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Б]андаж";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[B]andage";
                        audioWord.clip = audioClipWord[3];

                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Б]амбук";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[B]amboo";
                        audioWord.clip = audioClipWord[4];

                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Б]анан";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[B]anana";
                        audioWord.clip = audioClipWord[5];

                        break;
                }
                break;

            case "RUS2":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Вв";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Vv";
                audioLetter.clip = audioClipLetter[2];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[В]олк";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[W]olf";
                        audioWord.clip = audioClipWord[6];

                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[В]иза";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[V]isa";
                        audioWord.clip = audioClipWord[7];

                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[В]aза";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[V]ase";
                        audioWord.clip = audioClipWord[8];

                        break;
                }
                break;

            case "RUS3":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Гг";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Gg";
                audioLetter.clip = audioClipLetter[3];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Г]рамм";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[G]ram";
                        audioWord.clip = audioClipWord[9];

                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Г]азель";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[G]azelle";
                        audioWord.clip = audioClipWord[10];

                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Г]рамматика";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[G]rammar";
                        audioWord.clip = audioClipWord[11];
                        break;
                }
                break;

            case "RUS4":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Дд";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Dd";
                audioLetter.clip = audioClipLetter[4];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Д]иктатор ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[D]ictator";
                        audioWord.clip = audioClipWord[12];

                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Д]октор";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[D]octor";
                        audioWord.clip = audioClipWord[13];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Д]обро";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Good";
                        audioWord.clip = audioClipWord[14];
                        break;
                }
                break;

            case "RUS5":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Ее";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ee";
                audioLetter.clip = audioClipLetter[5];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Е]нот";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Racoon";
                        audioWord.clip = audioClipWord[15];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[E]вгений ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[E]vgenii";
                        audioWord.clip = audioClipWord[16];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Е]вропа";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Е]urope";
                        audioWord.clip = audioClipWord[17];
                        break;
                }
                break;

            case "RUS6":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Ёё";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Yo";
                audioLetter.clip = audioClipLetter[6];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ё]лка";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Christmas tree";
                        audioWord.clip = audioClipWord[18];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ё]жик";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text =  "Hedgehog";
                        audioWord.clip = audioClipWord[19];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Ёршик";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Brush";
                        audioWord.clip = audioClipWord[20];
                        break;
                }

                break;

            case "RUS7":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Жж";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Jj";
                audioLetter.clip = audioClipLetter[7];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ж]аба";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Frog]";
                        audioWord.clip = audioClipWord[21];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ж]алость";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Pity]";
                        audioWord.clip = audioClipWord[22];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ж]елезо";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Iron]";
                        audioWord.clip = audioClipWord[23];
                        break;
                }
                break;

            case "RUS8":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Зз";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Zz";
                audioLetter.clip = audioClipLetter[8];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[З]ебра";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Z]ebra";
                        audioWord.clip = audioClipWord[24];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[З]евс";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Z]eus";
                        audioWord.clip = audioClipWord[25];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[З]онa";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Z]one";
                        audioWord.clip = audioClipWord[26];
                        break;
                }
                break;

            case "RUS9":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Ии";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ii";
                audioLetter.clip = audioClipLetter[9];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[И]сландия ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[I]celand";
                        audioWord.clip = audioClipWord[27];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[И]дея ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[I]dea";
                        audioWord.clip = audioClipWord[28];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[И]кра";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Caviar]";
                        audioWord.clip = audioClipWord[29];
                        break;
                }
                break;
            case "RUS10":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Йй";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Yy";
                audioLetter.clip = audioClipLetter[10];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Й]од";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[I]odine";
                        audioWord.clip = audioClipWord[30];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Й]ога";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Y]oga";
                        audioWord.clip = audioClipWord[31];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Й]огурт";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Y]ogurt";
                        audioWord.clip = audioClipWord[32];
                        break;
                }
                break;
            case "RUS11":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Кк";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Kk";
                audioLetter.clip = audioClipLetter[11];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[К]арате";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[K]arate";
                        audioWord.clip = audioClipWord[33];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[К]илометр ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[K]ilometer";
                        audioWord.clip = audioClipWord[34];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[К]илограмм";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[K]ilogram";
                        audioWord.clip = audioClipWord[35];
                        break;
                }
                break;
            case "RUS12":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Лл";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ll";
                audioLetter.clip = audioClipLetter[12];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Л]ампа";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[L]amp";
                        audioWord.clip = audioClipWord[36];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Л]азер";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[L]aser";
                        audioWord.clip = audioClipWord[37];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Л]юбовь";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[L]ove";
                        audioWord.clip = audioClipWord[38];
                        break;
                }
                break;
            case "RUS13":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Мм";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Mm";
                audioLetter.clip = audioClipLetter[13];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[М]акедония ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[M]acedonia";
                        audioWord.clip = audioClipWord[39];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[М]aдам";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[M]adam";
                        audioWord.clip = audioClipWord[40];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[M]адрид";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[М]adrid";
                        audioWord.clip = audioClipWord[41];
                        break;
                }
                break;
            case "RUS14":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Нн";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Nn";
                audioLetter.clip = audioClipLetter[14];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Н]авигатор";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[N]avigator";
                        audioWord.clip = audioClipWord[42];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Н]аводнение ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Flood";
                        audioWord.clip = audioClipWord[43];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Н]адзор";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Supervision";
                        audioWord.clip = audioClipWord[44];
                        break;
                }
                break;

            case "RUS15":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Оо";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Oo";
                audioLetter.clip = audioClipLetter[15];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[О]бьект ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[O]bject";
                        audioWord.clip = audioClipWord[45];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[О]бсерватория";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[O]bservatory";
                        audioWord.clip = audioClipWord[46];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[О]кеан";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[O]cean";
                        audioWord.clip = audioClipWord[47];
                        break;
                }
                break;

            case "RUS16":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Пп";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Pp";
                audioLetter.clip = audioClipLetter[16];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[П]авильон";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[P]avilion";
                        audioWord.clip = audioClipWord[48];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[П]аж";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[P]age";
                        audioWord.clip = audioClipWord[49];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[П]анама";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[P]anama";
                        audioWord.clip = audioClipWord[50];
                        break;
                }
                break;

            case "RUS17":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Рр";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Rr";
                audioLetter.clip = audioClipLetter[17];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Р]аввин";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[R]abbi";
                        audioWord.clip = audioClipWord[51];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Р]аса";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[R]ace";
                        audioWord.clip = audioClipWord[52];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Р]акета ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[R]ocket";
                        audioWord.clip = audioClipWord[53];
                        break;
                }
                break;

            case "RUS18":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Сс";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ss";
                audioLetter.clip = audioClipLetter[18];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[С]ейф";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[S]afe";
                        audioWord.clip = audioClipWord[54];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[С]ейф";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[S]afe";
                        audioWord.clip = audioClipWord[55];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[С]едло";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[S]addle";
                        audioWord.clip = audioClipWord[56];
                        break;
                }
                break;

            case "RUS19":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Тт";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Tt";
                audioLetter.clip = audioClipLetter[19];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Т]аблица ";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[T]able";
                        audioWord.clip = audioClipWord[57];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Т]айвань";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[T]aiwan";
                        audioWord.clip = audioClipWord[58];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Т]абу";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[T]aboo";
                        audioWord.clip = audioClipWord[59];
                        break;
                }
                break;

            case "RUS20":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Уу";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Uu";
                audioLetter.clip = audioClipLetter[20];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[У]крайна";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[U]kraine";
                        audioWord.clip = audioClipWord[60];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[У]рок";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Lesson";
                        audioWord.clip = audioClipWord[61];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[У]ниформа";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[U]niform";
                        audioWord.clip = audioClipWord[62];
                        break;
                }
                break;

            case "RUS21":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Фф";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ff";
                audioLetter.clip = audioClipLetter[21];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ф]абрика";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[F]actory";
                        audioWord.clip = audioClipWord[63];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ф]айл";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[F]ile";
                        audioWord.clip = audioClipWord[64];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ф]акт";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[F]act";
                        audioWord.clip = audioClipWord[65];
                        break;
                }
                break;

            case "RUS22":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Хх";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Hh";
                audioLetter.clip = audioClipLetter[22];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Х]аос";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ch]aos";
                        audioWord.clip = audioClipWord[66];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Х]аос";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ch]os";
                        audioWord.clip = audioClipWord[67];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Х]аризма";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ch]arisma";
                        audioWord.clip = audioClipWord[68];
                        break;
                }
                break;

            case "RUS23":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Цц";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ts";
                audioLetter.clip = audioClipLetter[23];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Царь";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ts]ar";
                        audioWord.clip = audioClipWord[69];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ц]ена";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Price";
                        audioWord.clip = audioClipWord[70];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ц]ирк";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[C]ircus";
                        audioWord.clip = audioClipWord[71];
                        break;
                }
                break;

            case "RUS24":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Чч";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Ch";
                audioLetter.clip = audioClipLetter[24];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ч]ат";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ch]at";
                        audioWord.clip = audioClipWord[72];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ч]или";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ch]ile";
                        audioWord.clip = audioClipWord[73];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ч]ек";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ch]eck";
                        audioWord.clip = audioClipWord[74];
                        break;
                }
                break;

            case "RUS25":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Шш";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Sh";
                audioLetter.clip = audioClipLetter[25];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Шампунь";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Sh]ampoo";
                        audioWord.clip = audioClipWord[75];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Шампанское";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ch]ampagne";
                        audioWord.clip = audioClipWord[76];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ш]ахматы";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Chess";
                        audioWord.clip = audioClipWord[77];
                        break;
                }
                break;

            case "RUS26":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Щщ";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Sht";
                audioLetter.clip = audioClipLetter[26];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Щ]енок";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Snag";
                        audioWord.clip = audioClipWord[78];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Щ]ит";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Shield";
                        audioWord.clip = audioClipWord[79];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Щ]ука";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Pike fish";
                        audioWord.clip = audioClipWord[80];
                        break;
                }
                break;

            case "RUS27":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Ъъ";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Uu";
                audioLetter.clip = audioClipLetter[27];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Под[ъ]езд";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Staircase";
                        audioWord.clip = audioClipWord[81];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Суб[ъ]ект";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Subject";
                        audioWord.clip = audioClipWord[82];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Суб[ъ]ект";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Subject";
                        audioWord.clip = audioClipWord[83];
                        break;
                }
                break;

            case "RUS28":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Ыы";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "ey/oo";
                audioLetter.clip = audioClipLetter[28];
                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Бар[ы]ня";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Madam";
                        audioWord.clip = audioClipWord[84];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Бр[ы]нза";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Cheese";
                        audioWord.clip = audioClipWord[85];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Бр[ы]нза";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Cheese";
                        audioWord.clip = audioClipWord[86];
                        break;
                }
                break;

            case "RUS29":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "ь";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "y";
                audioLetter.clip = audioClipLetter[29];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Aл[ь]бом";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Album";
                        audioWord.clip = audioClipWord[87];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Бор[ь]ба";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Fight";
                        audioWord.clip = audioClipWord[88];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "Бор[ь]ба";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Fight";
                        audioWord.clip = audioClipWord[89];
                        break;
                }
                break;

            case "RUS30":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Э";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "e";
                audioLetter.clip = audioClipLetter[30];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Э]тнос";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[E]thnicity";
                        audioWord.clip = audioClipWord[90];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Э]лектричество";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[E]lectricity";
                        audioWord.clip = audioClipWord[91];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Э]тика";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[E]thics";
                        audioWord.clip = audioClipWord[92];
                        break;
                }
                break;

            case "RUS31":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Юю";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Yu";
                audioLetter.clip = audioClipLetter[31];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ю]гославия";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Yu]goslavia";
                        audioWord.clip = audioClipWord[93];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ю]ла";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Yu]le";
                        audioWord.clip = audioClipWord[94];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Ю]рисдикция";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Jurisdiction";
                        audioWord.clip = audioClipWord[95];
                        break;
                }
                break;

            case "RUS32":
                letterObject.transform.GetChild(3).gameObject.GetComponent<Text>().text = "Яя";
                letterObject.transform.GetChild(3).gameObject.transform.GetChild(0).gameObject.GetComponent<Text>().text = "Yа";
                audioLetter.clip = audioClipLetter[32];

                switch (random)
                {
                    case 0:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Я]блоко";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Apple";
                        audioWord.clip = audioClipWord[96];
                        break;
                    case 1:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Я]гуар";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "Jaguar";
                        audioWord.clip = audioClipWord[97];
                        break;
                    case 2:
                        letterObject.transform.GetChild(5).transform.GetChild(3).GetComponent<Text>().text = "[Я]лта";
                        letterObject.transform.GetChild(5).transform.GetChild(4).GetComponent<Text>().text = "[Ya]lta";
                        audioWord.clip = audioClipWord[98];
                        break;
                }
                break;
        }
    }
    void InstantiateLetter()
    {
        foreach (GameObject go in GameObject.FindGameObjectsWithTag("language"))
        {
            Destroy(go);
        }

        letterObject = Instantiate(letterPrefab, this.transform.parent.transform.parent);

        letterObject.transform.localPosition = new Vector2(2000, 0);
        letterObject.transform.DOLocalMoveX(0, 2);

        menu.GetComponent<Button>().enabled = false;
        menu.GetComponent<Image>().enabled = false;
        this.transform.parent.DOLocalMoveX(-2000, 2);

        audioLetter = letterObject.transform.GetChild(7).gameObject.GetComponent<AudioSource>();
        audioWord = letterObject.transform.GetChild(9).gameObject.GetComponent<AudioSource>();
    }

    public void LearnMode()
    {
        PlayerPrefs.SetInt("LearnMode", 1);
        click.Play();
        bool alphabetFull = true;

        switch (progressManager.language)
        {
            case "Bulgarian(Clone)":
                for (int i = 0; i < progressManager.level.Length; i++)
                {
                    if (progressManager.level[i] == false)
                    {
                        transform.parent.transform.GetChild(1).gameObject.name = "BG" + i.ToString();
                        PlayerPrefs.SetInt("BUL" + i, 1);
                        progressManager.level[i] = true;
                        progressManager.CheckLetters();
                        SelectLetter();
                        alphabetFull = false;
                        break;
                    }
                }
                if (GameObject.Find("ExampleScreen") != null && alphabetFull == false)
                {
                    GameObject.Find("ExampleScreen").GetComponent<ExampleScript>().Return();
                }
                else
                {
                    PlayerPrefs.SetInt("LearnMode", 0);
                }
                break;
            case "Russian(Clone)":
                for (int i = 0; i < progressManager.level.Length; i++)
                {
                    if (progressManager.level[i] == false)
                    {
                        transform.parent.transform.GetChild(1).gameObject.name = "RUS" + i.ToString();
                        PlayerPrefs.SetInt("RUS" + i, 1);
                        progressManager.level[i] = true;
                        progressManager.CheckLetters();
                        SelectLetter();
                        alphabetFull = false;
                        break;
                    }
                }
                if (GameObject.Find("ExampleScreen") != null && alphabetFull == false)
                {
                    GameObject.Find("ExampleScreen").GetComponent<ExampleScript>().Return();
                }
                else
                {
                    PlayerPrefs.SetInt("LearnMode", 0);
                }
                break;
            case "Serbian(Clone)":
                for (int i = 0; i < progressManager.level.Length; i++)
                {
                    if (progressManager.level[i] == false)
                    {
                        transform.parent.transform.GetChild(1).gameObject.name = "SER" + i.ToString();
                        PlayerPrefs.SetInt("SER" + i, 1);
                        progressManager.level[i] = true;
                        progressManager.CheckLetters();
                        SelectLetter();
                        alphabetFull = false;
                        break;
                    }
                }
                if (GameObject.Find("ExampleScreen") != null && alphabetFull == false)
                {
                    GameObject.Find("ExampleScreen").GetComponent<ExampleScript>().Return();
                }
                else
                {
                    PlayerPrefs.SetInt("LearnMode", 0);
                }
                break;
        }
    }
}
