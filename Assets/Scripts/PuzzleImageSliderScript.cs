using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleImageSliderScript : MonoBehaviour
{
    public Scrollbar scrollbar;
    public List<Image> thumbnails;
    public static int imageIndex;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.touchCount == 0)
        {
            if (scrollbar.GetComponent<Scrollbar>().value < 0.0625f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0, 0.1f);

                thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

                thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[5].transform.localScale = Vector2.Lerp(thumbnails[5].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[6].transform.localScale = Vector2.Lerp(thumbnails[6].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[7].transform.localScale = Vector2.Lerp(thumbnails[7].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[8].transform.localScale = Vector2.Lerp(thumbnails[8].transform.localScale, new Vector2(1f, 1f), 0.1f);

                thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[5].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[6].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[7].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[8].GetComponent<Image>().color = new Color32(255, 255, 255, 120);

                imageIndex = 0;
            }
            else if (scrollbar.GetComponent<Scrollbar>().value >= 0.0625f && scrollbar.GetComponent<Scrollbar>().value < 0.1875f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0.125f, 0.1f);

                thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

                thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[5].transform.localScale = Vector2.Lerp(thumbnails[5].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[6].transform.localScale = Vector2.Lerp(thumbnails[6].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[7].transform.localScale = Vector2.Lerp(thumbnails[7].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[8].transform.localScale = Vector2.Lerp(thumbnails[8].transform.localScale, new Vector2(1f, 1f), 0.1f);

                thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[5].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[6].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[7].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[8].GetComponent<Image>().color = new Color32(255, 255, 255, 120);

                imageIndex = 1;
            }
            else if (scrollbar.GetComponent<Scrollbar>().value >= 0.1875f && scrollbar.GetComponent<Scrollbar>().value < 0.3125f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0.25f, 0.1f);

                thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

                thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[5].transform.localScale = Vector2.Lerp(thumbnails[5].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[6].transform.localScale = Vector2.Lerp(thumbnails[6].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[7].transform.localScale = Vector2.Lerp(thumbnails[7].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[8].transform.localScale = Vector2.Lerp(thumbnails[8].transform.localScale, new Vector2(1f, 1f), 0.1f);

                thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[5].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[6].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[7].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[8].GetComponent<Image>().color = new Color32(255, 255, 255, 120);

                imageIndex = 2;
            }
            else if (scrollbar.GetComponent<Scrollbar>().value >= 0.3125f && scrollbar.GetComponent<Scrollbar>().value < 0.4375f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0.375f, 0.1f);

                thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

                thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[5].transform.localScale = Vector2.Lerp(thumbnails[5].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[6].transform.localScale = Vector2.Lerp(thumbnails[6].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[7].transform.localScale = Vector2.Lerp(thumbnails[7].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[8].transform.localScale = Vector2.Lerp(thumbnails[8].transform.localScale, new Vector2(1f, 1f), 0.1f);

                thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[5].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[6].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[7].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[8].GetComponent<Image>().color = new Color32(255, 255, 255, 120);

                imageIndex = 3;
            }
            else if (scrollbar.GetComponent<Scrollbar>().value >= 0.4375f && scrollbar.GetComponent<Scrollbar>().value < 0.5625f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0.5f, 0.1f);

                thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

                thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[5].transform.localScale = Vector2.Lerp(thumbnails[5].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[6].transform.localScale = Vector2.Lerp(thumbnails[6].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[7].transform.localScale = Vector2.Lerp(thumbnails[7].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[8].transform.localScale = Vector2.Lerp(thumbnails[8].transform.localScale, new Vector2(1f, 1f), 0.1f);

                thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                thumbnails[5].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[6].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[7].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[8].GetComponent<Image>().color = new Color32(255, 255, 255, 120);

                imageIndex = 4;
            }
            else if(scrollbar.GetComponent<Scrollbar>().value >= 0.5625f && scrollbar.GetComponent<Scrollbar>().value < 0.6875f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0.625f, 0.1f);

                thumbnails[5].transform.localScale = Vector2.Lerp(thumbnails[5].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

                thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[6].transform.localScale = Vector2.Lerp(thumbnails[6].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[7].transform.localScale = Vector2.Lerp(thumbnails[7].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[8].transform.localScale = Vector2.Lerp(thumbnails[8].transform.localScale, new Vector2(1f, 1f), 0.1f);

                thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[5].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                thumbnails[6].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[7].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[8].GetComponent<Image>().color = new Color32(255, 255, 255, 120);

                imageIndex = 5;
            }
            else if (scrollbar.GetComponent<Scrollbar>().value >= 0.6875f && scrollbar.GetComponent<Scrollbar>().value < 0.8215f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0.75f, 0.1f);

                thumbnails[6].transform.localScale = Vector2.Lerp(thumbnails[6].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

                thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[5].transform.localScale = Vector2.Lerp(thumbnails[5].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[7].transform.localScale = Vector2.Lerp(thumbnails[7].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[8].transform.localScale = Vector2.Lerp(thumbnails[8].transform.localScale, new Vector2(1f, 1f), 0.1f);

                thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[5].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[6].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                thumbnails[7].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[8].GetComponent<Image>().color = new Color32(255, 255, 255, 120);

                imageIndex = 6;
            }
            else if (scrollbar.GetComponent<Scrollbar>().value >= 0.8215f && scrollbar.GetComponent<Scrollbar>().value < 0.9375f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0.875f, 0.1f);

                thumbnails[7].transform.localScale = Vector2.Lerp(thumbnails[7].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

                thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[5].transform.localScale = Vector2.Lerp(thumbnails[5].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[6].transform.localScale = Vector2.Lerp(thumbnails[6].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[8].transform.localScale = Vector2.Lerp(thumbnails[8].transform.localScale, new Vector2(1f, 1f), 0.1f);

                thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[5].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[6].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[7].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                thumbnails[8].GetComponent<Image>().color = new Color32(255, 255, 255, 120);

                imageIndex = 7;
            }
            else if (scrollbar.GetComponent<Scrollbar>().value >= 0.9375f && scrollbar.GetComponent<Scrollbar>().value <= 1f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 1f, 0.1f);

                thumbnails[8].transform.localScale = Vector2.Lerp(thumbnails[8].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

                thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[5].transform.localScale = Vector2.Lerp(thumbnails[5].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[6].transform.localScale = Vector2.Lerp(thumbnails[6].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[7].transform.localScale = Vector2.Lerp(thumbnails[7].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1f, 1f), 0.1f);

                thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[5].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[6].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[7].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[8].GetComponent<Image>().color = new Color32(255, 255, 255, 255);

                imageIndex = 8;
            }
            //if (scrollbar.GetComponent<Scrollbar>().value < 0.125f)
            //{
            //    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0, 0.1f);

            //    thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

            //    thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1f, 1f), 0.1f);
            //    thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1f, 1f), 0.1f);
            //    thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1f, 1f), 0.1f);
            //    thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1f, 1f), 0.1f);

            //    thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            //    thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            //    thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            //    thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            //    thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 120);

            //        imageIndex = 0;
            //}
            //else if (scrollbar.GetComponent<Scrollbar>().value >= 0.125f && scrollbar.GetComponent<Scrollbar>().value < 0.375f)
            //{
            //    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0.25f, 0.1f);

            //    thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

            //    thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1f, 1f), 0.1f);
            //    thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1f, 1f), 0.1f);
            //    thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1f, 1f), 0.1f);
            //    thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1f, 1f), 0.1f);

            //    thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            //    thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            //    thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            //    thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            //    thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 120);


            //        imageIndex = 1;
            //}
            //else if (scrollbar.GetComponent<Scrollbar>().value >= 0.375f && scrollbar.GetComponent<Scrollbar>().value < 0.625f)
            //{
            //    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0.5f, 0.1f);

            //    thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

            //    thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1f, 1f), 0.1f);
            //    thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1f, 1f), 0.1f);
            //    thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1f, 1f), 0.1f);
            //    thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1f, 1f), 0.1f);

            //    thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            //    thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            //    thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            //    thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            //    thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 120);

            //        imageIndex = 2;
            //}
            //else if (scrollbar.GetComponent<Scrollbar>().value >= 0.625f && scrollbar.GetComponent<Scrollbar>().value < 0.875f)
            //{
            //    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0.75f, 0.1f);

            //    thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

            //    thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1f, 1f), 0.1f);
            //    thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1f, 1f), 0.1f);
            //    thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1f, 1f), 0.1f);
            //    thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1f, 1f), 0.1f);

            //    thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            //    thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            //    thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            //    thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
            //    thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 120);


            //        imageIndex = 3;
            //}
            //else if (scrollbar.GetComponent<Scrollbar>().value >= 0.875f && scrollbar.GetComponent<Scrollbar>().value <= 1f)
            //{
            //    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 1, 0.1f);

            //    thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

            //    thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1f, 1f), 0.1f);
            //    thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1f, 1f), 0.1f);
            //    thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1f, 1f), 0.1f);
            //    thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1f, 1f), 0.1f);

            //    thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            //    thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            //    thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            //    thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
            //    thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 255);


            //        imageIndex = 4;
            //}
        }
    }
}
