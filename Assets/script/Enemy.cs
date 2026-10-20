using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform Target;

    NavMeshAgent nav;
    Rigidbody rb;

    void Awake()
    {
        nav = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        nav.stoppingDistance = 3;

        // 1번째 방법
        if (Target != null)
        {
            nav.SetDestination(Target.position);
        }
    }
}