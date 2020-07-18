using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintManager : MonoBehaviour
{
    bool assigned = false;
    void Update()
    {
        if(assigned == false)
        {
            int hint = Random.Range(0, 4);

            switch (hint)
            {
                case 0:
                    this.gameObject.GetComponent<Text>().text = "Hint: For every two letters that you learn, you should practice a bit.";
                    break;
                case 1:
                    this.gameObject.GetComponent<Text>().text = "Hint: If you learn one type of cyrillic alphabet, you can easily learn the others.";
                    break;
                case 2:
                    this.gameObject.GetComponent<Text>().text = "Hint: Don't forget to say the words and letters out loud as you hear them.";
                    break;
                case 3:
                    this.gameObject.GetComponent<Text>().text = "Hint: Learn how to write with the drawing board.";
                    break;
                case 4:
                    this.gameObject.GetComponent<Text>().text = "Hint: Don't forget to recommend our app to your friends!";
                    break;
            }

            assigned = true;
        }
    }
}
