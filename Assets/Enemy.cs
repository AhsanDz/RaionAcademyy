using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float movementSpeed = 8f;
    public GameObject gameObject;
    public GameManager game;
    

    //void Start()
    //{
    //    game = gameObject.GetComponent<GameManager>();
    //}

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(1, 0, 0);
        transform.position += Vector3.left * Time.deltaTime * movementSpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            
            Debug.Log("test");
            game.setgameover();
            Destroy(collision.gameObject);
        }

    }
}
