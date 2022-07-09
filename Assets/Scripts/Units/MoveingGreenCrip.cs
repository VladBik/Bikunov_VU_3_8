using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveingGreenCrip : MonoBehaviour
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
    private GameObject Laser3;
    [SerializeField]
    private int lives = 3;
    [SerializeField]
    private GameObject PlayAudioDeathG;
    
    public int scoreBlue;
    public ScoreManager scoreManager;


    //[SerializeField]
    //private GameObject GreenExploisonPrefab;

    private void Start()
    {
        FindGameController();
        PlayAudioDeathG.SetActive(false);
            
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
        Destroy(gameObject, 30f);
        TargetGreenMove();

        if (lives <= 0)
        {
            DeathGreen();
        }
        else
        {
            return;
        }
 
    }

    private void TargetGreenMove()
    {
        target = GameObject.FindWithTag("VirusRed").transform;
        if (Vector3.Distance(transform.position, target.transform.position) < seeDistance)
        {
            transform.LookAt(target.transform);
            transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
        }
    }

    private void DeathGreen()
    {
        PlayAudioDeathG.SetActive(true);
        scoreManager.AddScoreBlue(scoreBlue);
        Debug.Log("синяя пуля дура");
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
        else if (collision.tag == null)
        {
            return;
        }


    }
}
