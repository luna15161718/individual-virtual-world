using UnityEngine;

public class MoveArms : MonoBehaviour
{
    bool moving;
    bool up;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        up = false;
        moving = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(moving) {
            if(up) {
                transform.position += new Vector3(0, 0.05f, 0);
                if(transform.position.y >= 2) {
                    up = false;
                }
            }
            else {
                transform.position -= new Vector3(0, 0.05f, 0);
                if(transform.position.y <= 0.75) {
                    up = true;
                }
            }
        }
    }

    public void StartArms()
    {
        moving = true;
    }
}
