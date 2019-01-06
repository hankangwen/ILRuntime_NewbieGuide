using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class LoadByResources
{
    /// <summary>
    /// Resources同步加载
    /// </summary>
    /// <param name="image"></param>
    /// <param name="currentImg"></param>
    public static void ResourcesLoadSync(Image image, string assetPath)
    {
        Debug.Log("ResourceLoadSync");
        string[] path = assetPath.Split('/');
        string resourcePath = path[path.Length - 1].Substring(0, path[path.Length - 1].LastIndexOf('.'));
        Debug.Log(resourcePath);
        image.sprite = Resources.Load<Sprite>("Pictures/1/" + resourcePath);
    }
}

