using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    GameObject _mainScreen;
    GameObject _optionsScreen;
    GameObject _aboutScreen;

    private void Start()
    {
        _mainScreen = this.transform.Find("UI_TitleScreen").gameObject;
        _optionsScreen = this.transform.Find("UI_OptionsScreen").gameObject;
        _aboutScreen = this.transform.Find("UI_AboutScreen").gameObject;
    }

    public void PopUpMain()
    {
        _mainScreen.SetActive(true);
        _optionsScreen.SetActive(false);
        _aboutScreen.SetActive(false);
    }

    public void PopUpOptions()
    {
        _optionsScreen.SetActive(true);
        _mainScreen.SetActive(false);
        _aboutScreen.SetActive(false);
    }

    public void PopUpAbout()
    {
        _aboutScreen.SetActive(true);
        _optionsScreen.SetActive(false);
        _mainScreen.SetActive(false);
    }
}
