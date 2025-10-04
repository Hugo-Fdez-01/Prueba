using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public class EnemyOrc : Enemy
    {
        public override void Attack()
        {
            health = 999;
            base.Attack();
            Debug.Log("I'm an Orc");
        }

        public override void Defense()
        {
            Debug.Log($"Enemy '{_title}' DEFENSE. Health: '{health}'");
        }
    }
}
