using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;

public class AutomaticButtonImage : MonoBehaviour
{
    // Start is called before the first frame update
   public Button button;
    public Sprite Image1;
    public string BundleURL; // --> http://Myserver/public_http/Assets/AssetBundles/cube_prefab (path to the AssetBundle)
     public string AssetName;
    public int version;
    public GameObject mainPanel;
   // public GameObject panel;
    bool test ;
    public Text Loading;
     
     void Start () {
        //button = GetComponent<Button>();
        //StartCoroutine("imageloaded");
        // StopCoroutine("imageloaded");
       // NewFunc();
       
        
        
     }

     

     IEnumerator imageloaded(){
         yield return new WaitForSeconds(0.1f);
        // button.GetComponent<Image>().sprite = Image1;
         
         
         
         

     }
     void Update(){
        button.GetComponent<Image>().sprite = Image1;
        if(Image1 != null){
            mainPanel.SetActive(true);
            Loading.enabled = false;
        }

     }
       

    // Update is called once per frame
    void Awake()
    {
        
        {
        StartCoroutine(DownloadAndCache());
    }
 
 IEnumerator DownloadAndCache()
         {
             // Wait for the Caching system to be ready
        
         

             // Load the AssetBundle file from Cache if it exists with the same version or download and store it in the cache
             using (WWW www = WWW.LoadFromCacheOrDownload(BundleURL, version))
             {
                 yield return www;
                 if (www.error != null)
                     throw new Exception("WWW download had an error:" + www.error);
                 AssetBundle bundle = www.assetBundle;
                 if (AssetName == "")
                     Instantiate(bundle.mainAsset);
                 else
                 {
                      
                     Sprite dennis = bundle.LoadAsset<Sprite>(AssetName) ;
                     //Instantiate(bundle.LoadAsset(AssetName));
                     Image1 = dennis;
                     
                     //dennis = Image1;
                     Debug.Log("assetLoaded");
                     //bundle.Unload(false);
                     //loadingtext.enabled = false;

                 }
                
                     
                     bundle.Unload(false);
                 
                 // Unload the AssetBundles compressed contents to conserve memory
                // bundle.Unload(false);
             } // memory is freed from the web stream (www.Dispose() gets called implicitly)

             
         
         }
    }

     

     
    
}//class
