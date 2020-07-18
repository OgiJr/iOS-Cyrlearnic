using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuPrefab;
    private GameObject mainMenuObject;
    private Vector2 spawnPos = new Vector2(2500, 1280);
    public AudioSource click;


    public void ToggleMainMenu()
    {
        click.Play();
        mainMenuObject = GameObject.Find("HomeScreen");
        mainMenuObject.transform.localPosition = new Vector2(1500,0);
        mainMenuObject.transform.DOLocalMoveX(0, 2);
        this.transform.parent.transform.DOMoveX(-1500, 2);
        Destroy(this.gameObject);
    }
}
