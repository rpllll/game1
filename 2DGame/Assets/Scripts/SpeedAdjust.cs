using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedAdjust : MonoBehaviour
{

    public GameObject OpenPanel = null;
    public boatMovement boat;
    // Start is called before the first frame update
    void Start()
    {
        OpenPanel.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            OpenPanel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            OpenPanel.SetActive(false);
        }
    }

    private bool IsOpenPanelActive
    {
        get
        {
            return OpenPanel.activeInHierarchy;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (IsOpenPanelActive)
        {
            if (Input.GetKey(KeyCode.E))
            {
                boat.Speed = 3.75f;
                Debug.Log("E is currently being pressed down");
            }
            else if (Input.GetKeyUp(KeyCode.E))
            {
                boat.Speed = 1f;
            }
        }
        else
        {
            boat.Speed = 1f;
        }
    }
}
