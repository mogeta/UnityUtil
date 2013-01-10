using UnityEngine;
using System.Collections;

public class CheckFallDelete : MonoBehaviour
{

    GameObject manager;
    private const float sendParameter = 1;
    private const float DELETE_Y_POS = -3;

    // Use this for initialization
    void Start ()
    {
        manager = GameObject.Find("Manager");
    }

    // Update is called once per frame
    void Update ()
    {
        if (transform.position.y < DELETE_Y_POS)
        {
            
            manager.SendMessage("receiveFallObject",sendParameter);
            //Destroy(this); //only delete component
            Destroy(this.gameObject);
        }
    }
}