using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class FormatPosition : MonoBehaviour
{

    public GameObject target;
    public bool repositionNow = false;

    bool mStarted = false;

    // Use this for initialization
    void Start ()
    {
        mStarted = true;
        Reposition();
    }
    // Update is called once per frame
    void Update ()
    {
        if (repositionNow)
        {
            repositionNow = false;
            Reposition();
        }

    }

    public void Reposition ()
    {
        if(target==null){
            return;
        }
        if (!mStarted)
        {
            repositionNow = true;
            return;
        }
        transform.localPosition = target.transform.localPosition;
    }
}
