using UnityEngine;

public class bullet : MonoBehaviour
{
    public float movementbullet = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * Time.deltaTime * movementbullet;
    }
}