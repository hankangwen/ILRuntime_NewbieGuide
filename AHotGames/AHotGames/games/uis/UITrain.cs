using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.UI;
using UnityEngine;
using System.Collections;

public class UITrain : AHotBase
{
    private Image image;
    private Button leftBtn;
    private Button rightBtn;
    private int currentImg = 0;//当前图片序号
    private int totalImg = 5;//图片总数，默认为5
    private string assetPath;//路径
    private string directoryPath = "/Resources/Pictures/1/";
    
    protected override void InitComponents()
	{
        image = FindWidget<Image>("Image_Bg");
        leftBtn = FindWidget<Button>("LeftBtn");
        rightBtn = FindWidget<Button>("RightBtn");

        leftBtn.onClick.AddListener(LeftBtnClick);
        rightBtn.onClick.AddListener(RightBtnClick);
    }

    void LeftBtnClick()
    {
        Debug.Log("LeftBtnClick");
        leftBtn.interactable = false;
        currentImg--;
        if (currentImg < 0)
        {
            currentImg = (totalImg - 1);
        }
        LoadImage();
    }

    void RightBtnClick()
    {
        Debug.Log("RightBtnClick");
        rightBtn.interactable = false;        
        currentImg++;
        if (currentImg > (totalImg - 1))
        {
            currentImg = 0;
        }
        LoadImage();
    }

    void LoadImage()
    {
        if (!leftBtn.interactable) { leftBtn.interactable = true; }
        if (!rightBtn.interactable) { rightBtn.interactable = true; }
        
        assetPath = @"file:///" + Application.dataPath + directoryPath + currentImg.ToString() + ".jpg";//给路径赋值
        LoadByResources.ResourcesLoadSync(image, assetPath);
    }
}