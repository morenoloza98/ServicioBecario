using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Firebase;
using Firebase.Unity.Editor;
using Firebase.Database;

public class Create : MonoBehaviour
{
    public Text nameInput;
    public Text ageInput;
    public Text emailInput;

    DatabaseReference reference;

    // Start is called before the first frame update
    void Start()
    {
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://servicio-becario.firebaseio.com/");
        reference = FirebaseDatabase.DefaultInstance.RootReference;
        InicializarBD();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InicializarBD()
    {
        Firebase.FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(task => {  
            var dependencyStatus = task.Result;
            if(dependencyStatus == Firebase.DependencyStatus.Available)
            {
                //Do nothing
            }
            else
            {
                UnityEngine.Debug.LogError(System.String.Format("Could not resolve all Firebase dependencies: {0}", dependencyStatus));
            }
        });
    }

    public void triggerSave()
    {
        createUser(nameInput.text, ageInput.text, emailInput.text);
    }

    public void createUser(string name, string age, string email)
    {
        //using insecure ID first to test functionality
        string idAux = name;
        Person auxPerson = new Person(name, age, email);
        string json = JsonUtility.ToJson(auxPerson);
        reference.Child("users").Child(idAux).SetRawJsonValueAsync(json);
        SceneManager.LoadScene("MainMenu");
    }
}

public class Person
{

    public string name;
    public string age;
    public string email;

    public Person()
    {
    }

    public Person(string name, string age, string email)
    {
        this.name = name;
        this.age = age;
        this.email = email;
    }
}
