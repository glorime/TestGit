using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadingScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("Player Health", 6);
        PlayerPrefs.SetInt("Player Stars", 0);
        PlayerPrefs.SetInt("Player FullyGrown", 0);
        PlayerPrefs.SetString("Plant Type", "sulfurAlder");
        //player materials 
        PlayerPrefs.SetString("Pot", "plasticPot");
        PlayerPrefs.SetString("Soil Handler", "hands");
        PlayerPrefs.SetString("Water Handler", "can");
        PlayerPrefs.SetInt("Player SantanSeeds", 0);
        PlayerPrefs.SetInt("Player LantanaSeeds", 0);
        PlayerPrefs.SetInt("Player SulfurSeeds", 10);
        PlayerPrefs.SetInt("Player plasticPots", 10);
        PlayerPrefs.SetInt("Player clayPots", 0);
        //7 - plant is destroyed in this area    
        PlayerPrefs.SetInt("area", 0);
        PlayerPrefs.SetInt("area1", 0);
        PlayerPrefs.SetInt("area2", 0);
        PlayerPrefs.SetInt("area3", 0);
        PlayerPrefs.SetInt("area4", 0);
        PlayerPrefs.SetInt("area5", 0);
        PlayerPrefs.SetInt("area6", 0);
        PlayerPrefs.SetInt("area7", 0);
        PlayerPrefs.SetInt("area8", 0);
        PlayerPrefs.SetInt("area9", 0);

        Invoke("LoadScene", 8);
    }
	
	// Update is called once per frame
	void LoadScene () {                    
        SceneManager.LoadScene("level1");
    }
}
