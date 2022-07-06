using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenMove : MonoBehaviour
{
    public float speed;
    private Transform target;
    public float seeDistance = 120f;
    public float attackDistance = 122f;

    public GameObject Laser3;

    public int lives = 3;

    public GameObject PlayAudioDeathG;
    public int scoreBlue;
    public ScoreManager scoreManager;


    [SerializeField]
    private GameObject GreenExploisonPrefab;

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
        //target = GameObject.FindGameObjectWithTag("VirusRed").GetComponent<Transform>();
        target = GameObject.FindWithTag("VirusRed").transform;
       // Laser3.SetActive(false);
        PlayAudioDeathG.SetActive(false);
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
            PlayAudioDeathG.SetActive(true);
            scoreManager.AddScoreBlue(scoreBlue);
            Instantiate(GreenExploisonPrefab, transform.position, Quaternion.identity);
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
        Laser3.SetActive(true);
    }

    public void LaserDisact()
    {
        Laser3.SetActive(false);
    }

    private void TakeDamageGreen()
    {
        lives--;

        if (lives < 0)
        {
            lives = 0;
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "VirusBlue")
        {
            TakeDamageGreen();

        }


    }
}
