using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject WinUI;
    public GameObject gamePlayUI;
    public GameObject Particles;
    public Text scoreBoard;
    public Text totalScore;
    public GameObject[] blockType;

    public static int pieceCount;
    public static int totalPieces;
    public static int score;

    public static bool isWin;
    

    void Start()
    {
        score = 0;
        WinUI.SetActive(false);
        gamePlayUI.SetActive(true);
        Particles.SetActive(false);

        pieceCount = 0;
        isWin = false;
    }
    
    void Update()
    {
        Debug.Log("Total pieces " + totalPieces);
        if(pieceCount == totalPieces && !isWin)
        {
            Debug.Log("You Win");
            WinUI.SetActive(true);
            gamePlayUI.SetActive(false);
            Particles.SetActive(true);
            isWin = true;
        }

        

        scoreBoard.text = score.ToString();
        totalScore.text = score.ToString();
    }
}
