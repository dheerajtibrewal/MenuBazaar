using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;

public class RawFoodPicLoader : MonoBehaviour
{
  
    public RawImage imageToDisplay;
    public string BundleURL; 
    public Text load;
    


void Start() {
  StartCoroutine (GetTexture ());
}

IEnumerator GetTexture() {
  UnityWebRequest www = UnityWebRequestTexture.GetTexture(BundleURL);

  yield return www.SendWebRequest();

  if(www.isNetworkError) {
    Debug.Log(www.error);
  }
  else {
    Texture2D webTexture = ((DownloadHandlerTexture)www.downloadHandler).texture as Texture2D;
   // Sprite webSprite = SpriteFromTexture2D (webTexture);
   // imageToDisplay.sprite = webSprite;
    imageToDisplay.texture = webTexture ;
    load.enabled = false;
    


  }
}
}//class
