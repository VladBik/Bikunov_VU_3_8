using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveingBlueCrip : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float seeDistance = 120f;
    [SerializeField]
    private float attackDistance = 122f;

    [SerializeField]
    private GameObject Laser1;

    [SerializeField]
    private int lives = 3;

    [SerializeField]
    private GameObject PlayAudioDeathB;
    
    public int scoreRed;
    public ScoreManager scoreManager;

    
    private void Start()
    {
        FindGameController();
        PlayAudioDeathB.SetActive(false);
        
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
        Destroy(gameObject, 20f);
        TargetBlueMove();
        
        if (lives <= 0)
        {
            DeathBlue();
        }
        else
        {
            return;
        }
    }

    private void TargetBlueMove()
    {
        target = GameObject.FindWithTag("VirusGreen").transform;

        if (Vector3.Distance(transform.position, target.transform.position) < seeDistance)
        {

            transform.LookAt(target.transform);
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));

        }

        
        
    }

    private void DeathBlue()
    {
        PlayAudioDeathB.SetActive(true);
        scoreManager.AddScoreRed(scoreRed);
        Debug.Log("красная пуля дура");
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
            Laser1.SetActive(true);
        }

        public void LaserDisact3()
        {
            Laser1.SetActive(false);
        }

        private void TakeDamageBlue()
        {
            lives--;

            if (lives < 0)
            {
                lives = 0;
            }
        }

        private void OnTriggerEnter(Collider collision)
        {
            if (collision.tag == "VirusRed")
            {
                TakeDamageBlue();
            }
            else if(collision.tag == null)
            {
            return;
            }


        }
    }

