using UnityEngine;

public class CylinderGroupGrabber : MonoBehaviour
{
    private bool isGrabbed = false;
    private Transform player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Hand").transform;
    }

    private void Update()
    {
        if (isGrabbed)
        {
           
            transform.position = player.position;
            transform.rotation = player.rotation;
        }
    }

    public void Grab()
    {
        isGrabbed = true;
    }

    public void Release()
    {
        isGrabbed = false;
    }
}
