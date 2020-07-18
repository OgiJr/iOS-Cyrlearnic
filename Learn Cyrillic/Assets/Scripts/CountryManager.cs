using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountryManager : MonoBehaviour
{
    public HomeManager homeManager;
    public TextMeshProUGUI countryName;

    void Update()
    {
        if(homeManager == null)
        {
            homeManager = this.transform.parent.gameObject.GetComponent<HomeManager>();
        }

        switch (homeManager.languageSelected)
        {
            case 0:
                countryName.text = "Russia";
                break;
            case 1:
                countryName.text = "Bulgaria";
                break;
            case 2:
                countryName.text = "Serbia";
                break;
        }
    }
}