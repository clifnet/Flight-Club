﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Health : MonoBehaviour {
    public int maxHealth = 100;
    public int currentHealth;
    protected PlayerMover mover;

    // Use this for initialization
    protected void Awake()
    {
        currentHealth = maxHealth;
        mover = GetComponent<PlayerMover>();
    }
    public abstract int takeDamage(int damage);
    public void reset()
    {
        currentHealth = maxHealth;
    }
        // Update is called once per frame
    void Update () {
		
	}
}
