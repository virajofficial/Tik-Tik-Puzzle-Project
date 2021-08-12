using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PiecesHandlingScript : MonoBehaviour
{
    private Vector3 truePosition;
    public bool inRightPosition;
    public bool Selected;
    AudioSource sound;

    public static PiecesHandlingScript instance;

    void Start()
    {
        GameStart();
        sound = gameObject.AddComponent<AudioSource>();
    }

    public void GameStart()
    {
        truePosition = transform.position;
        transform.position = new Vector3(Random.Range(-3.5f, 3.5f), Random.Range(-4f, -8f));

        
    }
    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, truePosition) < 0.5f)
        {
            if (!Selected)
            {
                if(inRightPosition == false)
                {
                    transform.position = truePosition;
                    inRightPosition = true;
                    sound.PlayOneShot(Resources.Load<AudioClip>("Woosh-Mark_DiAngelo-4778593"));
                    GetComponent<SortingGroup>().sortingOrder = 0;
                    GetComponent<BoxCollider2D>().size = new Vector2(1.5f, 1.5f);
                    ScoreManager.pieceCount++;
                    Debug.Log(ScoreManager.pieceCount);

                    if (ScoreManager.pieceCount < 15 && ScoreManager.pieceCount >= 1)
                    {
                        if (GamePlayManager.timeRemaining < 20)
                        {
                            ScoreManager.score += 15;
                        }
                        else
                        {
                            ScoreManager.score += 20;
                        }

                    }
                    else if (ScoreManager.pieceCount < 25)
                    {
                        if (GamePlayManager.timeRemaining > 900)
                        {
                            ScoreManager.score += 15;
                        }
                        else if (GamePlayManager.timeRemaining > 600)
                        {
                            ScoreManager.score += 12;
                        }
                        else
                        {
                            ScoreManager.score += 10;
                        }
                    }
                    else if (ScoreManager.pieceCount >= 25)
                    {
                        if (GamePlayManager.timeRemaining > 900)
                        {
                            ScoreManager.score += 20;
                        }
                        else
                        {
                            ScoreManager.score += 10;
                        }
                    }

                }
            }
        }
    }
}
