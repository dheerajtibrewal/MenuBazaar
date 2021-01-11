using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;

public class ImageLoadServer : MonoBehaviour
{
    public RawImage imageToDisplay;
    public string BundleURL; 
    public Text loading;


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
    loading.enabled = false;


  }
}

// Sprite SpriteFromTexture2D(Texture2D texture) {

//   return Sprite.Create(texture, new Rect(0.0f, 0.0f, texture.width, texture.height), new Vector2(0.5f, 0.5f), 100.0f);
// }
}//class
