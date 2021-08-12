using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlayManager : MonoBehaviour
{
    public GameObject game;
    public GameObject gamePlayMenu;
    public GameObject pauseMenu;
    public Image imagePreview;
    public Image winImage;
    public Text timer;
    public Text spentTime;
    public GameObject[] pieces;
    public GameObject[] puzzleType;

    public static float timeRemaining;
    public static bool isAPieceRightPos;
    float startTime;

    public List<Sprite> thumbnails;
    public static int imgIndex;
    public static int blockType;

    public static bool isMusicON, isSFXON;
    public AudioSource music;
    public AudioClip[] audioList;
    



    void Start()
    {
        timeRemaining = 1200;
        startTime = 1200;
        gamePlayMenu.SetActive(true);
        pauseMenu.SetActive(false);

        PieceDragDrop.isGamePaused = false;
        Debug.Log("Image Index" + imgIndex);
        puzzleType[blockType].SetActive(true);
        pieces = GameObject.FindGameObjectsWithTag("puzzlePiece");
        
        foreach (GameObject piece in pieces)
        {
            piece.transform.GetChild(0).transform.GetComponent<SpriteRenderer>().sprite = thumbnails[imgIndex];
            Debug.Log(piece.name);
        }
        ScoreManager.totalPieces = pieces.Length;
        imagePreview.sprite = thumbnails[imgIndex];
        winImage.sprite = thumbnails[imgIndex];
    }
    
    void Update()
    {
        timeRemaining -= Time.deltaTime;


        float minutes = Mathf.FloorToInt(timeRemaining / 60);

        float seconds = Mathf.FloorToInt(timeRemaining % 60);


        if (timeRemaining <= 0)
        {
            timer.color = Color.red;
            timer.text = "00:00";
        }
        else
        {

            timer.text = minutes.ToString("00") + ":" + seconds.ToString("00");
            if (timeRemaining < 20)
            {
                timer.color = Color.red;
            }
        }

        if (isAPieceRightPos)
        {
            GetComponent<AudioSource>().PlayOneShot(audioList[1]);
        }


        if(!ScoreManager.isWin)
        spentTime.text = (Mathf.FloorToInt(startTime / 60) - minutes - 1).ToString("00")+":"+ (60 - seconds).ToString("00");


        if (isMusicON)
        {
            music.mute = false;
        }
        else
        {
            music.mute = true;
        }

        if (isSFXON)
        {
            GetComponent<AudioSource>().mute = false;
        }
        else
        {
            GetComponent<AudioSource>().mute = true;
        }
    }

    public void ButtonClickSFX()
    {
        GetComponent<AudioSource>().PlayOneShot(audioList[0]);
    }

    public void PauseGame()
    {
        PieceDragDrop.isGamePaused = true;
        gamePlayMenu.SetActive(true);
        pauseMenu.SetActive(true);
    }

    public void ResumeGame()
    {
        PieceDragDrop.isGamePaused = false;
        pauseMenu.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GotoMainMenu()
    {
        UIManager.isFirstTime = false;
        puzzleType[0].SetActive(false);
        puzzleType[1].SetActive(false);
        puzzleType[2].SetActive(false);
        SceneManager.LoadScene(0);
    }
}
