using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class enemyAI : MonoBehaviour
{
    //ele vai direito ao jogador e contorna os obstaculos
    public float deathDistance = 0.5f;
    public float distanceAway;
    public Transform thisEnemy;
    public Transform target;
    private NavMeshAgent navComponent;
    private Animator animator;
    public int targetDamage = 5;
    public int healthPlayer = 100;

    // Use this for initialization
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        navComponent = this.gameObject.GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {

        float dist = Vector3.Distance(target.position, transform.position);

        if (target)
        {
            navComponent.SetDestination(target.position);
            animator.SetTrigger("Walk");
        }
        else
        {
            if (target = null)
            {
                target = this.gameObject.GetComponent<Transform>();
            }
            else
            {
                target = GameObject.FindGameObjectWithTag("Player").transform;
            }
        }
        if (dist <= deathDistance)
        {
            animator.SetTrigger("Attack");
            healthPlayer -= 1;
        }

        if (healthPlayer <= 0)
        {
            healthPlayer = 0;
            SceneManager.LoadScene(2);
        }

    }
}