using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveingRedCrip : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float seeDistance = 120f;
    [SerializeField]
    public float attackDistance = 122f;
    [SerializeField]
    private GameObject Laser2;
    [SerializeField]
    private int lives = 3;
    [SerializeField]
    private GameObject PlayAudioDeathR;
    public int scoreGreen;
    public ScoreManager scoreManager;



    private void Start()
    {

        FindGameController();
        PlayAudioDeathR.SetActive(false);

    }

    private void FindGameController()
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
    }

    private void Update()
    {
        TargetRedMove();
        Destroy(gameObject, 20f);
        if (lives <= 0)
        {
            DeathRed();
        }
        else
        {
            return;
        }

    }

    private void TargetRedMove()
    {
        target = GameObject.FindWithTag("VirusBlue").transform;
        if (Vector3.Distance(transform.position, target.transform.position) < seeDistance)
        {
            transform.LookAt(target.transform);
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
    }

    private void DeathRed()
    {
        PlayAudioDeathR.SetActive(true);
        scoreManager.AddScoreGreen(scoreGreen);
        Debug.Log("зеленая пуля дура");
        Destroy(gameObject, 0.8f);
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

    private void OnTriggerEnter(Collider collision)
    {
       
        if (collision.tag == "VirusGreen")
        {
            TakeDamageRed();
        }
        else if (collision.tag == null)
        {
            return;
        }


    }

   
}
