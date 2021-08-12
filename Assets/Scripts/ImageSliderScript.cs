using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageSliderScript : MonoBehaviour
{
    public static ImageSliderScript instance;

    public Scrollbar scrollbar;
    public List<Image> thumbnails;
    public static int imageIndex;
    public static int blockType;

    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.touchCount == 0)
        {
            if (scrollbar.GetComponent<Scrollbar>().value< 0.125f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0, 0.1f);

                thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

                thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1f, 1f), 0.1f);

                thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 120);

                if(transform.gameObject.name == "LevelMenu")
                {
                    imageIndex = 0;
                }
                else if(transform.gameObject.name == "BlockTypeMenu")
                {
                    blockType = 0;
                }
            }
            else if(scrollbar.GetComponent<Scrollbar>().value >= 0.125f && scrollbar.GetComponent<Scrollbar>().value < 0.375f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0.25f, 0.1f);

                thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

                thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1f, 1f), 0.1f);

                thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 120);

                if (transform.gameObject.name == "LevelMenu")
                {
                    imageIndex = 1;
                }
                else if (transform.gameObject.name == "BlockTypeMenu")
                {
                    blockType = 1;
                }
            }
            else if (scrollbar.GetComponent<Scrollbar>().value >= 0.375f && scrollbar.GetComponent<Scrollbar>().value < 0.625f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0.5f, 0.1f);

                thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

                thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1f, 1f), 0.1f);

                thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 120);

                if (transform.gameObject.name == "LevelMenu")
                {
                    imageIndex = 2;
                }
                else if (transform.gameObject.name == "BlockTypeMenu")
                {
                    blockType = 2;
                }
            }
            else if (scrollbar.GetComponent<Scrollbar>().value >= 0.625f && scrollbar.GetComponent<Scrollbar>().value < 0.875f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 0.75f, 0.1f);

                thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

                thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1f, 1f), 0.1f);

                thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 255);
                thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 120);

                if (transform.gameObject.name == "LevelMenu")
                {
                    imageIndex = 3;
                }
                else if (transform.gameObject.name == "BlockTypeMenu")
                {
                    blockType = 3;
                }
            }
            else if (scrollbar.GetComponent<Scrollbar>().value >= 0.875f && scrollbar.GetComponent<Scrollbar>().value <= 1f)
            {
                scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, 1, 0.1f);

                thumbnails[4].transform.localScale = Vector2.Lerp(thumbnails[4].transform.localScale, new Vector2(1.2f, 1.2f), 0.1f);

                thumbnails[1].transform.localScale = Vector2.Lerp(thumbnails[1].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[2].transform.localScale = Vector2.Lerp(thumbnails[2].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[3].transform.localScale = Vector2.Lerp(thumbnails[3].transform.localScale, new Vector2(1f, 1f), 0.1f);
                thumbnails[0].transform.localScale = Vector2.Lerp(thumbnails[0].transform.localScale, new Vector2(1f, 1f), 0.1f);

                thumbnails[0].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[1].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[2].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[3].GetComponent<Image>().color = new Color32(255, 255, 255, 120);
                thumbnails[4].GetComponent<Image>().color = new Color32(255, 255, 255, 255);

                if (transform.gameObject.name == "LevelMenu")
                {
                    imageIndex = 4;
                }
                else if (transform.gameObject.name == "BlockTypeMenu")
                {
                    blockType = 4;
                }
            }
        }
    }
}
