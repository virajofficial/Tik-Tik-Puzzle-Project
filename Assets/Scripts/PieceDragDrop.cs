using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PieceDragDrop : MonoBehaviour
{
    public GameObject selectedPiece;
    public static bool isGamePaused;
    int order = 1;
    void Start()
    {
        
    }
    

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isGamePaused)
        {


            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.up);
            if(hit.transform != null)
            {
                if (hit.transform.CompareTag("puzzlePiece"))
                {
                    if (!hit.transform.GetComponent<PiecesHandlingScript>().inRightPosition)
                    {
                        selectedPiece = hit.transform.gameObject;
                        selectedPiece.GetComponent<PiecesHandlingScript>().Selected = true;
                        selectedPiece.GetComponent<SortingGroup>().sortingOrder = order;
                        order++;
                        
                    }

                }
                //selectedPiece.GetComponent<BoxCollider2D>().size = new Vector2(3, 3);
            }
            
            
        }

        if (Input.GetMouseButtonUp(0))
        {
            if(selectedPiece != null)
            {
                selectedPiece.GetComponent<PiecesHandlingScript>().Selected = false;
                selectedPiece = null;
            }
        }

        if(selectedPiece != null)
        {
            Vector3 mousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selectedPiece.transform.position = new Vector3(mousePoint.x,mousePoint.y,0);
        }
    }
}
