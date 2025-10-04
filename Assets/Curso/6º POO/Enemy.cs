using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Course
{
    public abstract class Enemy : MonoBehaviour
    {
        [Header("Enemy")]
        [SerializeField] protected string _title;
        [SerializeField] protected int damage;
        [SerializeField] protected float health;

        public string Title { get { return _title; }set { _title = value; } }

        private void Start()
        {
            Attack();
        }

        public virtual void Attack()
        {
            Debug.Log($"Enemy '{_title}' ATTACK. Damage: '{damage}'");
        }

        public abstract void Defense();
        
    }
}
