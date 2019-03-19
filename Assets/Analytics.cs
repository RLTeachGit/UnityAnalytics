using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class Analytics : MonoBehaviour {

    static Analytics mSingleton; //Use a Singleton so we can make the script static

    public static Analytics singleton {
    get {
        return  mSingleton;  
        }
    } //Expose only getter to ensure it can be overwritten

    void Awake () {
        if(mSingleton==null) {
            mSingleton = this; //Keep a reference to ourself
            DontDestroyOnLoad(gameObject);
            AnalyticsEvent.GameStart(); //record every time Player Starts Game
        } else if(mSingleton!=this) {
            Destroy(gameObject); //If its duplicate destroy it, there should be just one
        } //Started Unity singleton creation mechanic, just like GameManager
    }
}


