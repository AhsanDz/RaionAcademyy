using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Enemy enemyPrefab;
    public float currentInterval = 0f;
    public float interval = 2f;
    public GameObject UI;

    public bool gameover = false;
    void Start()
    {
        UI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameover)
        {
            currentInterval += Time.deltaTime;
            if (currentInterval > interval)
            {
                currentInterval = 0;
                Vector3 spamPos = transform.position;
                spamPos.z = Random.Range(-7f, 12f);
                Enemy NewEnemy = Instantiate(enemyPrefab, spamPos, Quaternion.identity);
                NewEnemy.game = this;

            }
        }
        else
        {
            return;
        }
    }

    public void setgameover()
    {
        gameover = true;
        UI.SetActive(true);
    }
}
