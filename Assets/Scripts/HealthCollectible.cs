﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    public PickupEffect pickupEffect;
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();
        
        if (controller != null)
        {
            if(controller.health < controller.maxHealth)
            {
                pickupEffect.transform.position = transform.position;
                Instantiate(pickupEffect);
                controller.ChangeHealth(1);
                controller.PlaySound(collectedClip);
                Destroy(gameObject);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
