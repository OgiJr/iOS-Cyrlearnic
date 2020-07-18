using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DrawDismiss : MonoBehaviour
{
    public Transform parent;
    private string letter;
    public Font font;

    void Update()
    {
        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            if (EventSystem.current.currentSelectedGameObject == null)
            {
                GameObject.Find("Write").gameObject.GetComponent<AudioSource>().Play();
                GameObject.Find("LetterCyrillic").gameObject.GetComponent<Text>().font = font;
                //Vector2 originalPos = GameObject.Find("LetterCyrillic").transform.GetChild(0).transform.position;
                //GameObject.Find("LetterCyrillic").transform.localScale = new Vector2(2, 2f);
                //GameObject.Find("LetterCyrillic").transform.localPosition += new Vector3(0, 200, 0);
                //GameObject.Find("LetterCyrillic").transform.GetChild(0).localScale = new Vector2(0.5f, 0.5f);
                //GameObject.Find("LetterCyrillic").transform.GetChild(0).transform.position = originalPos;
                Destroy(this.gameObject);
            }
            else if (EventSystem.current.currentSelectedGameObject.name != "Pronounciation")
            {
                GameObject.Find("Write").gameObject.GetComponent<AudioSource>().Play();
                GameObject.Find("LetterCyrillic").gameObject.GetComponent<Text>().font = font;
                //Vector2 originalPos = GameObject.Find("LetterCyrillic").transform.GetChild(0).transform.position;
                //GameObject.Find("LetterCyrillic").transform.localScale = new Vector2(2, 2f);
                //GameObject.Find("LetterCyrillic").transform.localPosition += new Vector3(0, 200, 0);
                //GameObject.Find("LetterCyrillic").transform.GetChild(0).localScale = new Vector2(0.5f, 0.5f);
                //GameObject.Find("LetterCyrillic").transform.GetChild(0).transform.position = originalPos;
                Destroy(this.gameObject);
            }
        }
    }
}