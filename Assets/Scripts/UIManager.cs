 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject intro;
    public GameObject menus;
    public GameObject mainMenu;
    public GameObject levelMenu;
    public GameObject blockTypeMenu;
    public GameObject settingsMenu;
    public GameObject blockparticles;
    public GameObject NotificationPanel;
    public GameObject nickNamePanel;
    public GameObject confirmationPanel;
    public GameObject[] pieces;
    public InputField nickNameInput;
    public Text[] nickNameText;

    public static string nickName;

    public List<Sprite> thumbnails;

    public static bool isFirstTime = true;
    int notificationIndex;

    public AudioClip[] soundList;
    public AudioSource musicSource;
    public Toggle music, SFX;
    public static bool isMusicON, isSFXON;

    //void Awake()
    //{
    //    if (isFirstTime)
    //    {
    //        DontDestroyOnLoad(this);
    //    }
        
    //}

    void Start()
    {
        if (isFirstTime)
        {
            menus.SetActive(true);
            mainMenu.SetActive(false);
            levelMenu.SetActive(false);
            blockTypeMenu.SetActive(false);
            settingsMenu.SetActive(false);
            blockparticles.SetActive(false);
            NotificationPanel.SetActive(false);
            nickNamePanel.SetActive(false);
            confirmationPanel.SetActive(false);
            StartCoroutine(Intro());
        }
        else
        {
            nickNameText[0].text = nickName;
            nickNameText[1].text = nickName;

            menus.SetActive(true);
            mainMenu.SetActive(true);
            levelMenu.SetActive(false);
            blockTypeMenu.SetActive(false);
            settingsMenu.SetActive(false);

            music.isOn = isMusicON;
            SFX.isOn = isSFXON;
        }
        

    }
    
    void Update()
    {
        if (music.isOn)
        {
            isMusicON = true;
            
            musicSource.mute = false;
            musicSource.playOnAwake = true;
        }
        else
        {
            isMusicON = false;
            musicSource.mute = true;
        }

        if (SFX.isOn)
        {
            isSFXON = true;
            GetComponent<AudioSource>().mute = false;
        }
        else
        {
            isSFXON = false;
            GetComponent<AudioSource>().mute = true;
        }

        GamePlayManager.isMusicON = isMusicON;
        GamePlayManager.isSFXON = isSFXON;
    }

    public void ButtonClick()
    {
        GetComponent<AudioSource>().PlayOneShot(soundList[0]);
    }

    IEnumerator Intro()
    {
        intro.SetActive(true);
        yield return new WaitForSeconds(3);
        intro.SetActive(false);
        NotificationPanel.SetActive(true);
        nickNamePanel.SetActive(true);
        confirmationPanel.SetActive(false);
        menus.SetActive(true);
        mainMenu.SetActive(true);
    }


    public void EnterNickname()
    {
        nickName = "Hi, "+nickNameInput.text;
        nickNameText[0].text = nickName;
        nickNameText[1].text = nickName;


        levelMenu.SetActive(false);
        blockTypeMenu.SetActive(false);
        nickNamePanel.SetActive(false);
        NotificationPanel.SetActive(false);
        confirmationPanel.SetActive(false);
        blockparticles.SetActive(true);
    }

    public void StartGame()
    {
        blockparticles.SetActive(false);
        menus.SetActive(true);
        mainMenu.SetActive(false);
        levelMenu.SetActive(true);
        blockTypeMenu.SetActive(false);


    }

    public void backToMainMenu()
    {
        menus.SetActive(true);
        levelMenu.SetActive(false);
        blockTypeMenu.SetActive(false);
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void backToLevelMenu()
    {
        menus.SetActive(true);
        levelMenu.SetActive(true);
        mainMenu.SetActive(false);
        blockTypeMenu.SetActive(false);
    }
    public void goToBlockTypeMenu()
    {
        menus.SetActive(true);
        levelMenu.SetActive(false);
        mainMenu.SetActive(false);
        blockTypeMenu.SetActive(true);
    }
    public void StartLevel()
    {
        Debug.Log("Image Index"+PuzzleImageSliderScript.imageIndex);
        GamePlayManager.imgIndex = PuzzleImageSliderScript.imageIndex;
        GamePlayManager.blockType = ImageSliderScript.blockType;
        menus.SetActive(true);
        mainMenu.SetActive(false);
        levelMenu.SetActive(false);
        blockTypeMenu.SetActive(false);

        SceneManager.LoadScene(1);

    }

    public void GoToSettings()
    {
        settingsMenu.SetActive(true);
        mainMenu.SetActive(false);
        levelMenu.SetActive(false);
        blockTypeMenu.SetActive(false);
    }
    
    public void QuitGame()
    {
        NotificationPanel.SetActive(true);
        nickNamePanel.SetActive(false);
        confirmationPanel.SetActive(true);
        notificationIndex = 0;
    }

    public void ConfirmationBtn(bool yes)
    {
        if (yes)
        {
            if(notificationIndex == 0)
            {
                Application.Quit();
            }
        }
        else
        {
            NotificationPanel.SetActive(false);
            confirmationPanel.SetActive(false);
        }
    }
}
