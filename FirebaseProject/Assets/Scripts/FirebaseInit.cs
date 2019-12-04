using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Analytics;  

public class FirebaseInit : MonoBehaviour
{

    void Awake() {
        // DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task =>
        {
            FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
