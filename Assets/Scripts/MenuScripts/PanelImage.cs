using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class PanelImage : MonoBehaviour
{

public GameObject panel;
   // public Sprite loadImage;
    public string BundleURL; 
     public string AssetName;
      public Text Loading;
      GameObject body;
      //public GameObject hideButtons;
    // Start is called before the first frame update
    void Awake()
    {
     
    
    }

     IEnumerator Start() {
     // Download the file from the URL. It will not be saved in the Cache
     using (WWW www = new WWW(BundleURL)) {
         yield return www;
         if (www.error != null)
             throw new Exception("WWW download had an error:" + www.error);
         AssetBundle bundle = www.assetBundle;
         if (AssetName == "")
             Instantiate(bundle.mainAsset);
         else
         {
           //GameObject dennis = bundle.LoadAsset<GameObject>(AssetName) ;
                       body = (GameObject)Instantiate(bundle.LoadAsset(AssetName));
                       body.transform.SetParent(panel.transform);
                    Loading.enabled = false;
                       //loadImage = dennis;
                     //  Debug.Log("Aaaa");
                       
         }              
                  

     
     
                   bundle.Unload(false);
      
    }
    }

    // Update is called once per frame
    void Update()
    {
        //  panel.GetComponent<Image>().sprite =  loadImage;
        //  if(loadImage != null){
    
        //     Loading.enabled = false;
        //     hideButtons.SetActive(true);
        //  }else
        //  {
        //     // Debug.Log("Image not found");
        //  }
    }
}//class
