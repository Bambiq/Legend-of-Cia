using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowAttack : MonoBehaviour
{
    public Vector2 direction;
    [SerializeField] Transform hand;

    void Update()
    {
        RotateHand();
    }

    void RotateHand()
    {
        float angle = Utility.AngleTowardsMouse(hand.position);
        hand.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    }
}
