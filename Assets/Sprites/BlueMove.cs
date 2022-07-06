using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueMove : MonoBehaviour
{
    public float speed;
    private Transform target;
    public float seeDistance = 120f;
    public float attackDistance = 122f;

    public GameObject Laser1;

    public int lives = 3;
    
    public GameObject PlayAudioDeathB;
    public int scoreRed;
    public ScoreManager scoreManager;


    [SerializeField]
    private GameObject BlueExploisonPrefab;

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
        target = GameObject.FindWithTag("VirusGreen").transform;
        //target = GameObject.FindGameObjectWithTag("VirusGreen").GetComponent<Transform>();
        //Laser1.SetActive(false);
        PlayAudioDeathB.SetActive(false);
        
    }


    private void Update()
    {
        // transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.transform.position) < seeDistance)
        {
           
                transform.LookAt(target.transform);
                transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
           
        }

        if (lives == 0)
        {
            PlayAudioDeathB.SetActive(true);
            scoreManager.AddScoreRed(scoreRed);
            Instantiate(BlueExploisonPrefab, transform.position, Quaternion.identity);
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

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "VirusRed")
            {
                TakeDamageBlue();

            }


        }
    }

