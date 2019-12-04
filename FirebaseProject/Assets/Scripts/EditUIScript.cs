using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditUIScript : MonoBehaviour
{
    public Button submitButton;
    public Button cancelName;
    public Button cancelAge;
    public Button cancelGender;
    public InputField nameEdit;
    public InputField ageEdit;
    public InputField genderEdit;

    public Text nameText;
    public Text ageText;
    public Text genderText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NameEditMode()
    {   
        nameEdit.gameObject.SetActive(true);
        nameText.gameObject.SetActive(false);
        submitButton.gameObject.SetActive(true);
        cancelName.gameObject.SetActive(true);
    }

    public void AgeEditMode()
    {
        ageEdit.gameObject.SetActive(true);
        ageText.gameObject.SetActive(false);
        submitButton.gameObject.SetActive(true);
        cancelAge.gameObject.SetActive(true);
    }

    public void GenderEditMode()
    {
        genderEdit.gameObject.SetActive(true);
        genderText.gameObject.SetActive(false);
        submitButton.gameObject.SetActive(true);
        cancelGender.gameObject.SetActive(true);
    }

    public void CancelName()
    {
        nameEdit.gameObject.SetActive(false);
        nameText.gameObject.SetActive(true);
        submitButton.gameObject.SetActive(false);
        cancelName.gameObject.SetActive(false);
    }

    public void CancelAge()
    {
        ageEdit.gameObject.SetActive(false);
        ageText.gameObject.SetActive(true);
        submitButton.gameObject.SetActive(false);
        cancelAge.gameObject.SetActive(false);
    }

    public void CancelGender()
    {
        genderEdit.gameObject.SetActive(false);
        genderText.gameObject.SetActive(true);
        submitButton.gameObject.SetActive(false);
        cancelGender.gameObject.SetActive(false);
    }
}
