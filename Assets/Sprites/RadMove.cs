using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadMove : MonoBehaviour
{
    public float speed;
    private Transform target;

    public float seeDistance = 120f;
    public float attackDistance = 122f;

    public GameObject Laser2;

    public int lives = 3;

    public GameObject PlayAudioDeathR;
    public int scoreGreen;
    public ScoreManager scoreManager;


    [SerializeField]
    private GameObject RedExploisonPrefab;

    private void Start()
    {
        GameObject GameControllerObject = GameObject.FindWithTag("GameController");
        if (GameControllerObject != null)
        {
            scoreManager = GameControllerObject.GetComponent<ScoreManager>();
        }
        if (GameControllerObject == null)
        {
            Debug.Log("скрипт не найден");
        }

        target = GameObject.FindWithTag("VirusBlue").transform;
        //target = GameObject.FindGameObjectWithTag("VirusBlue").GetComponent<Transform>();

        //Laser2.SetActive(false);
        PlayAudioDeathR.SetActive(false);
    }


    private void Update()
    {
        //transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.transform.position) < seeDistance)
        {
                transform.LookAt(target.transform);
                transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
            
        }

        if (lives == 0)
        {
            PlayAudioDeathR.SetActive(true);
            scoreManager.AddScoreGreen(scoreGreen);
            Instantiate(RedExploisonPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.8f);
        }
    }

    public void AddSpeed()
    {
        speed++;
    }

    public void LowSpeed()
    {
        speed--;
    }

    public void AddHP()
    {
        lives++;
    }

    public void LowHP()
    {
        lives--;
    }

    public void LaserAct()
    {
        Laser2.SetActive(true);
    }

    public void LaserDisact()
    {
        Laser2.SetActive(false);
    }

    private void TakeDamageRed()
    {
        lives--;

        if (lives < 0)
        {
            lives = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "VirusGreen")
        {
            TakeDamageRed();

        }


    }

   
}
