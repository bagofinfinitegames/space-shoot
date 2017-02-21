using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        getSaveInfo();
	}
	
	// Update is called once per frame
	void Update () {
        //bool set = false;
        //if (!set) {
        //    setSaveInfo(5);
        //    set = true;
        //}
	}

    void getSaveInfo() {
        int maxScore = PlayerPrefs.GetInt("maxScore", 0);
        Debug.Log(maxScore);
    }

    void setSaveInfo(int maxScore) {
        PlayerPrefs.SetInt("maxScore", maxScore);
        getSaveInfo();
    }
}
