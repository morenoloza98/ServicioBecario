using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Firebase;
using Firebase.Unity.Editor;
using Firebase.Database;

public class Read : MonoBehaviour
{

    public Text nameInput;
    public Text queryResult;

    private string resultName;

    DatabaseReference reference;

    // Start is called before the first frame update
    void Start()
    {
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://servicio-becario.firebaseio.com/");
        reference = FirebaseDatabase.DefaultInstance.RootReference;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void lookupUser()
    {
        FirebaseDatabase.DefaultInstance.GetReference("users").GetValueAsync().ContinueWith(task => {
          if (task.IsFaulted)
          {
                // Handle the error...
            }
          else if (task.IsCompleted)
          {
                Debug.Log("Searchup success");
                DataSnapshot snapshot = task.Result;
                resultName = (string)snapshot.Child(nameInput.text).Child("email").GetValue(false);
                Debug.Log("User's email found is: " + resultName);
                queryResult.text = resultName;
            }
        });
    }

    public void deleteUser()
    {
        reference.Child("users").Child(nameInput.text).SetValueAsync(null);
        Debug.Log("Deletion completed");
        SceneManager.LoadScene("MainMenu");
    }
}
