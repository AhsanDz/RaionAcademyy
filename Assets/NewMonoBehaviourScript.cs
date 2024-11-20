using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private float movementSpeed = 8f;
    private float maxdistance = 7f;
    public Transform Bullet;
    public Transform Aim;
    void Start()
    {
        Debug.Log("Test Start");
    }

    // Update is called once per frame
    void Update()
    {
        float inputMovementX = Input.GetAxisRaw("Horizontal");
        Vector3 movementDirection = new Vector3();
        movementDirection.z = inputMovementX;
        Vector3 directionOutput = transform.position + movementDirection * movementSpeed * Time.deltaTime;
        directionOutput.z = Mathf.Clamp(directionOutput.z, -maxdistance, 12f);

        transform.position = directionOutput;


        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Tembak");
            Transform newBullet = Instantiate(Bullet, transform.position, Quaternion.identity);
            //Destroy(newBullet, 5.5f);
        }
    }
}
