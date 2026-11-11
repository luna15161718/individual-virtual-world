using UnityEngine;
using TMPro;

public class ShowTextField : MonoBehaviour
{
    [SerializeField] TMP_InputField inputField;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) {
            inputField.gameObject.SetActive(true);
            inputField.ActivateInputField();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player")) {
            inputField.DeactivateInputField();
            inputField.gameObject.SetActive(false);
        }
    }
}
