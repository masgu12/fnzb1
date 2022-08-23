using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    NavMeshAgent agent;
    GameObject player;
    Animator anim;
    public float zombieHP = 100;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float dist = Vector3.Distance(transform.position, player.transform.position);
        anim.SetFloat("distance", dist);
        if (dist < 2.5f) agent.speed = 0;
        else agent.SetDestination(player.transform.position);
    }
}
