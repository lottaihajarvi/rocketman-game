using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalewithSize : MonoBehaviour
{

    public GameObject bgImage;
    public Camera mainCam;

    void Start()
    {
        scaleBackgroundFitSize();
    }

    private void scaleBackgroundFitSize()
    {
        Vector2 deviceScreenResolution = new Vector2(Screen.width, Screen.height);
        print(deviceScreenResolution);

        float scrHeight = Screen.height;
        float scrWidth = Screen.width;

        float DEVICE_SCREEN_ASPECT = scrWidth / scrHeight;
        print("DEVICE_SCREEN_ASPECT: " + DEVICE_SCREEN_ASPECT.ToString());

        mainCam.aspect = DEVICE_SCREEN_ASPECT;

        float camHeight = 100.0f * mainCam.orthographicSize * 2.0f;
        float camWidth = camHeight * DEVICE_SCREEN_ASPECT;
        print("camHeight: " + camHeight.ToString());
        print("camWidth: " + camWidth.ToString());

        SpriteRenderer backgroundImg = bgImage.GetComponent<SpriteRenderer>();
        float bgImgH = backgroundImg.sprite.rect.height;
        float bgImgW = backgroundImg.sprite.rect.width;

        print("bgImgH: " + bgImgH.ToString());
        print("bgImgW: " + bgImgW.ToString());

        float bgImg_scale_ratio_Height = camHeight / bgImgH;
        float bgImg_scale_ratio_Width = camWidth / bgImgW;

        bgImage.transform.localScale = new Vector3(bgImg_scale_ratio_Width, bgImg_scale_ratio_Height, 1);
    }

}
