using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null) transform.position = player.position;
    }

    private void LateUpdate()
    {
        
    }
}
