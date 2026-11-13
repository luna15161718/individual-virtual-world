using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class ProcessText : MonoBehaviour
{
    [SerializeField] MoveDoor doorMover;
    [SerializeField] MoveDoor doorInteriorMover;
    [SerializeField] ShowWindow windowShower;
    [SerializeField] ShowWindow windowInteriorShower;
    [SerializeField] List<MoveArms> armMovers;
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
            if(doorMover != null) {
                doorMover.OpenDoor();
                doorInteriorMover.OpenDoor();
                Destroy(inputField.gameObject);
            }
            else if(windowShower != null) {
                windowShower.CreateWindow();
                windowInteriorShower.CreateWindow();
                Destroy(inputField.gameObject);
            }
            else {
                foreach(MoveArms arm in armMovers) {
                    arm.StartArms();
                }
                Destroy(inputField.gameObject);
            }
        }
    }
}
