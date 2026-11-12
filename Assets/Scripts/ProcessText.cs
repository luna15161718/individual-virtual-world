using UnityEngine;
using TMPro;

public class ProcessText : MonoBehaviour
{
    [SerializeField] MoveDoor doorMover;
    [SerializeField] MoveDoor doorInteriorMover;
    [SerializeField] TMP_InputField inputField;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckText(string text)
    {
        if(text == "33009151") {
            doorMover.OpenDoor();
            doorInteriorMover.OpenDoor();
            Destroy(inputField.gameObject);
        }
    }
}
